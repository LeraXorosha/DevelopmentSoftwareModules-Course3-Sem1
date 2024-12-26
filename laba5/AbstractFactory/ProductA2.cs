using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	class ProductA2 : AbstractProductA
	{
		public ProductA2(int param) => _info = param.ToString();
		public override void MethodA()
		{
			string result = _info + _info;
			_info = result;
		}
	}
}
