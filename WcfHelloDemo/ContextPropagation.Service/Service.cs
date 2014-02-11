using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContextPropagation.Contract;
using ContextPropagation.Extent;

namespace ContextPropagation.Service
{
	public class Service : IContract
	{
		public void DoSomething()
		{
			Console.WriteLine("ApplicationContext.Current.Count = {0}", ApplicationContext.Current.Counter);
			ApplicationContext.Current.Counter++;
		}
	}
}
