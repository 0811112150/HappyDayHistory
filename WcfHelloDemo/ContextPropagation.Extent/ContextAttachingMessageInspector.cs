using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ContextPropagation.Extent
{
	public class ContextAttachingMessageInspector : IClientMessageInspector
	{
		/// <summary>
		/// 是否支持双向传递
		/// </summary>
		public bool IsBidirectional { get; set; }

		public ContextAttachingMessageInspector() : this(false) { }

		public ContextAttachingMessageInspector(bool isBidirectional)
		{
			Console.WriteLine("ContextAttachingMessageInspector" + isBidirectional);
			this.IsBidirectional = isBidirectional;
		}

		public void AfterReceiveReply(ref Message reply, object correlationState)
		{
			if (!IsBidirectional) {
				return;
			}

			if (reply.Headers.FindHeader(ApplicationContext.ContextHeaderLocalName, ApplicationContext.ContextHeaderNameSpace) < 0) {
				return;
			}

			ApplicationContext context = reply.Headers.GetHeader<ApplicationContext>(ApplicationContext.ContextHeaderLocalName, ApplicationContext.ContextHeaderNameSpace);
			if (context == null) {
				return;
			}
			ApplicationContext.Current = context;
		}

		public object BeforeSendRequest(ref Message request, IClientChannel channel)
		{
			MessageHeader<ApplicationContext> contextHeader = new MessageHeader<ApplicationContext>(ApplicationContext.Current);

			request.Headers.Add(contextHeader.GetUntypedHeader(ApplicationContext.ContextHeaderLocalName, ApplicationContext.ContextHeaderNameSpace));

			return null;
		}
	}
}
