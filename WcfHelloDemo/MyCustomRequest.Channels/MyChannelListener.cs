using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;

namespace MyCustomRequest.Channels
{
	public class MyChannelListener<TChannel> : ChannelListenerBase<TChannel> where TChannel : class ,IChannel
	{
		private IChannelListener<TChannel> InnerChannelListener { get; set; }

		public MyChannelListener(BindingContext context)
		{
			InnerChannelListener = context.BuildInnerChannelListener<TChannel>();
		}

		protected override TChannel OnAcceptChannel(TimeSpan timeout)
		{
			Console.WriteLine("MyChannelListener<TChannel>.OnAcceptChannel()");
			TChannel innerChannel = InnerChannelListener.AcceptChannel(timeout);
			return new MyReplayChannel(this, innerChannel as IReplyChannel) as TChannel;
		}

		protected override IAsyncResult OnBeginAcceptChannel(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		protected override TChannel OnEndAcceptChannel(IAsyncResult result)
		{
			throw new NotImplementedException();
		}

		protected override IAsyncResult OnBeginWaitForChannel(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		protected override bool OnEndWaitForChannel(IAsyncResult result)
		{
			throw new NotImplementedException();
		}

		protected override bool OnWaitForChannel(TimeSpan timeout)
		{
			throw new NotImplementedException();
		}

		public override Uri Uri
		{
			get { throw new NotImplementedException(); }
		}

		protected override void OnAbort()
		{
			throw new NotImplementedException();
		}

		protected override IAsyncResult OnBeginClose(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		protected override IAsyncResult OnBeginOpen(TimeSpan timeout, AsyncCallback callback, object state)
		{
			throw new NotImplementedException();
		}

		protected override void OnClose(TimeSpan timeout)
		{
			throw new NotImplementedException();
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
			InnerChannelListener.Open();
		}
	}
}
