using ThreadTask;

internal class Program
{
	private static void Main(string[] args)
	{
		ThreadWorker worker = new ThreadWorker();
        worker.Work();
		//while (true)
		//{
		//	string input = Console.ReadLine();
		//	worker.Work();
		//	if (input == "exit")
		//	{
		//		break;
		//	}
		//}
	}
}
