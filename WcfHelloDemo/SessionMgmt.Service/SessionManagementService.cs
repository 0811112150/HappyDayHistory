using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SessionMgmt.Contract;
using System.ServiceModel;

namespace SessionMgmt.Service
{
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Multiple)]
	public class SessionManagementService : ISessionManagement
	{
		public Guid StartSession(SessionClientInfo clientInfo, out TimeSpan timeout)
		{
			timeout = SessionManager.TimeOut;
			return SessionManager.StartSession(clientInfo);
		}

		public void EndSession(Guid sessionID)
		{
			SessionManager.EndSession(sessionID);
		}

		public IList<SessionInfo> GetActiveSessions()
		{
			return new List<SessionInfo>(SessionManager.CurrentSessionList.Values.ToArray<SessionInfo>());
		}

		public void KillSessions(IList<Guid> sessionIDs)
		{
			SessionManager.KillSessions(sessionIDs);
		}
	}
}
