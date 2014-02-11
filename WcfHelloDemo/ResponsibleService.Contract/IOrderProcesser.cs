using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ResponsibleService.Contract
{
	[ServiceContract]
	public interface IOrderProcesser
	{
		[OperationContract(IsOneWay = true)]
		[ServiceKnownType(typeof(Order))]
		void Submit(Order order);
	}
}
