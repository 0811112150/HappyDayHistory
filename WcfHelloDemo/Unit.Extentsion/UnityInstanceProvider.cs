using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.Utility;
using Microsoft.Practices.Unity;
using System.Configuration;
using System.Globalization;

namespace Unity.Extentsion
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

			this._containerName = containerName;
			_contractType = contractType;
		}



		public object GetInstance(InstanceContext instanceContext, Message message)
		{
			UnityConfigurationSection unitySection = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
			if (unitySection == null) {
				throw new ConfigurationErrorsException(string.Format(CultureInfo.CurrentCulture, Resources.MissUnityConfiguration));
			}

			IUnityContainer container = new UnityContainer();
			ContainerElement containerElement;
			if (string.IsNullOrEmpty(this._containerName)) {
				containerElement = unitySection.Containers.Default;
			} else {
				containerElement = unitySection.Containers[this._containerName];
			}
			containerElement.Configure(container);
			UnityTypeElement
		}

		public object GetInstance(InstanceContext instanceContext)
		{
			throw new NotImplementedException();
		}

		public void ReleaseInstance(InstanceContext instanceContext, object instance)
		{
			throw new NotImplementedException();
		}
	}
}
