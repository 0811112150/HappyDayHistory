using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WcfHelloDemo.Service;
using System.ServiceModel.Description;
using WcfHelloDemo.Contract;
using System.Threading;

namespace WcfHelloDemo.Host
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var host = new ServiceHost(typeof(Hello))) {
				//host.AddServiceEndpoint(typeof(IHello), new WSHttpBinding(), "http://127.0.0.1:8888/hello");
				//if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null) {
				//    var behavior = new ServiceMetadataBehavior();
				//    behavior.HttpGetEnabled = true;
				//    behavior.HttpGetUrl = new Uri("http://127.0.0.1:8888/hello/metadata");
				//    host.Description.Behaviors.Add(behavior);
				//}
				Console.WriteLine("服务转正启动...");
				host.Open();
				Console.WriteLine("服务已启动...");
				Console.Read();
			}
		}
	}
}
