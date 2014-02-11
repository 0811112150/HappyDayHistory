using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThreadAffinity.Contract;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;

namespace ThreadAffinity.Service
{
	[ServiceBehavior(UseSynchronizationContext = false, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class Service : IContract
	{
		public static SynchronizationContext SynchronizationContext;

		public static ListBox ListBox;

		public void DoSomething()
		{
			Thread.Sleep(5000);

			int threadID = Thread.CurrentThread.ManagedThreadId;
			DateTime endTime = DateTime.Now;
			SynchronizationContext.Post(delegate {
				ListBox.Items.Add(string.Format("Serice execution ended at {0}, Thread ID: {1}",
					endTime, threadID));
			}, null);
		}
	}
}
