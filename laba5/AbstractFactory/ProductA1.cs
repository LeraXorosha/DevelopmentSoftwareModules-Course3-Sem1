using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	class ProductA1 : AbstractProductA
	{
		public ProductA1(int param) => _info = param.ToString();

		public override void MethodA()
		{
			int num = int.Parse(_info);
			int result = num * 2; 
			_info = result.ToString(); 
		}
	}
}
