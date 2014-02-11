using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResponsibleService.Contract;
using System.Configuration;
using System.ServiceModel;

namespace ResponsibleService.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			Order order1 = new Order(Guid.NewGuid(), DateTime.Today.AddDays(5), Guid.NewGuid(), "Supplier A");
			Order order2 = new Order(Guid.NewGuid(), DateTime.Today.AddDays(-5), Guid.NewGuid(), "Supplier A");

			string path = ConfigurationManager.AppSettings["msmqPath"];
			var address = new Uri(path);
			OrderResponseContext context = new OrderResponseContext();
			context.ResponseAddress = address;

			var channelFactory = new ChannelFactory<IOrderProcesser>("defaultEndpoint");
			var orderProcessor = channelFactory.CreateChannel();
			using (var contextScope = new OperationContextScope(orderProcessor as IContextChannel)) {
				Console.WriteLine("Submit the order of order No.: {0}", order1.OrderNo);
				OrderResponseContext.Current = context;
				orderProcessor.Submit(order1);
			}

			using (OperationContextScope contextScope = new OperationContextScope(orderProcessor as IContextChannel)) {
				Console.WriteLine("Submit the order of order No.: {0}", order2.OrderNo);
				OrderResponseContext.Current = context;
				orderProcessor.Submit(order2);
			}

			Console.Read();
		}
	}
}
