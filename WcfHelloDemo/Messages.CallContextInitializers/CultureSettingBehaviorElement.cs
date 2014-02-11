using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Configuration;

namespace Messages.CallContextInitializers
{
	public class CultureSettingBehaviorElement : BehaviorExtensionElement
	{

		public override Type BehaviorType
		{
			get
			{
				return typeof(CultureSettingBehavior);
			}
		}

		protected override object CreateBehavior()
		{
			return new CultureSettingBehavior();
		}
	}
}
