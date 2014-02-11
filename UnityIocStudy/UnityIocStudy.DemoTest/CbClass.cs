using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityIocStudy.DemoTest
{
	public class CbClass : IClass
	{
		#region IClass 成员

		public string ClassName { get; set; }

		public void ShowInfo()
		{
			Console.WriteLine("计科班：{0}", ClassName);
		}

		#endregion
	}
}
