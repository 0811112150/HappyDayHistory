using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;
using System.Configuration;

namespace ContextPropagation.Extent
{
	public class ContextPropagationBehaviorElement : BehaviorExtensionElement
	{
		[ConfigurationProperty("isBidirectional", DefaultValue = false)]
		public bool IsBidirectional
		{
			get { return (bool)this["isBidirectional"]; }
			set { this["isBidirectional"] = value; }
		}

		public override Type BehaviorType
		{
			get { return typeof(ContextPropagationBehavior); }
		}

		protected override object CreateBehavior()
		{
			Console.WriteLine("ContextPropagationBehaviorElement"+IsBidirectional);
			return new ContextPropagationBehavior(this.IsBidirectional);
		}
	}
}
