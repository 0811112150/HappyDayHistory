using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace MessageInterceptor.Contract
{
	[ServiceContract]
	public interface IContract
	{
		[OperationContract]
		double Add(double x, double y);
	}
}
