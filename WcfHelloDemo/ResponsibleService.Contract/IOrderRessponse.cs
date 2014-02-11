using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace ResponsibleService.Contract
{
	[ServiceContract]
	public interface IOrderRessponse
	{
		[OperationContract(IsOneWay = true)]
		[ServiceKnownType(typeof(FaultException))]
		void SubmitOrderResponse(Guid orderNo, FaultException exception);
	}
}
