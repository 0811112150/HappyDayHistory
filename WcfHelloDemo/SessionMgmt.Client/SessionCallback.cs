using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SessionMgmt.Contract;
using System.Windows.Forms;

namespace SessionMgmt.Client
{
	public class SessionCallback : ISessionCallback
	{
		public TimeSpan Renew()
		{
			return SessionUtility.Timeout - (DateTime.Now - SessionUtility.LastActivityTime);
		}

		public void OnSessionKilled(SessionInfo sessionInfo)
		{
			MessageBox.Show("The current session has been killed!", sessionInfo.SessionID.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
			Application.Exit();
		}

		public void OnSessionTimeOut(SessionInfo sessionInfo)
		{
			MessageBox.Show("The current session timeout!", sessionInfo.SessionID.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
			Application.Exit();
		}
	}
}
