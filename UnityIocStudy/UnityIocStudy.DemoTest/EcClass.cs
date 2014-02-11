using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityIocStudy.DemoTest
{
	class EcClass : IClass
	{
		#region IClass 成员

		public string ClassName { get; set; }

		public void ShowInfo()
		{
			Console.WriteLine("电商班：{0}", ClassName);
		}

		#endregion
	}
}
