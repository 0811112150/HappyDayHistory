using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ContextPropagation.Service;
using ContextPropagation;

namespace ContextPropagation.Hosting
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var host = new ServiceHost(typeof(ContextPropagation.Service.Service))) {
				host.Opened += delegate {
					Console.WriteLine("服务已启动...");
				};

				host.Open();

				Console.ReadLine();
			}
		}
	}
}
