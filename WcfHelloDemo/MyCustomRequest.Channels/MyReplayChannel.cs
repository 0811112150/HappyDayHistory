using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace MyCustomRequest.Channels
{
	public class MyReplayChannel : ChannelBase, IReplyChannel
	{
		private IReplyChannel InnerChannel { get; set; }

		public MyReplayChannel(ChannelManagerBase channelManager, IReplyChannel innerChannel)
			: base(channelManager)
		{
			InnerChannel = innerChannel;
		}

		#region ChannelBase
		protected override void OnAbort()
		{
			InnerChannel.Abort();
		}

		protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
		{
			return InnerChannel.BeginClose(timeout, callback, state);
		}

		protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
		{
			return InnerChannel.BeginOpen(timeout, callback, state);
		}

		protected override void OnClose(TimeSpan timeout)
		{
			InnerChannel.Close(timeout);
		}

		protected override void OnEndClose(IAsyncResult result)
		{
			throw new NotImplementedException();
		}

		protected override void OnEndOpen(IAsyncResult result)
		{
			throw new NotImplementedException();
		}

		protected override void OnOpen(TimeSpan timeout)
		{
			InnerChannel.Open();
		}
		#endregion

		#region IReplyChannel
		public IAsyncResult BeginReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		public IAsyncResult BeginReceiveRequest(AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		public IAsyncResult BeginTryReceiveRequest(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		public IAsyncResult BeginWaitForRequest(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		public RequestContext EndReceiveRequest(IAsyncResult result)
		{
			throw new NotImplementedException();
		}

		public bool EndTryReceiveRequest(IAsyncResult result, out RequestContext context)
		{
			throw new NotImplementedException();
		}

		public bool EndWaitForRequest(IAsyncResult result)
		{
			throw new NotImplementedException();
		}

		public EndpointAddress LocalAddress
		{
			get { throw new NotImplementedException(); }
		}

		public RequestContext ReceiveRequest(TimeSpan timeout)
		{
			return InnerChannel.ReceiveRequest(timeout);
		}

		public RequestContext ReceiveRequest()
		{
			return InnerChannel.ReceiveRequest();
		}

		public bool TryReceiveRequest(TimeSpan timeout, out RequestContext context)
		{
			throw new NotImplementedException();
		}

		public bool WaitForRequest(TimeSpan timeout)
		{
			return InnerChannel.WaitForRequest(timeout);
		}
		#endregion
	}
}
