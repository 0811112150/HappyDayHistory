using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyDay.AutoClickKeyBoard
{
	public class WindowAPIImport
	{
		public struct POINT
		{
			public int X;
			public int Y;
		}

		/// <summary>
		/// 鼠标控制参数
		/// </summary>
		public const int MOUSEEVENTF_LEFTDOWN = 0x2;
		public const int MOUSEEVENTF_LEFTUP = 0x4;
		public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
		public const int MOUSEEVENTF_MIDDLEUP = 0x40;
		public const int MOUSEEVENTF_MOVE = 0x1;
		public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
		public const int MOUSEEVENTF_RIGHTDOWN = 0x8;
		public const int MOUSEEVENTF_RIGHTUP = 0x10;

		public enum KeyModifiers
		{
			None = 0,
			Alt = 1,
			Ctrl = 2,
			Shift = 4,
			WindowsKey = 8
		}

		[DllImport("User32")]
		public static extern int GetCursorPos(ref POINT pt);

		[DllImport("User32")]
		public extern static void SetCursorPos(int x, int y);

		[DllImport("User32")]
		public static extern bool RegisterHotKey(
			 IntPtr hWnd,                 //要定义热键的窗口的句柄
			 int id,                      //定义热键ID（不能与其它ID重复）         
			 KeyModifiers fsModifiers,    //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
			 Keys vk                      //定义热键的内容
		);

		[DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		[DllImport("user32")]
		public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
	}
}
