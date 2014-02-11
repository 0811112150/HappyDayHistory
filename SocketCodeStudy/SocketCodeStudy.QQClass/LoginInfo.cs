using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketCodeStudy.QQClass
{
	public class LoginInfo
	{
		public LoginInfo() { }
		public LoginInfo(bool isAllowLogin, int serverListenPort)
		{
			IsAllowLogin = isAllowLogin;
			ServerListenPort = serverListenPort;
		}

		public bool IsAllowLogin { get; set; }
		public int ServerListenPort { get; set; }
	}
}
