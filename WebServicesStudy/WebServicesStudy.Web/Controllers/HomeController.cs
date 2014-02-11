using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServicesStudy.Service;

namespace WebServicesStudy.Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "欢迎使用 ASP.NET MVC!";

			return View();
		}

		public ActionResult About()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Sum(double firstNum, double secondNum)
		{
			var webService = new Service1();
			var result = webService.Sum(firstNum, secondNum);
			return Json(result);
		}
	}
}
