using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Windows.Controls;
using Winista.Text.HtmlParser;
using Winista.Text;
using Winista.Text.HtmlParser.Lex;
using Winista.Text.HtmlParser.Filters;
using System.Xml.Linq;
using System.Net;

namespace HappyDay.WebPicBrowser.View
{
	public class WebPictureFactory
	{
		public static void GetUrlContentImageList(object state)
		{
			//HttpWebRequest
			//httpclient
			//WebClient
			var url = "http://image.baidu.com/";
			var client = new HttpClient();
			var uri = new Uri(url);
			var task = client.GetStringAsync(uri);
			var result = task.Result;

			var s = new WebBrowser();
			s.Source = uri;

			//var webclient = new WebClient();
			//webclient.DownloadFile()

			//var request = HttpWebRequest.Create("");
			//request.BeginGetResponse()

			//var xmlDoc = XDocument.Parse(result);
			//var elemetns = xmlDoc.Elements();
			//var stringList = new List<string>();
			//foreach (var element in elemetns) {
			//	var list = GetImageElement(element);
			//	stringList.AddRange(list);
			//}
		}

		private static List<string> GetImageElement(XElement element)
		{
			if (element.Name == "") {
			}
			return new List<string>();
		}
	}
}
