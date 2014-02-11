using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Messages.Service;
using Messages.CallContextInitializers;

namespace Messages.Hosting
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var host = new ServiceHost(typeof(MessageService))) {

				host.Opened += delegate { Console.WriteLine("服务已开启..."); };

				host.Open();


				Console.ReadLine();
			}
		}
	}
}
