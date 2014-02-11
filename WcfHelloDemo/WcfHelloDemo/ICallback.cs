using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WcfHelloDemo.Contract
{
	public interface ICallback
	{
		//[OperationContract(IsOneWay = true)]
		[OperationContract]
		void DisplayResult(string result);
	}
}
