using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObjectPoolInstance.Extension
{
	public static class PooledInstanceLocator
	{
		internal static WeakReferenceDictionary ServiceInstancePool { get; set; }

		public static IPooledObject GetInstanceFromPool(Type serviceType)
		{
			if (!serviceType.GetInterfaces().Contains(typeof(IPooledObject))) {
				throw new InvalidCastException("InstanceType must implement Artech.WCFExtensions.IPooledInstance");
			}

			if (!ServiceInstancePool.Keys.Contains(serviceType)) {
				ServiceInstancePool.Add(serviceType, new WeakReferenceCollection());
			}
			var instanceReferenceList = ServiceInstancePool[serviceType];

			lock (serviceType) {
				IPooledObject serviceInstance;
				foreach (var item in instanceReferenceList) {
					serviceInstance = item.Target as IPooledObject;
					if (serviceInstance != null && !serviceInstance.IsBusy) {
						serviceInstance.IsBusy = true;
						return serviceInstance;
					}
				}

				serviceInstance = Activator.CreateInstance(serviceType) as IPooledObject;
				serviceInstance.IsBusy = true;
				instanceReferenceList.Add(new WeakReference(serviceInstance));
				return serviceInstance;
			}
		}

		public static void Scavenge()
		{
			foreach (Type type in ServiceInstancePool.Keys) {
				lock (type) {
					WeakReferenceCollection instanceReferenceList = ServiceInstancePool[type];
					for (int i = 0; i < instanceReferenceList.Count; i++) {
						if (instanceReferenceList[i].Target == null) {
							instanceReferenceList.RemoveAt(i);
						}
					}
				}
			}
		}

		public static void ReleaseInstanceToPool(IPooledObject instance)
		{
			instance.IsBusy = false;
		}
	}
}
