using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Data;

namespace WebServicesStudy.Service
{
	/// <summary>
	/// Service1 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
	// [System.Web.Script.Services.ScriptService]
	public class Service1 : System.Web.Services.WebService
	{

		[WebMethod]
		public string HelloWorld()
		{
			this.Context.Response.AddHeader("Access-Control-Allow-Origin", "*");
			return "Hello World";
		}

		[WebMethod(Description = "求和")]
		public double Sum(double firstNum, double secondNum)
		{
			this.Context.Response.AddHeader("Access-Control-Allow-Origin", "*");
			return firstNum + secondNum;
		}

		[WebMethod(Description = "求差")]
		public double Subtract(double firstNum, double secondNum)
		{
			return firstNum - secondNum;
		}
	}
}