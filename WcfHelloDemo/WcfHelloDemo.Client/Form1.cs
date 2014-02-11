using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using WcfHelloDemo.Contract;
using System.Threading;

namespace WcfHelloDemo.Client
{
	public partial class Form1 : Form
	{


		public Form1()
		{
			InitializeComponent();
			InitChannel();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var callBack = new Callback();
			Callback.ResultPanel = this.label1;
			Callback.SynchronizationContext = SynchronizationContext.Current;
			using (var host = new DuplexChannelFactory<IHello>(callBack, "HelloService")) {
				IHello channel = host.CreateChannel();
				channel.SayHello("fdsaf");
			}
		}

		void InitChannel()
		{

		}
	}
}
