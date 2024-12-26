using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	class ConcreteFactory1 : AbstractFactory
	{
		public override ProductA1 CreateProductA(int param) { return new ProductA1(param); }
		public override ProductB1 CreateProductB(int param) { return new ProductB1(param); }
	}
}
