using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MyCustomRequest.Channels
{
	public class MyRequestChannel : ChannelBase, IRequestChannel
	{
		private IRequestChannel InnerChannel { get; set; }

		public MyRequestChannel(ChannelManagerBase channelManager, IRequestChannel innerChannel)
			: base(channelManager)
		{
			InnerChannel = innerChannel;
		}

		#region ChannelBase Members

		protected override void OnAbort()
		{
			Console.WriteLine("MyRequestChannel.OnAbort()");
			this.InnerChannel.Abort();
		}

		protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
		{
			Console.WriteLine("MyRequestChannel.OnBeginClose()");
			return this.InnerChannel.BeginClose(timeout, callback, state);
		}

		protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
		{
			Console.WriteLine("MyRequestChannel.OnBeginOpen()");
			return this.InnerChannel.BeginOpen(timeout, callback, state);
		}

		protected override void OnClose(TimeSpan timeout)
		{
			Console.WriteLine("MyRequestChannel.OnClose()");
			this.Close(timeout);
		}

		protected override void OnEndClose(IAsyncResult result)
		{
			Console.WriteLine("MyRequestChannel.OnEndClose()");
			this.InnerChannel.EndClose(result);
		}

		protected override void OnEndOpen(IAsyncResult result)
		{
			Console.WriteLine("MyRequestChannel.OnEndOpen()");
			this.InnerChannel.EndOpen(result);
		}

		protected override void OnOpen(TimeSpan timeout)
		{
			Console.WriteLine("MyRequestChannel.OnOpen()");
			this.InnerChannel.Open(timeout);
		}
		#endregion

		#region IRequestChannel Members

		public IAsyncResult BeginRequest(Message message, TimeSpan timeout, AsyncCallback callback, object state)
		{
			Console.WriteLine("MyRequestChannel.BeginRequest()");
			return this.BeginRequest(message, timeout, callback, state);
		}

		public IAsyncResult BeginRequest(Message message, AsyncCallback callback, object state)
		{
			Console.WriteLine("MyRequestChannel.BeginRequest()");
			return this.InnerChannel.BeginRequest(message, callback, state);
		}

		public Message EndRequest(IAsyncResult result)
		{
			Console.WriteLine("MyRequestChannel.EndRequest()");
			return this.InnerChannel.EndRequest(result);
		}

		public EndpointAddress RemoteAddress
		{
			get
			{
				Console.WriteLine("MyRequestChannel.RemoteAddress");
				return this.InnerChannel.RemoteAddress;
			}
		}

		public Message Request(Message message, TimeSpan timeout)
		{
			Console.WriteLine("MyRequestChannel.Request()");
			return this.InnerChannel.Request(message, timeout);
		}

		public Message Request(Message message)
		{
			Console.WriteLine("MyRequestChannel.Request()");
			return this.InnerChannel.Request(message);
		}

		public Uri Via
		{
			get
			{
				Console.WriteLine("MyRequestChannel.Via)");
				return this.InnerChannel.Via;
			}
		}

		#endregion

	}
}
