using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfHelloDemo.Contract;
using System.ServiceModel;
using System.Threading;

namespace WcfHelloDemo.Service
{
	[ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class Hello : IHello
	{
		public void SayHello(string content)
		{
			ICallback callback = OperationContext.Current.GetCallbackChannel<ICallback>();

			content = content + "已调用服务";
			Console.WriteLine(content);
			ThreadPool.QueueUserWorkItem(delegate {
				callback.DisplayResult(content);
			});
		}
	}
}
