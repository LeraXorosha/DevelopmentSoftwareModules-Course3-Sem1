using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
	public class ConcreteProduct2 : Product
	{
		public ConcreteProduct2(string info) => _info = info.ToUpper();

		public override void Transform() => _info = string.Join("*", _info.ToArray());
	}
}
