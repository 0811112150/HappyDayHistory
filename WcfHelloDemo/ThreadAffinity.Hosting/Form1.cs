using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using ThreadAffinity.Contract;
using System.Threading;

namespace ThreadAffinity.Hosting
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
			this.listBox1.Items.Add(Thread.CurrentThread.ManagedThreadId);

			_serviceHost = new ServiceHost(typeof(ThreadAffinity.Service.Service));
			_serviceHost.Opened += delegate { this.Text = "服务已启动..."; };


			ThreadAffinity.Service.Service.ListBox = this.listBox1;

			ThreadAffinity.Service.Service.SynchronizationContext = SynchronizationContext.Current;

			_serviceHost.Open();

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this._serviceHost.Close();
		}
	}
}
