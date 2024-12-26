using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodWithoutAbstraction
{
	internal class ConcreteProduct2 : ConcreteProduct1
	{
		public ConcreteProduct2(string info) : base(info) => info = info;

		public virtual void Transform() => _info = "==" + string.Join("*", _info.ToArray()) + "==";
	}
}
