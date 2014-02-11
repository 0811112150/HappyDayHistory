using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MessageInterceptor.Contract;
using System.Threading;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MessageInterceptor.Service
{
	[ServiceBehavior(UseSynchronizationContext = false, AddressFilterMode = AddressFilterMode.Any)]
	public class InterceptService : IIntercept
	{
		private const string CalculateServiceEndpoint = "calculateService";

		public static SynchronizationContext SynchronizationContext { get; set; }

		public static System.Windows.Forms.TextBox MessageDisplayPanel { get; set; }

		public Message Intercept(Message request)
		{
			using (var channelFactory = new ChannelFactory<IIntercept>(CalculateServiceEndpoint)) {
				IIntercept interceptor = channelFactory.CreateChannel();

				using (interceptor as IDisposable) {
					MessageBuffer requestBuffer = request.CreateBufferedCopy(int.MaxValue);
					var response = interceptor.Intercept(requestBuffer.CreateMessage());
					MessageBuffer responseBuffer = response.CreateBufferedCopy(int.MaxValue);
					SynchronizationContext.Post(delegate {
						MessageDisplayPanel.Text += string.Format("Request:{0}{1}{0}", Environment.NewLine, request);
						MessageDisplayPanel.Text += string.Format("Response:{0}{1}{0}", Environment.NewLine, response);
					}, null);
					return responseBuffer.CreateMessage();
				}
			}
		}
	}
}
