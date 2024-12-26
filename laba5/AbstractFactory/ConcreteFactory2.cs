using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	class ConcreteFactory2 : AbstractFactory
	{
		public override ProductA2 CreateProductA(int param) { return new ProductA2(param); }
		public override ProductB2 CreateProductB(int param) { return new ProductB2(param); }
	}
}
