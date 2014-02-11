using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Threading;

namespace ObjectPoolInstance.Extension
{
	public class PooledInstanceBehaviorAttribute : Attribute, IContractBehavior
	{
		public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
		}

		public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
		{
			dispatchRuntime.InstanceProvider = new PooledInstanceProvider();
		}

		public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint)
		{
			ThreadPool.QueueUserWorkItem((S) => { });
			ThreadPool.QueueUserWorkItem(delegate { });
		}
	}
}
