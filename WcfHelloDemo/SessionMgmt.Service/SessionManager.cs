using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SessionMgmt.Contract;
using System.Configuration;
using System.ServiceModel;
using System.Threading;
using System.Runtime.CompilerServices;

namespace SessionMgmt.Service
{
	public static class SessionManager
	{
		//用于多线程的同步
		private static object _syncHelper = new object();

		internal static TimeSpan TimeOut { get; set; }

		public static IDictionary<Guid, SessionInfo> CurrentSessionList { get; set; }

		public static IDictionary<Guid, ISessionCallback> CurrentCallbackList { get; set; }

		//初始化静态变量
		static SessionManager()
		{
			string sessionTimeout = ConfigurationManager.AppSettings["SessionTimeout"];
			if (string.IsNullOrEmpty(sessionTimeout)) {
				throw new ConfigurationErrorsException("The session timeout application setting is missing");
			}
			double timeoutMinute;
			if (!double.TryParse(sessionTimeout, out timeoutMinute)) {
				throw new ConfigurationErrorsException("The session timeout application setting should be of doubdle type.");
			}

			TimeOut = new TimeSpan(0, 0, (int)(timeoutMinute * 60));
			CurrentSessionList = new Dictionary<Guid, SessionInfo>();
			CurrentCallbackList = new Dictionary<Guid, ISessionCallback>();
		}

		public static Guid StartSession(SessionClientInfo clientInfo)
		{
			var sessionID = Guid.NewGuid();
			ISessionCallback callBack = OperationContext.Current.GetCallbackChannel<ISessionCallback>();
			SessionInfo sessionInfo = new SessionInfo();
			sessionInfo.ClientInfo = clientInfo;
			sessionInfo.LastActivityTime = DateTime.Now;
			sessionInfo.SessionID = sessionID;
			sessionInfo.StartTime = DateTime.Now;

			lock (_syncHelper) {
				CurrentCallbackList.Add(sessionID, callBack);
				CurrentSessionList.Add(sessionID, sessionInfo);
			}

			return sessionID;
		}

		public static void EndSession(Guid sessionID)
		{
			if (!CurrentSessionList.Keys.Contains(sessionID)) {
				return;
			}

			lock (_syncHelper) {
				CurrentCallbackList.Remove(sessionID);
				CurrentSessionList.Remove(sessionID);
			}
		}

		public static void KillSessions(IList<Guid> sessionIDs)
		{
			lock (_syncHelper) {
				foreach (var item in sessionIDs) {
					if (!CurrentSessionList.Keys.Contains(item)) {
						continue;
					}
					SessionInfo sessionInfo = CurrentSessionList[item];
					CurrentSessionList.Remove(item);
					CurrentCallbackList[item].OnSessionKilled(sessionInfo);
					CurrentCallbackList.Remove(item);
				}
			}
		}

		public delegate void RenewSession(KeyValuePair<Guid, SessionInfo> sessionInfo);

		public static void Method(KeyValuePair<Guid, SessionInfo> sessionInfo)
		{

			if (DateTime.Now - sessionInfo.Value.LastActivityTime < TimeOut) {
				return;
			}

			try {
				TimeSpan renewDuration = CurrentCallbackList[sessionInfo.Key].Renew();
				if (renewDuration.TotalSeconds > 0) {
					sessionInfo.Value.LastActivityTime += renewDuration;
				} else {
					sessionInfo.Value.IsTimeout = true;
					CurrentCallbackList[sessionInfo.Key].OnSessionTimeOut(sessionInfo.Value);
				}
			} catch (CommunicationObjectAbortedException) {
				sessionInfo.Value.IsTimeout = true;
				return;
			}
		}


		[MethodImpl(MethodImplOptions.Synchronized)]
		public static void RenewSessions()
		{
			IList<WaitHandle> waitHandleList = new List<WaitHandle>();

			foreach (var session in CurrentSessionList) {
				RenewSession renewSession = Method;
				IAsyncResult result = renewSession.BeginInvoke(session, null, null);
				waitHandleList.Add(result.AsyncWaitHandle);
			}

			if (waitHandleList.Count == 0) {
				return;
			}

			WaitHandle.WaitAll(waitHandleList.ToArray<WaitHandle>());
		}
	}
}
