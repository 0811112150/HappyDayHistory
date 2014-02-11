using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using MessageInterceptor.Service;

namespace MessageInterceptor.Hosting
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ServiceHost host = new ServiceHost(typeof(Service1))) {
				host.Opened += delegate {
					Console.WriteLine("The calculate service has been started up!");
				};
				host.Open();
				Console.Read();
			}
		}
	}
}
