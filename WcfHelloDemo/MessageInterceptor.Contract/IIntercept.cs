using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MessageInterceptor.Contract
{
	[ServiceContract]
	public interface IIntercept
	{
		[OperationContract(Action = "*", ReplyAction = "*")]
		Message Intercept(Message request);
	}
}
