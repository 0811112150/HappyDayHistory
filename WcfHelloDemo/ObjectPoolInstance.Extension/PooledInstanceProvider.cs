using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace ObjectPoolInstance.Extension
{
	public class PooledInstanceProvider : IInstanceProvider
	{

		public object GetInstance(InstanceContext instanceContext, Message message)
		{
			return PooledInstanceLocator.GetInstanceFromPool(instanceContext.Host.Description.ServiceType);
		}

		public object GetInstance(InstanceContext instanceContext)
		{
			return this.GetInstance(instanceContext, null);
		}

		public void ReleaseInstance(InstanceContext instanceContext, object instance)
		{
			PooledInstanceLocator.ReleaseInstanceToPool(instance as IPooledObject);
		}
	}
}
