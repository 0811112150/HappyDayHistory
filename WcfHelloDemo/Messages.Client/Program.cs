using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Messages.Contract;
using System.ServiceModel.Channels;
using System.Globalization;
using System.Threading;

namespace Messages.Client
{
	class Program
	{
		private const string CultureInfoHeadLocalName = "__CultureInfo";
		private const string CultyreInfoHeaderNamespace = "urn:artech.com";

		static void Main(string[] args)
		{
			using (var channelFactory = new ChannelFactory<IMessage>("messageService")) {
				IMessage proxy = channelFactory.CreateChannel();

				using (OperationContextScope contextScope = new OperationContextScope(proxy as IContextChannel)) {

					Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
					MessageHeader<CultureInfo> header = new MessageHeader<CultureInfo>(Thread.CurrentThread.CurrentUICulture);

					OperationContext.Current.OutgoingMessageHeaders.Add(header.GetUntypedHeader(CultureInfoHeadLocalName, CultyreInfoHeaderNamespace));
					Console.WriteLine("The UI culture of current thread is {0}", Thread.CurrentThread.CurrentUICulture);
					Console.WriteLine(proxy.GetMessage());
				}

				using (OperationContextScope scope = new OperationContextScope(proxy as IContextChannel)) {
					Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-cn");
					MessageHeader<CultureInfo> header = new MessageHeader<CultureInfo>(Thread.CurrentThread.CurrentUICulture);

					OperationContext.Current.OutgoingMessageHeaders.Add(header.GetUntypedHeader(CultureInfoHeadLocalName, CultyreInfoHeaderNamespace));
					Console.WriteLine("The UI culture of current thread is {0}", Thread.CurrentThread.CurrentUICulture);
					Console.WriteLine(proxy.GetMessage());

					Console.ReadLine();
				}
			}
		}
	}
}
