using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Messages.Contract;
using System.Threading;
using System.ServiceModel;
using System.Globalization;

namespace Messages.Service
{
	public class MessageService : IMessage
	{
		private const string CultureInfoHeadLocalName = "__CultureInfo";
		private const string CultyreInfoHeaderNamespace = "urn:artech.com";

		public string GetMessage()
		{
			//CultureInfo t = OperationContext.Current.IncomingMessageHeaders.GetHeader<CultureInfo>(CultureInfoHeadLocalName, CultyreInfoHeaderNamespace);
			//Thread.CurrentThread.CurrentUICulture = t;
			return string.Format("{0}{1}{2}", Thread.CurrentThread.CurrentUICulture, "    ", MessageServiceResources.HelloWorld);
		}
	}
}
