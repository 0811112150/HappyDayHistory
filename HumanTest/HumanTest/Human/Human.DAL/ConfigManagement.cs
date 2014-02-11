using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;


namespace Human.DAL
{
	public static class ConfigManagement
	{
		internal static string LoginName
		{
			get { return ConfigurationManager.AppSettings["LoginName"]; }
			set { ConfigurationManager.AppSettings["LoginName"] = value; }
		}

		internal static string Password
		{
			get { return ConfigurationManager.AppSettings["Password"]; }
			set { ConfigurationManager.AppSettings["Password"] = value; }
		}

		internal static string AccessConStr = string.Format(ConfigurationManager.AppSettings["ConnectionStr"], Application.StartupPath);
	}
}
