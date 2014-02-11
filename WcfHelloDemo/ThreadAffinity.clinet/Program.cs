using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThreadAffinity.Contract;
using System.ServiceModel;
using System.Threading;

namespace ThreadAffinity.clinet
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var channelFactory = new ChannelFactory<IContract>("ThreadAffinity")) {
				var channelList = new List<IContract>();
				for (int i = 0; i < 10; i++) {
					channelList.Add(channelFactory.CreateChannel());
				}

				foreach (var item in channelList) {
					//存在参数问题
					//ThreadPool.QueueUserWorkItem(delegate {
					//    item.DoSomething();
					//    Console.WriteLine(DateTime.Now);
					//});

					ThreadPool.QueueUserWorkItem((s) => {
						(s as IContract).DoSomething();
						Console.WriteLine(DateTime.Now);
					}, item);
				}

				//Array.ForEach(channelList.ToArray<IContract>(), delegate(IContract channel) {
				//    ThreadPool.QueueUserWorkItem(delegate {
				//        channel.DoSomething();
				//        Console.WriteLine(DateTime.Now);
				//    });
				//});

				Console.Read();
			}
		}
	}
}
