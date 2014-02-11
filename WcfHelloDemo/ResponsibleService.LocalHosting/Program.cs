using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ResponsibleService.LocalService;
using System.Configuration;
using System.Messaging;

namespace ResponsibleService.LocalHosting
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

			using (var host = new ServiceHost(typeof(OrderRessponseService))) {
				host.Opened += delegate {
					Console.WriteLine("The Order Response service has begun to listen");
				};

				 host.Open();
				Console.Read();
			}
		}
	}
}
