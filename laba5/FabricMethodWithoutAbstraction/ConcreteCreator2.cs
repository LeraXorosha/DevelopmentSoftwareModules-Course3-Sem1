using FactoryMethodWithoutAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;

namespace FactoryMethodWithoutAbstraction
{
	internal class ConcreteCreator2 : ConcreteCreator1
	{
		public override ConcreteProduct1 FactoryMethod(string info) { return new ConcreteProduct2(info); }
	}
}


