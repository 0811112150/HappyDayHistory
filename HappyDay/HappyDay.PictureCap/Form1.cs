using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HappyDay.AutoClickKeyBoard;
using HappyDay.Win32Api;

namespace HappyDay.PictureCap
{
	public partial class Form1 : Form
	{
		private bool _pictureCapState = false;
		private Point _startPt;
		private Point _endPt;
		private Bitmap _screem;
		private Bitmap _colver;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			WindowAPIImport.RegisterHotKey(this.Handle, 1, WindowAPIImport.KeyModifiers.Ctrl, Keys.S);
			this.WindowState = FormWindowState.Minimized;
		}

		protected override void WndProc(ref Message m)
		{
			//0312 786 WM_HOTKEY
			if (m.Msg == 0x0312) {
				switch (m.WParam.ToString()) {
					case "1":
						//var rec = Screen.PrimaryScreen.Bounds;
						//_screem = new Bitmap(rec.Width, rec.Height);
						//using (var graphic = Graphics.FromImage(_screem)) {
						//	//graphic.CopyFromScreen(0, 0, 0, 0, new Size(rec.Width, rec.Height));
						//}
						var hwnd = WinApi.GetForegroundWindow();
						//_screem = GetWindowCapture(hwnd);
						_screem = CaptureWindow(hwnd);
						var rec = new Rectangle(0, 0, _screem.Width, _screem.Height);
						_colver = new Bitmap(rec.Width, rec.Height);
						using (var g = Graphics.FromImage(_colver)) {
							g.Clear(Color.FromArgb(50, 200, 0, 0));
						}
						this.WindowState = FormWindowState.Maximized;
						this.Invalidate();
						break;
					default:
						break;
				}
			} else if (m.Msg == 0x0201) {
				if (_pictureCapState) {
				}
			}
			base.WndProc(ref m);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			WindowAPIImport.UnregisterHotKey(this.Handle, 1);
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			_pictureCapState = true;
			_startPt = e.Location;
		}

		private void Form1_MouseMove(object sender, MouseEventArgs e)
		{
			if (_pictureCapState) {
				_endPt = e.Location;
				var g = Graphics.FromImage(_colver);
				g.Clear(Color.FromArgb(50, 200, 0, 0));
				g.DrawRectangle(Pens.Red, _startPt.X, _startPt.Y, _endPt.X - _startPt.X, _endPt.Y - _startPt.Y);
				this.Invalidate();
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if (_pictureCapState) {
				_pictureCapState = false;
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			g.DrawImage(_screem, 0, 0);
			g.DrawImage(_colver, 0, 0);
		}

		/// <summary>
		/// 可以截取非前端窗体的截图,但是非GDI的程序是无法截图的比如DirectX
		/// </summary>
		/// <param name="hWnd"></param>
		/// <returns></returns>
		public static Bitmap GetWindowCapture(IntPtr hWnd)
		{
			IntPtr hscrdc = WinApi.GetWindowDC(hWnd);
			var windowRect = new WinApi.RECT();
			WinApi.GetWindowRect(hWnd, ref windowRect);
			int width = windowRect.right - windowRect.left;
			int height = windowRect.bottom - windowRect.top;

			IntPtr hbitmap = WinApi.CreateCompatibleBitmap(hscrdc, width, height);
			IntPtr hmemdc = WinApi.CreateCompatibleDC(hscrdc);
			WinApi.SelectObject(hmemdc, hbitmap);
			WinApi.PrintWindow(hWnd, hmemdc, 0);
			Bitmap bmp = Bitmap.FromHbitmap(hbitmap);
			WinApi.DeleteDC(hscrdc);//删除用过的对象  
			WinApi.DeleteDC(hmemdc);//删除用过的对象  
			return bmp;
		}

		/// <summary>  
		/// 指定窗口截图   可以截取GDI或者非GDI图形 只不过,非前端窗体图形不能截获...
		/// </summary>  
		/// <param name="handle">窗口句柄. (在windows应用程序中, 从Handle属性获得)</param>  
		/// <returns></returns>  
		public Bitmap CaptureWindow(IntPtr handle)
		{
			IntPtr hdcSrc = WinApi.GetWindowDC(handle);
			WinApi.RECT windowRect = new WinApi.RECT();
			WinApi.GetWindowRect(handle, ref windowRect);
			int width = windowRect.right - windowRect.left;
			int height = windowRect.bottom - windowRect.top;
			IntPtr hdcDest = WinApi.CreateCompatibleDC(hdcSrc);
			IntPtr hBitmap = WinApi.CreateCompatibleBitmap(hdcSrc, width, height);
			IntPtr hOld = WinApi.SelectObject(hdcDest, hBitmap);
			WinApi.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, WinApi.SRCCOPY);
			//WinApi.SelectObject(hdcDest, hOld);
			WinApi.DeleteDC(hdcDest);
			WinApi.ReleaseDC(handle, hdcSrc);
			var img = Bitmap.FromHbitmap(hBitmap);
			WinApi.DeleteObject(hBitmap);
			return img;
		}
	}
}
