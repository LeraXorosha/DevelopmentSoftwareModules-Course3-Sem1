using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	abstract class AbstractFactory
	{
		public abstract AbstractProductA CreateProductA(int param);
		public abstract AbstractProductB CreateProductB(int param);
	}
}
