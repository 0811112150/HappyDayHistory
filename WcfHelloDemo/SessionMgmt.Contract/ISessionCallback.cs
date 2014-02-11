using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace SessionMgmt.Contract
{
	public interface ISessionCallback
	{
		[OperationContract]
		TimeSpan Renew();

		[OperationContract(IsOneWay=true)]
		void OnSessionKilled(SessionInfo sessionInfo);

		[OperationContract(IsOneWay = true)]
		void OnSessionTimeOut(SessionInfo sessionInfo);
	}
}
