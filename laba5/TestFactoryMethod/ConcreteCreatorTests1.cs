using FactoryMethod;
using System.Runtime.InteropServices;

namespace TestFactoryMethod
{
	public class ConcreteCreatorTests1
	{
		[Fact]
		public void ReturnProduct1()
		{
			Creator firstCreator = new ConcreteCreator1();
			Product actual = firstCreator.FactoryMethod("inoplanet");
			Assert.IsType<ConcreteProduct1>(actual);
		}
	}
}