using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ContextPropagation.Contract
{
	[ServiceContract]
	public interface IContract
	{
		[OperationContract]
		void DoSomething();
	}
}
