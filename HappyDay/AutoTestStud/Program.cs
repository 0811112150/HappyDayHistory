using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shrinerain.AutoTester.Core;
using Shrinerain.AutoTester.HTMLUtility;
using System.Threading;
using Shrinerain.AutoTester.MSAAUtility;

namespace HappyDay.AutoTestStudy
{
	class Program
	{
		static void Main(string[] args)
		{
			//TestSession ts = new HTMLTestSession();
			//ts.Browser.Start("http://www.baidu.com/");
			//Thread.Sleep(5000);
			//ts.Objects.TextBox("name=wd").Input("Test");
			//ts.Objects.Button("id=su").Click();
			//Console.ReadLine();

			TestSession ts = new MSAATestSession();
			ts.App.Find("QQ2013"); //根据窗口标题获取程序, 这里需要修改成你想读取的QQ窗体标题. 
			//var textbox = ts.Objects.TextBoxs().ToList().FirstOrDefault();
			foreach (var textbox in ts.Objects.TextBoxs()) {
				//获取当前窗体上第一个textbox, 也就是现实聊天记录的那个textbox
				string inputText = textbox.GetText(); //获取聊天记录.
				Console.WriteLine(inputText);
			}
			Console.ReadLine();
		}
	}
}
