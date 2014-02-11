using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace AutomationStudy.Demo1
{
	class Program
	{
		static void Main(string[] args)
		{
			var desktop = AutomationElement.RootElement;
			var target = desktop.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NameProperty, "计算机一班"));
			if (target != null) {
				
			}
			Console.ReadLine();
		}
	}
}
