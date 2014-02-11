using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WindowsServiceStudy
{
	public partial class ServiceTest : ServiceBase
	{
		public ServiceTest()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			Console.WriteLine("服务正在启动。。。");
		}

		protected override void OnStop()
		{
			Console.WriteLine("服务已关闭。。。");
		}
	}
}
