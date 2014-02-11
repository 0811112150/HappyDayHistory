using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using MessageInterceptor.Contract;
using System.Threading;

namespace MessageInterceptor.Service
{
	public class Service1 : IContract
	{
		public double Add(double x, double y)
		{
			return x + y;
		}
	}
}
