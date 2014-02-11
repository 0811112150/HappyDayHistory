using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HappyDay.Win32Api
{
	public class WinApi
	{


		[StructLayout(LayoutKind.Sequential)]
		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		#region 获取窗口句柄
		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		/// <summary>
		/// 获取一个前台窗口的句柄（窗口与用户当前的工作）
		/// </summary>
		/// <returns></returns>
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(String sClassName, String sAppName);

		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		public static extern IntPtr GetActiveWindow();

		[DllImport("user32.dll")]
		static extern IntPtr GetTopWindow(IntPtr hWnd);
		#endregion

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);
		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateDC(
		 string lpszDriver,        // driver name驱动名  
		 string lpszDevice,        // device name设备名  
		 string lpszOutput,        // not used; should be NULL  
		 IntPtr lpInitData  // optional printer data  
		 );

		/// <summary>
		/// 该函数对指定的源设备环境区域中的像素进行位块（bit_block）转换，以传送到目标设备环境。
		/// </summary>
		/// <param name="hdcDest"></param>
		/// <param name="nXDest"></param>
		/// <param name="nYDest"></param>
		/// <param name="nWidth"></param>
		/// <param name="nHeight"></param>
		/// <param name="hdcSrc"></param>
		/// <param name="nXSrc"></param>
		/// <param name="nYSrc"></param>
		/// <param name="dwRop"></param>
		/// <returns></returns>
		[DllImport("gdi32.dll")]
		public static extern int BitBlt(
		 IntPtr hdcDest, // handle to destination DC目标设备的句柄  
		 int nXDest,  // x-coord of destination upper-left corner目标对象的左上角的X坐标  
		 int nYDest,  // y-coord of destination upper-left corner目标对象的左上角的Y坐标  
		 int nWidth,  // width of destination rectangle目标对象的矩形宽度  
		 int nHeight, // height of destination rectangle目标对象的矩形长度  
		 IntPtr hdcSrc,  // handle to source DC源设备的句柄  
		 int nXSrc,   // x-coordinate of source upper-left corner源对象的左上角的X坐标  
		 int nYSrc,   // y-coordinate of source upper-left corner源对象的左上角的Y坐标  
		 UInt32 dwRop  // raster operation code光栅的操作值  
		 );

		/// <summary>
		/// 函数功能该函数创建一个与指定设备兼容的内存设备上下文环境（DC）
		/// </summary>
		/// <param name="hdc"></param>
		/// <returns></returns>
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(
		 IntPtr hdc // handle to DC  
		 );

		/// <summary>
		/// 该函数创建与指定的设备环境相关的设备兼容的位图
		/// </summary>
		/// <param name="hdc"></param>
		/// <param name="nWidth"></param>
		/// <param name="nHeight"></param>
		/// <returns></returns>
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(
		 IntPtr hdc,        // handle to DC  
		 int nWidth,     // width of bitmap, in pixels  
		 int nHeight     // height of bitmap, in pixels  
		 );

		/// <summary>
		/// 该函数选择一对象到指定的设备上下文环境中，该新对象替换先前的相同类型的对象。
		/// </summary>
		/// <param name="hdc"></param>
		/// <param name="hgdiobj"></param>
		/// <returns></returns>
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(
		 IntPtr hdc,          // handle to DC  
		 IntPtr hgdiobj   // handle to object  
		 );

		[DllImport("gdi32.dll")]
		public static extern int DeleteDC(
		 IntPtr hdc          // handle to DC  
		 );

		[DllImport("user32.dll")]
		public static extern bool PrintWindow(
		 IntPtr hwnd,               // Window to copy,Handle to the window that will be copied.   
		 IntPtr hdcBlt,             // HDC to print into,Handle to the device context.   
		 UInt32 nFlags              // Optional flags,Specifies the drawing options. It can be one of the following values.   
		 );

		public const int SRCCOPY = 0x00CC0020;

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);
	}
}
