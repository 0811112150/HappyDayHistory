using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace ContextPropagation
{
	public class ContextReceivalCallContextInitializer : ICallContextInitializer
	{
		public bool IsBidirectional { get; set; }

		public ContextReceivalCallContextInitializer() : this(false) { }

		public ContextReceivalCallContextInitializer(bool isBidirectional)
		{
			this.IsBidirectional = isBidirectional;
		}

		public void AfterInvoke(object correlationState)
		{
			if (!this.IsBidirectional) {
				return;
			}

			ApplicationContext context = correlationState as ApplicationContext;
			if (context == null) {
				return;
			}

			MessageHeader<ApplicationContext> contextHeader = new MessageHeader<ApplicationContext>(context);

			OperationContext.Current.OutgoingMessageHeaders.Add(contextHeader.GetUntypedHeader(ApplicationContext.ContextHeaderLocalName, ApplicationContext.ContextHeaderNameSpace));
			ApplicationContext.Current = null;
		}

		public object BeforeInvoke(InstanceContext instanceContext, IClientChannel channel, Message message)
		{
			ApplicationContext context = message.Headers.GetHeader<ApplicationContext>(ApplicationContext.ContextHeaderLocalName, ApplicationContext.ContextHeaderNameSpace);
			if (context == null) { return null; }

			ApplicationContext.Current = context;
			return ApplicationContext.Current;
		}
	}
}
