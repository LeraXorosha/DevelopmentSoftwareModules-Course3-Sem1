using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryMethod
{
	public class ConcreteCreatorTests2
	{
		[Fact]
		public void ReturnProduct2()
		{
			Creator secondCreator = new ConcreteCreator2();
			Product actual = secondCreator.FactoryMethod("golden planet");
			Assert.IsType<ConcreteProduct2>(actual);
		}
	}
}
