using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.ViewModel
{
	public class WebUserInfo
	{
		private string _userName = string.Empty;
		private int _userID = 0;
		private string _oldPassword = string.Empty;
		private string _newPassword = string.Empty;
		private string _confirmPassword = string.Empty;

		public string UserName { get { return _userName; } set { _userName = value; } }
		public int UserID { get { return _userID; } set { _userID = value; } }
		public string OldPassword { get { return _oldPassword; } set { _oldPassword = value; } }
		public string NewPassword { get { return _newPassword; } set { _newPassword = value; } }
		public string ConfirmPassword { get { return _confirmPassword; } set { _confirmPassword = value; } }
	}
}
