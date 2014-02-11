using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyDay.Win32Api;
using System.Reflection;
using System.Diagnostics;
using System.IO;

namespace HappyDay.GlobalHook
{
	public partial class Form1 : Form
	{
		private static int hHook = 0;
		private int count = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (hHook == 0) {
				//WH_KEYBOARD_LL 需要和全局的钩子对应 WH_KEYBOARD,和局部钩子对应
				//hHook = User32.SetWindowsHookEx(User32.HookType.WH_KEYBOARD, User32.MouseHookProced, id, 0);
				//hHook = User32.SetWindowsHookEx(User32.HookType.WH_KEYBOARD, User32.MouseHookProced, Kernel32.GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
				//hHook = User32.SetWindowsHookEx(User32.HookType.WH_KEYBOARD, MouseHookProced, (IntPtr)0, 0);
				hHook = User32.SetWindowsHookEx(User32.HookType.WH_KEYBOARD_LL, User32.MouseHookProced, (IntPtr)0, 0);
				//hHook = User32.SetWindowsHookEx(User32.HookType.WH_KEYBOARD, User32.MouseHookProced, (IntPtr)0, AppDomain.GetCurrentThreadId());

				//hHook = User32.SetWindowsHookEx(User32.HookType.WH_CALLWNDPROCRET, MouseHookProced, (IntPtr)0, AppDomain.GetCurrentThreadId());
				if (hHook == 0) {
					MessageBox.Show("SetWindowsHookEx Failed");
					return;
				}

			} else {
				User32.UnhookWindowsHookEx(hHook);
				hHook = 0;
			}
		}



		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (hHook != 0) {
				User32.UnhookWindowsHookEx(hHook);
			}
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			button1_Click(null, null);
			this.Visible = false;
		}

		//public static int MouseHookProced(int nCode, IntPtr wParam, IntPtr lParam)
		//{
		//	return User32.CallNextHookEx(0, nCode, wParam, lParam);
		//}
	}
}
