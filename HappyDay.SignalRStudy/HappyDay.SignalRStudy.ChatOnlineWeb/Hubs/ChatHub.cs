//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using Microsoft.AspNet.SignalR;
using System;
using System.Reflection;
using System.Collections.Generic;

namespace HappyDay.SignalRStudy.ChatOnlineWeb
{
	public class ChatHub : Hub
	{
		public void Hello()
		{
			Clients.All.hello();
		}

		public void Send(string name, string message)
		{
			Clients.All.addNewMessageToPage(name, message);

			//var types = Assembly.GetExecutingAssembly().DefinedTypes;
			//Type resultType = null;
			//foreach (var typeInfo in types) {
			//	if (typeInfo.Name.Equals("Test")) {
			//		resultType = typeInfo.UnderlyingSystemType;
			//		break;
			//	}
			//}

			//Activator.CreateInstance(typeof(IList<>).MakeGenericType(resultType));
		}
	}

	public class Test
	{

	}
}