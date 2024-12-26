using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public abstract class Product
	{
		protected string _info;
		public string Info { get => _info; }
		public abstract void Transform();
	}
}
