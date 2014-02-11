using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HappyDay.AutoClickKeyBoard
{
	public partial class Form1 : Form
	{
		private System.Threading.Timer timer;
		private AutoClickKeyBoard.WindowAPIImport.POINT pt = new AutoClickKeyBoard.WindowAPIImport.POINT();

		public Form1()
		{
			InitializeComponent();
		}

		private void btnGetMousePt_Click(object sender, EventArgs e)
		{
			pt = new AutoClickKeyBoard.WindowAPIImport.POINT();
			WindowAPIImport.GetCursorPos(ref pt);
			txtMouseX.Text = pt.X.ToString();
			txtMouseY.Text = pt.Y.ToString();
		}

		private void btnSetMousePt_Click(object sender, EventArgs e)
		{
			try {
				var x = int.Parse(txtMouseX.Text);
				var y = int.Parse(txtMouseY.Text);
				WindowAPIImport.SetCursorPos(x, y);
			} catch (System.Exception ex) {
				MessageBox.Show("出错了");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try {
				var result = WindowAPIImport.RegisterHotKey(Handle, 100, WindowAPIImport.KeyModifiers.Ctrl, Keys.S);
			} catch (System.Exception ex) {

			}
		}

		private void Form1_Leave(object sender, EventArgs e)
		{
			timer.Dispose();
			WindowAPIImport.UnregisterHotKey(Handle, 100);
		}

		protected override void WndProc(ref Message m)
		{
			const int WM_HOTKEY = 0x0312;
			//按快捷键
			if (m.Msg == WM_HOTKEY) {
				ProcessHotkey(m);
			}

			base.WndProc(ref m);
		}

		private void ProcessHotkey(Message m)
		{
			IntPtr id = m.WParam; //IntPtr用于表示指针或句柄的平台特定类型

			string sid = id.ToString();
			switch (sid) {
				case "100":
					Application.Exit();
					break;
			}
		}

		private void btnStartInput_Click(object sender, EventArgs e)
		{
			timer = new System.Threading.Timer(DoSomething, null, 2000, 500);
		}

		private void DoSomething(object state)
		{
			SendKeys.SendWait(" ");//还得靠模拟键盘的SendKeys.SendWait方法才行
			WindowAPIImport.mouse_event(WindowAPIImport.MOUSEEVENTF_ABSOLUTE | WindowAPIImport.MOUSEEVENTF_LEFTDOWN, pt.X, pt.Y, 0, 0);
			WindowAPIImport.mouse_event(WindowAPIImport.MOUSEEVENTF_ABSOLUTE | WindowAPIImport.MOUSEEVENTF_LEFTUP, pt.X, pt.Y, 0, 0);
		}
	}
}
