using FactoryMethodWithoutAbstraction;


internal class Program
{
	private static void Main(string[] args)
	{
		ExecuteExample();
	}

	static void ExecuteExample()
	{
		List<string> strings = new List<string> { "Hello, World!", "Сколько лет, сколько зим!", "Земля в иллюминаторе", "1234", "56789" };

		ConcreteCreator1 firstCreator = new ConcreteCreator1();
		foreach (string str in strings)
		{
			Console.WriteLine(firstCreator.AnOperation(str));
		}

		Console.WriteLine();

		ConcreteCreator2 secondCreator = new ConcreteCreator2();
		foreach (string str in strings)
		{
			Console.WriteLine(secondCreator.AnOperation(str));
		}
	}

}

