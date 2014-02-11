using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Messaging;
using System.ServiceModel;
using ResponsibleService.Service;

namespace ResponsibleService.Hosting
{
	class Program
	{
		static void Main(string[] args)
		{
			var path = ConfigurationManager.AppSettings["msmqPath"];
			if (!MessageQueue.Exists(path)) {
				//MessageQueue.Delete(path);
				MessageQueue.Create(path);
			}

			using (var host = new ServiceHost(typeof(OrderProcessorService))) {
				host.Opened += delegate {
					Console.WriteLine("The Order Processor service has begun to listen");
				};

				host.Open();
				Console.Read();
			}
		}
	}
}
