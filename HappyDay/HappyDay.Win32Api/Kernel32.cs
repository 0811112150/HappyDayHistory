using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HappyDay.Win32Api
{
	public class Kernel32
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string name);
	}
}
