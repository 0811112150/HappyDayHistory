using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using MessageInterceptor.Contract;

namespace MessageInterceptor.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ChannelFactory<IContract> channelFactory = new ChannelFactory<IContract>("calculateservice")) {
				IContract calculator = channelFactory.CreateChannel();
				using (calculator as IDisposable) {
					Console.WriteLine("x + y = {2} where x = {0}  ans y = {1}", 1, 2, calculator.Add(1, 2));
				}
			}

			Console.Read();
		}
	}
}
