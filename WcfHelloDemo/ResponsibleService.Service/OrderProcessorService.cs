using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResponsibleService.Contract;
using System.ServiceModel;
using System.Net.Security;

namespace ResponsibleService.Service
{
	public class OrderProcessorService : IOrderProcesser
	{
		private void ProcessOrder(Order order)
		{
			if (order.OrderDate < DateTime.Now) {
				throw new Exception();
			}
		}

		public void Submit(Order order)
		{
			Console.WriteLine("Begin to process the order of the order No.: {0}", order.OrderNo);
			FaultException exception = null;
			if (order.OrderDate < DateTime.Now) {
				exception = new FaultException(new FaultReason("The order has expried"), new FaultCode("sender"));
				Console.WriteLine("It's fail to process the order.\n\tOrder No.: {0}\n\tReason:{1}", order.OrderNo, "The order has expried");
			} else {
				Console.WriteLine("It's successful to process the order.\n\tOrder No.: {0}", order.OrderNo);
			}
			NetMsmqBinding binding = new NetMsmqBinding();
			binding.ExactlyOnce = false;
			binding.Security.Transport.MsmqAuthenticationMode = MsmqAuthenticationMode.None;
			binding.Security.Transport.MsmqProtectionLevel = ProtectionLevel.None;

			ChannelFactory<IOrderRessponse> channelFactory = new ChannelFactory<IOrderRessponse>(binding);
			OrderResponseContext responseContext = OrderResponseContext.Current;

			IOrderRessponse channel = channelFactory.CreateChannel(new EndpointAddress(responseContext.ResponseAddress));

			using (OperationContextScope contextScope = new OperationContextScope(channel as IContextChannel)) {				
				channel.SubmitOrderResponse(order.OrderNo, exception);
			}
			Console.Read();
		}
	}
}
