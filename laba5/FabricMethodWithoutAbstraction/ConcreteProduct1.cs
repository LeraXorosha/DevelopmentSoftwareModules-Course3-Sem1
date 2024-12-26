using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;
namespace FactoryMethodWithoutAbstraction
{
	internal class ConcreteProduct1
	{
		protected string _info;
		public string Info { get { return _info; } set { } }
		public ConcreteProduct1(string info) => _info = info;

		public virtual void Transform() => _info = string.Join("*", _info.ToArray());
		
	}
}
