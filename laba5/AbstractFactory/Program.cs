using AbstractFactoryTask;

internal class Program
{
	private static void Main(string[] args)
	{
		ExecuteExample(FactoryType.valueSecond);

	}

	static void ExecuteExample(FactoryType factoryType)
	{
		int infoA = 5, infoB = 5;
		string str = "A";
		AbstractFactory factory;
		AbstractProductA productA;
		AbstractProductB productB;

		factory = ((int)factoryType == 1) ? new ConcreteFactory1() : new ConcreteFactory2();
		productA = factory.CreateProductA(infoA);
		productB = factory.CreateProductB(infoB);
		foreach (var letter in str)
		{
			if (letter == 'A') productA.MethodA();
			else productB.MethodB(productA);
		}
		Console.WriteLine(productA.Info);
		Console.WriteLine(productB.Info);
	}

	enum FactoryType
	{
		valueFirst = 1,
		valueSecond = 2
	}

}

