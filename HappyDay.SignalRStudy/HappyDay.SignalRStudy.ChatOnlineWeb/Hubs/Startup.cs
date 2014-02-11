using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HappyDay.SignalRStudy.ChatOnlineWeb.Startup))]
namespace HappyDay.SignalRStudy.ChatOnlineWeb
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.MapSignalR();
		}
	}
}