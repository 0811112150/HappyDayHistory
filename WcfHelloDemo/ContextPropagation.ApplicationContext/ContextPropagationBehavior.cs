using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;

namespace ContextPropagation
{
	public class ContextPropagationBehavior : IEndpointBehavior
	{
		public bool IsBidirectional { get; set; }

		public ContextPropagationBehavior() : this(false) { }

		public ContextPropagationBehavior(bool isBidirectional)
		{
			this.IsBidirectional = isBidirectional;
		}

		public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
		{
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime)
		{
			clientRuntime.MessageInspectors.Add(new ContextAttachingMessageInspector(this.IsBidirectional));
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher)
		{
			foreach (var item in endpointDispatcher.DispatchRuntime.Operations) {
				item.CallContextInitializers.Add(new ContextReceivalCallContextInitializer());
			}
		}

		public void Validate(ServiceEndpoint endpoint)
		{
		}
	}
}
