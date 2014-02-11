using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ContextPropagation.Contract;
using ContextPropagation.Extent;

namespace ContextPropagation.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var channelFactory = new ChannelFactory<IContract>("ContextPropagation")) {
				var proxy = channelFactory.CreateChannel();
				using (var t = new OperationContextScope(proxy as IContextChannel)) {
					ApplicationContext.Current.Counter = 100;
					Console.WriteLine("Brfore service invocation: ApplicationContext.Current.Count = {0}", ApplicationContext.Current.Counter);
					
					proxy.DoSomething();
					Console.WriteLine("After service invocation: ApplicationContext.Current.Count = {0}", ApplicationContext.Current.Counter);
					Console.Read();
				}
			}
		}
	}
}
