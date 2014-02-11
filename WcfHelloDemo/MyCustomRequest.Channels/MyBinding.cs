using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;

namespace MyCustomRequest.Channels
{
	public class MyBinding : Binding
	{
		public override BindingElementCollection CreateBindingElements()
		{
			BindingElementCollection elements = new BindingElementCollection();
			elements.Add(new TextMessageEncodingBindingElement());
			elements.Add(new MyBindingElement());
			elements.Add(new HttpTransportBindingElement());
			return elements.Clone();
		}

		public override string Scheme
		{
			get { return "http"; }
		}
	}
}
