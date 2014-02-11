using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;

namespace Messages.CallContextInitializers
{
	public class CultureSettingBehavior : IEndpointBehavior
	{
		public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
			foreach (var item in endpointDispatcher.DispatchRuntime.Operations)
			{
				item.CallContextInitializers.Add(new CultureSettingCallContextInitializer());
			}
		}

		public void Validate(ServiceEndpoint endpoint)
		{
		}
	}
}
