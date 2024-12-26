using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections;

namespace ThreadTask
{
	public class ThreadWorker
	{
		private List<Person> personList = new List<Person>();
		private Thread _backgroundThread;
		private Queue<string> inputQueue = new Queue<string>();
		private Mutex _queueMutex = new Mutex();
		private AutoResetEvent signal = new AutoResetEvent(false);
		private object listLock = new object();
		

		
		public void Work()
		{

			Thread _backgroundThread = new Thread(ThreadMethod);
			_backgroundThread.Start();
			Console.WriteLine("Введите одну из команд: \n\n[1]create - создать персону\n[2]list - посмотреть список персон\n[3]exit-завершить работу программы\n ");

			while (true) {

				string input = Console.ReadLine().ToLower();

				switch (input)
				{
					case "create":
						Console.WriteLine("Введите имя персоны:");
						string name = Console.ReadLine();
						Console.WriteLine("Введите возраст персоны:");
						int age;
						while (!int.TryParse(Console.ReadLine(), out age))
						{
							Console.WriteLine("Некорректный возраст. Попробуйте ещё раз:");
						}
						_queueMutex.WaitOne();
						inputQueue.Enqueue($"{name},{age}");
						_queueMutex.ReleaseMutex();
						signal.Set();

						break;


					case "list":
						
						if (Monitor.TryEnter(listLock))
						{
							foreach (var person in personList)
							{
								Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
							}
							Monitor.Exit(listLock);
						}
						else
						{
							Console.WriteLine("Список занят, попробуйте позже.");
						}
						break;

					case "Exit":
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Неизвестная команда");
						break;

				}
			}

		}

		private void ThreadMethod()
		{
			while (true)
			{
				signal.WaitOne();
				while (inputQueue.Count > 0)
				{
					_queueMutex.WaitOne();
					string data = inputQueue.Dequeue();
					_queueMutex.ReleaseMutex();
					string[] parts = data.Split(',');
					string name = parts[0].Trim();
					int age = int.Parse(parts[1].Trim());
					lock (listLock)
					{
						personList.Add(new Person(name, age));
						Console.WriteLine($"Добавлена персона: {name}, Возраст: {age}");
						Console.WriteLine("Сортирую список...");
						Thread.Sleep(200);
						personList.Sort((x, y) => x.Age.CompareTo(y.Age));
						Thread.Sleep(2000);
					}
				}
			}
		}
	}
}
