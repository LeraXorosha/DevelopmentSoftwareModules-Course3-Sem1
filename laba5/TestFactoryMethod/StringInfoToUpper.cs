using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryMethod
{
	public class StringInfoToUpper
	{
		[Theory]
		[InlineData("hello world", "HELLO WORLD")]
		[InlineData("Hello World", "HELLO WORLD")]
		[InlineData("HeLlO WoRlD", "HELLO WORLD")]
		public void InfoToUpper(string input, string expected)
		{
			ConcreteProduct2 product = new ConcreteProduct2(input);
			string actual = product.Info;
			Assert.Equal(expected, actual);
		}
	}
}
