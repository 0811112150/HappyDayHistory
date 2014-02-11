using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ThreadAffinity.Contract
{
	[ServiceContract]
	public interface IContract
	{
		[OperationContract]
		void DoSomething();
	}
}
