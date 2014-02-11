using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MyCustomRequest.Channels
{
	public class MyBindingElement : BindingElement
	{

		public override BindingElement Clone()
		{
			return new MyBindingElement();
		}

		public override T GetProperty<T>(BindingContext context)
		{
			return context.GetInnerProperty<T>();
		}

		public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
		{
			Console.WriteLine("MyBindingElement.BuildChannelFactory()");
			return new MyChannelFactory<TChannel>(context) as IChannelFactory<TChannel>;
		}

		public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)
		{
			Console.WriteLine("MyBindingElement.BuildChannelListener()");
			return new MyChannelListener<TChannel>(context) as IChannelListener<TChannel>;
		}
	}
}
