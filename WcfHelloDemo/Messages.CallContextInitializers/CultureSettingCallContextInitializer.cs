using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Globalization;
using System.Threading;

namespace Messages.CallContextInitializers
{
	public class CultureSettingCallContextInitializer : ICallContextInitializer
	{
		private const string CultureInfoHeadLocalName = "__CultureInfo";
		private const string CultyreInfoHeaderNamespace = "urn:artech.com";

		public void AfterInvoke(object correlationState)
		{
			var culture=correlationState as CultureInfo[];

			Thread.CurrentThread.CurrentCulture = culture[0];
			Thread.CurrentThread.CurrentUICulture = culture[1];
		}

		public object BeforeInvoke(InstanceContext instanceContext, IClientChannel channel, Message message)
		{
			var cultureInfo = Thread.CurrentThread.CurrentCulture;
			var cultureUIInfo = Thread.CurrentThread.CurrentUICulture;

			if (message.Headers.FindHeader(CultureInfoHeadLocalName, CultyreInfoHeaderNamespace) > -1) {
				var culture = message.Headers.GetHeader<CultureInfo>(CultureInfoHeadLocalName, CultyreInfoHeaderNamespace);
				Thread.CurrentThread.CurrentCulture = culture;
				Thread.CurrentThread.CurrentUICulture = culture;
			}

			return new CultureInfo[] { cultureInfo, cultureUIInfo };
		}
	}
}
