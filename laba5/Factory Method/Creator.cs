using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public abstract class Creator
	{
		public abstract Product FactoryMethod(string info);

		public string AnOperation(string info)
		{
			Product product = FactoryMethod(info);
			product.Transform();
			product.Transform();
			return product.Info;
		}

	}
}
