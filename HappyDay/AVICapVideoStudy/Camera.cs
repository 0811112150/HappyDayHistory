using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyDay.AVICapVideoStudy
{
	public class Camera
	{
		// delegate for frame callback
		public delegate void RecievedFrameEventHandler(byte[] data);
		public event RecievedFrameEventHandler RecievedFrame;
		private IntPtr lwndC; // Holds the unmanaged handle of the control
		private IntPtr mControlPtr; // Holds the managed pointer of the control
		private int mWidth;
		private int mHeight;
		private ShowVideoBase.FrameEventHandler mFrameEventHandler; // Delegate instance for the frame callback - must keep alive! gc should NOT collect it

		public Camera(IntPtr handle, int width, int height)
		{
			this.mControlPtr = handle;
			mWidth = width;
			mHeight = height;
		}

		public void CloseCamera()
		{
			this.capDriverDisconnect(this.lwndC);
		}

		public void StartCamera()
		{
			byte[] lpszName = new byte[100];
			byte[] lpszVer = new byte[100];
			ShowVideoBase.capGetDriveDescriptionA(0, lpszName, 100, lpszVer, 100);
			this.lwndC = ShowVideoBase.capCreateCaptureWindowA(lpszName, ShowVideoBase.WS_VISIBLE + ShowVideoBase.WS_CHILD, 0, 0, mWidth, mHeight, mControlPtr, 0);
			if (this.capDriverConnect(this.lwndC, 0)) {
				this.capPreviewRate(this.lwndC, 66);
				this.capPreview(this.lwndC, true);
				ShowVideoBase.BITMAPINFO bitmapinfo = new ShowVideoBase.BITMAPINFO();
				bitmapinfo.bmiHeader.biSize = ShowVideoBase.SizeOf(bitmapinfo.bmiHeader);
				bitmapinfo.bmiHeader.biWidth = 352;
				bitmapinfo.bmiHeader.biHeight = 288;
				bitmapinfo.bmiHeader.biPlanes = 1;
				bitmapinfo.bmiHeader.biBitCount = 24;
				this.capSetVideoFormat(this.lwndC, ref bitmapinfo, ShowVideoBase.SizeOf(bitmapinfo));
				this.mFrameEventHandler = new ShowVideoBase.FrameEventHandler(FrameCallBack);
				this.mFrameEventHandler = new ShowVideoBase.FrameEventHandler(FrameCallBack);
				this.capSetCallbackOnFrame(this.lwndC, this.mFrameEventHandler);
				ShowVideoBase.SetWindowPos(this.lwndC, 0, 0, 0, mWidth, mHeight, 6);

			}
		}

		private bool capDriverConnect(IntPtr lwnd, short i)
		{
			return ShowVideoBase.SendMessage(lwnd, ShowVideoBase.WM_CAP_DRIVER_CONNECT, i, 0);
		}

		private bool capDriverDisconnect(IntPtr lwnd)
		{
			return ShowVideoBase.SendMessage(lwnd, ShowVideoBase.WM_CAP_DRIVER_DISCONNECT, 0, 0);
		}
		private bool capPreview(IntPtr lwnd, bool f)
		{
			return ShowVideoBase.SendMessage(lwnd, ShowVideoBase.WM_CAP_SET_PREVIEW, f, 0);
		}
		private bool capPreviewRate(IntPtr lwnd, short wMS)
		{
			return ShowVideoBase.SendMessage(lwnd, ShowVideoBase.WM_CAP_SET_PREVIEWRATE, wMS, 0);
		}
		public bool capSetVideoFormat(IntPtr hCapWnd, ref ShowVideoBase.BITMAPINFO BmpFormat, int CapFormatSize)
		{
			return ShowVideoBase.SendMessage(hCapWnd, ShowVideoBase.WM_CAP_SET_VIDEOFORMAT, CapFormatSize, ref BmpFormat);
		}
		private bool capSetCallbackOnFrame(IntPtr lwnd, ShowVideoBase.FrameEventHandler lpProc)
		{
			return ShowVideoBase.SendMessage(lwnd, ShowVideoBase.WM_CAP_SET_CALLBACK_FRAME, 0, lpProc);
		}
		public void FrameCallBack(IntPtr lwnd, IntPtr lpVHdr)
		{
			ShowVideoBase.VIDEOHDR videoHeader = new ShowVideoBase.VIDEOHDR();
			byte[] VideoData;
			videoHeader = (ShowVideoBase.VIDEOHDR)ShowVideoBase.GetStructure(lpVHdr, videoHeader);
			VideoData = new byte[videoHeader.dwBytesUsed];
			ShowVideoBase.Copy(videoHeader.lpData, VideoData);
			if (this.RecievedFrame != null)
				this.RecievedFrame(VideoData);
		}
	}
}
