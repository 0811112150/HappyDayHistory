using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SocketCodeStudy.QQClass
{
	public class UserInfo
	{
		private string _userName;

		public UserInfo() { }

		public UserInfo(string userName, IPEndPoint endPoint, bool isLogin)
		{
			this.IsLoginOn = isLogin;
			this.UserName = userName;
			this.RemoteIPEndpoint = endPoint;
		}

		public string UserName { get { return _userName; } set { _userName = value; } }
		public IPEndPoint RemoteIPEndpoint { get; set; }
		public bool IsLoginOn { get; set; }
	}
}
