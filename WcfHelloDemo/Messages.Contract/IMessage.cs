using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Messages.CallContextInitializers;

namespace Messages.Contract
{
	[ServiceContract]
	public interface IMessage
	{
		[OperationContract]
		//[CultureSettingBehavior]
		string GetMessage();
	}
}
