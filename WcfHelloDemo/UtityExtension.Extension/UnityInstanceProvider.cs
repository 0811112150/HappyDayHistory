using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using System.Globalization;
using Microsoft.Practices.Unity;

namespace UtityExtension.Extension
{
	public class UnityInstanceProvider : IInstanceProvider
	{
		private Type _contractType;
		private string _containerName;

		public UnityInstanceProvider(Type contractType, string containerName)
		{
			if (contractType == null) {
				throw new ArgumentNullException("contractType");
			}
			this._contractType = contractType;
			this._containerName = containerName;
		}

		public object GetInstance(InstanceContext instanceContext, Message message)
		{
			UnityConfigurationSection unitySection = ConfigurationManager.GetSection("") as UnityConfigurationSection;
			if (unitySection == null) {
				throw new ConfigurationErrorsException();
			}

			IUnityContainer container = new UnityContainer();
			ContainerElement containerElement;
			if (string.IsNullOrEmpty(this._containerName)) {
				containerElement = unitySection.Containers.Default;
			} else {
				containerElement = unitySection.Containers[this._containerName];
			}

			containerElement.Configure(container);

		}
	}
}
