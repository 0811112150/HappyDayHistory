using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.ViewModel
{
	public class WebUser
	{
		private string _userName;
		private string _password;

		public int UserID { get; set; }

		public string UserName { get { return _userName; } set { _userName = value; } }

		public string Password { get { return _password; } set { _password = value; } }
	}
}
