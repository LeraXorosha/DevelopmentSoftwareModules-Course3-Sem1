using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace TestFactoryMethod
{
	public class StringInfoToLower
	{
		[Theory]
		[InlineData("HELLO WORLD", "hello world")]
		[InlineData("Hello World", "hello world")]
		[InlineData("HeLlO WoRlD", "hello world")]
		public void InfoToLower(string input, string expected)
		{
			ConcreteProduct1 product = new ConcreteProduct1(input);
			string actual = product.Info;
			Assert.Equal(expected, actual);
		}
	}
}
