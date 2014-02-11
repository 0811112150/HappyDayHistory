using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using MessageInterceptor.Service;
using System.Threading;

namespace MessageInterceptor.Interceptor
{
	public partial class Form1 : Form
	{
		private ServiceHost _serviceHost;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this._serviceHost = new ServiceHost(typeof(InterceptService));
			this._serviceHost.Opened += delegate {
				this.Text += ":Started";
			};
			InterceptService.SynchronizationContext = SynchronizationContext.Current;
			InterceptService.MessageDisplayPanel = this.textBox1;
			this._serviceHost.Open();
		}
	}
}
