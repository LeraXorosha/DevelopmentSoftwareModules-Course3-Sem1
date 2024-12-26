using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class ConcreteProduct1 : Product
	{
		public ConcreteProduct1(string info) => _info = info.ToLower();
		public override void Transform() => _info = string.Join(" ", _info.ToArray());
	}
}
