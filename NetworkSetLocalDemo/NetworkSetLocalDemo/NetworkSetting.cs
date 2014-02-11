using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace NetworkSetLocalDemo
{
	public class NetworkSetting
	{
		public static void SetIPAddress()
		{
			ManagementClass wmi = new ManagementClass("Win32_NetworkAdapterConfiguration");
			var moc = wmi.GetInstances();
			foreach (var item in moc) {
				if (!(bool)item["IPEnabled"]) {
					continue;
				}
			}
		}
	}
}
