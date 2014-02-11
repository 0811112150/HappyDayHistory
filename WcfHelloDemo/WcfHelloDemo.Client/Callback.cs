using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfHelloDemo.Contract;
using System.Windows.Forms;
using System.ServiceModel;
using System.Threading;

namespace WcfHelloDemo.Client
{
	//[CallbackBehavior(UseSynchronizationContext = false)]
	public class Callback : ICallback
	{
		public static Label ResultPanel;
		public static SynchronizationContext SynchronizationContext;

		public delegate void DisplayResultDelegate(Label resultLabel, string content);

		public void DisplayResult(string result)
		{
			//SynchronizationContext.Post(delegate {
			//    ResultPanel.Text = result + "  回调";
			//}, null);

			//DisplayResultDelegate displayDelegate = new DisplayResultDelegate(delegate(Label resultLabel, string content) {
			//    resultLabel.Text = content;
			//});
			//ResultPanel.BeginInvoke(displayDelegate, ResultPanel, result);
			ResultPanel.Text = result + "  回调";
		}
	}
}
