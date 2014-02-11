using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using SessionMgmt.Service;
using System.Threading;

namespace SessionMgmt.Hosting
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var host = new ServiceHost(typeof(SessionManagementService))) {
				host.Opened += delegate {
					Console.WriteLine("The session management service has been started ");
				};
				host.Open();

				Timer timer = new Timer(delegate { SessionManager.RenewSessions(); }, null, 0, 5000);

				Console.Read();
			}
		}
	}
}
