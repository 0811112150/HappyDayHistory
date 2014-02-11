using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServicesStudy.Web.WeatherService;
using System.Net;
using System.IO;
using Shell32;

namespace WebServicesStudy.Web.Controllers
{
	public class WeatherController : Controller
	{
		//
		// GET: /Weather/

		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult GetWeather()
		{
			var weatherService = new WeatherWebServiceSoapClient().getWeatherbyCityName("北京");
			return Json(weatherService);
		}

		[HttpPost]
		public ActionResult GetMvcActionResult(String resourceUrl, String dataType)
		{
			//var uri = "http://zhangmenshiting.baidu.com/data2/music/31400032/3138763390000.mp3?xcode=43291b682c5378e18cc76ec8e46cb803";
			WebClient client = new WebClient();
			client.Encoding = System.Text.Encoding.UTF8;
			if (dataType == "string") {
				var result = client.DownloadString(resourceUrl);
				return Json(result);
			} else if (dataType == "file") {
				var path = string.Format("E://temp/{0}.mp3", Guid.NewGuid().ToString());
				client.DownloadFile(resourceUrl, path);

				var fileInfo = new FileInfo(path);
				ShellClass shClass = new ShellClass();
				Folder dir = shClass.NameSpace(Path.GetDirectoryName(path));
				FolderItem item = dir.ParseName(Path.GetFileName(path));
				var title = dir.GetDetailsOf(item, 10);

				fileInfo.MoveTo(path.Replace(Path.GetFileNameWithoutExtension(path), title));
				return Json("下载完成");
			}
			return Json("类型不匹配");
		}
	}
}
