using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	class ProductB2 : AbstractProductB
	{
		public ProductB2(int param) => _info = param.ToString();
		public override void MethodB(AbstractProductA abstractProductA)
		{
			string result = _info + abstractProductA.Info;
			_info = result.ToString();
		}
	}
}
