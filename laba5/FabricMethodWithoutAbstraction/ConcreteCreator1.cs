using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;

namespace FactoryMethodWithoutAbstraction
{
	internal class ConcreteCreator1
	{
		public virtual ConcreteProduct1 FactoryMethod(string info) { 
			ConcreteProduct1 product = new(info);
			return product;
		}

		public string AnOperation(string info)
		{
			ConcreteProduct1 product = FactoryMethod(info);
			product.Transform();
			product.Transform();
			return product.Info;
		}
	}
}
