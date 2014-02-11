using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace HappyDay.Win32Api
{
	public class User32
	{
		#region 全局钩子
		/*钩子分为全局钩子和局部钩子。 
如果你只HOOK本进程得消息，可以把消息回调函数和调用钩子的函数写在一起，也就是只需要写个EXE就可以了。 
如果要HOOK全局消息，需要全局钩子，这样，需要把你的HOOK代码注入到系统每个进程里面去。而实现这个最好的方法，就是用DLL来实现。系统会自动把该DLL注入到所有的进程空间中。所以，不一定是必须要写DLL来HOOK，看你用的范围来决定
		 * 有某些全局钩子可以不依赖于任何DLL而正常工作的。这些钩子包括，WH_JOURNALPLAYBACK，WH_JOURNALRECORD，WH_KEYBOARD_LL，WH_MOUSE_LL。为什么这些钩子可以不依赖于DLL而正常工作呢？我们可以从MSDN中得到答案，MSDN中对于这四种钩子都这样的描述“This hook is called in the context of the thread that installed it.”，翻译成中文意思是钩子函数的调用是在安装钩子的线程上下文中进行的，说得更明白些，意思就是这些钩子是在哪个线程当中安装的，其钩子函数就在哪个线程中执行。所以使用这四种钩子是达不到代码注入的效果的，当然也就可以不依赖于任何DLL了。MSDN中只对个别钩子指出了必须还是没有必要使用DLL。*/

		public delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

		//钩子类型 idHook 选项:
		public struct HookType
		{
			public const int WH_MSGFILTER = -1; //{线程级; 截获用户与控件交互的消息}
			public const int WH_JOURNALRECORD = 0;  //{系统级; 记录所有消息队列从消息队列送出的输入消息, 在消息从队列中清除时发生; 可用于宏记public const 录}
			public const int WH_JOURNALPLAYBACK = 1;  //{系统级; 回放由 WH_JOURNALRECORD 记录的消息, 也就是将这些消息重新送入消息队列}
			public const int WH_KEYBOARD = 2;  //{系统级或线程级; 截获键盘消息}
			public const int WH_GETMESSAGE = 3;  //{系统级或线程级; 截获从消息队列送出的消息}
			public const int WH_CALLWNDPROC = 4;  //{系统级或线程级; 截获发送到目标窗口的消息, 在 SendMessage 调用时发生}
			public const int WH_CBT = 5;  //{系统级或线程级; 截获系统基本消息, 譬如: 窗口的创建、激活、关闭、最大最小化、移动等等}
			public const int WH_SYSMSGFILTER = 6;  //{系统级; 截获系统范围内用户与控件交互的消息}
			public const int WH_MOUSE = 7;  //{系统级或线程级; 截获鼠标消息}
			public const int WH_HARDWARE = 8;  //{系统级或线程级; 截获非标准硬件(非鼠标、键盘)的消息}
			public const int WH_DEBUG = 9;  //{系统级或线程级; 在其他钩子调用前调用, 用于调试钩子}
			public const int WH_SHELL = 10; //{系统级或线程级; 截获发向外壳应用程序的消息}
			public const int WH_FOREGROUNDIDLE = 11; //{系统级或线程级; 在程序前台线程空闲时调用}
			public const int WH_CALLWNDPROCRET = 12; //{系统级或线程级; 截获目标窗口处理完毕的消息, 在 SendMessage 调用后发生}
			public const int WH_MOUSE_LL = 14;
			public const int WH_KEYBOARD_LL = 13;
		}

		/// <summary>
		/// 返回钩子的句柄; 0 表示失败
		/// </summary>
		/// <param name="idHook">钩子类型</param>
		/// <param name="lpfn">函数指针</param>
		/// <param name="hMod">包含钩子函数的模块(EXE、DLL)句柄; 一般是 HInstance; 如果是当前线程这里可以是 0</param>
		/// <param name="dwThreadId">关联的线程; 可用 GetCurrentThreadId 获取当前线程; 0 表示是系统级钩子</param>
		/// <returns></returns>
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);

		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern int UnhookWindowsHookEx(int idHook);

		//This is the Import for the CallNextHookEx function.
		//Use this function to pass the hook information to the next hook procedure in chain.
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

		public static IntPtr GetCurrentAssemblyID()
		{
			var hwd = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules().FirstOrDefault());
			return hwd;
		}

		public struct KBDLLHOOKSTRUCT
		{
			public int vkCode;
			public int scanCode;
			public int flags;
			public int time;
			public int dwExtraInfo;
		}

		public static int MouseHookProced(int nCode, IntPtr wParam, IntPtr lParam)
		{
			#region 局部钩子
			//if (nCode <= 0) {
			//	return User32.CallNextHookEx(0, nCode, wParam, lParam);
			//}
			//var bitStr = Convert.ToString((int)lParam, 2);
			//if (bitStr.Length < 32) {
			//	bitStr = new string('0', 32 - bitStr.Length) + bitStr;
			//}
			////0位Transition-State Flag,代表是按下还是弹起
			//var isKeyUp = int.Parse(bitStr.Substring(0, 1));
			//if (isKeyUp != 0) {
			//	return User32.CallNextHookEx(0, nCode, wParam, lParam);
			//}
			//var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			//var file = Path.Combine(desktop, "KeyBoardRecord.txt");
			//if (!File.Exists(file)) {
			//	var stream = File.Create(file);
			//	stream.Dispose();
			//}
			//using (var stream = new StreamWriter(file, true)) {
			//	stream.WriteLine(string.Format("{0},{1}", wParam, bitStr));
			//}

			//return User32.CallNextHookEx(0, nCode, wParam, lParam);
			#endregion

			#region 全局钩子
			//键盘按下
			if ((int)wParam == (0x100)) {
				var value = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
				var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				var file = Path.Combine(desktop, "KeyBoardRecord.txt");
				if (!File.Exists(file)) {
					var stream = File.Create(file);
					stream.Dispose();
				}
				using (var stream = new StreamWriter(file, true)) {
					stream.WriteLine((Keys)value.vkCode);
				}
			}
			return User32.CallNextHookEx(0, nCode, wParam, lParam);
			#endregion
		}
		#endregion
	}
}
