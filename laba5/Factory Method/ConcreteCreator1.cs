using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class ConcreteCreator1 : Creator
	{
		public override Product FactoryMethod(string info) { return new ConcreteProduct1(info); }
	}	
}
