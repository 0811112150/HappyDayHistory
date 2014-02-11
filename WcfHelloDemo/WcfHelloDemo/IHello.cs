using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WcfHelloDemo.Contract
{
	[ServiceContract(CallbackContract = typeof(ICallback))]
	public interface IHello
	{
		[OperationContract]
		//[OperationContract(IsOneWay = true)]
		void SayHello(string content);
	}
}
