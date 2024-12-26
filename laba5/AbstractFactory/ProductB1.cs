using AbstractFactoryTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryTask
{
	class ProductB1 : AbstractProductB
	{
		public ProductB1(int param) => _info = param.ToString();
		public override void MethodB(AbstractProductA abstractProductA)
		{
			int thisNum = int.Parse(_info); 
			int otherNum = int.Parse(abstractProductA.Info); 
			int result = thisNum + otherNum; 
			_info = result.ToString();
		}
	}
}
