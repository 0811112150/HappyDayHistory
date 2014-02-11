using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HappyDay.SoundCap
{
	public class SoundCaptureAPI
	{
		#region
		[DllImport("winmm.dll", EntryPoint = "mciSendString", CharSet = CharSet.Auto)]
		public static extern int mciSendString(string lpstrCommand,
		 string lpstrReturnString,
		 int uReturnLength,
		 int hwndCallback);

		public static void StartRecordSendString()
		{
			mciSendString("set wave bitpersample 8", "", 0, 0);
			mciSendString("set wave samplespersec 20000", "", 0, 0);
			mciSendString("set wave channels 2", "", 0, 0);
			mciSendString("set wave format tag pcm", "", 0, 0);

			mciSendString("close movie", "", 0, 0);
			mciSendString("open new type WAVEAudio alias movie", "", 0, 0);
			mciSendString("record movie", "", 0, 0);
		}

		public static void StopRecordAndSaveSendString(string path)
		{
			mciSendString("stop movie", "", 0, 0);
			mciSendString("save movie " + path, "", 0, 0);
			mciSendString("close movie", "", 0, 0);
		}
		#endregion

		#region
		//Wave_audio数据格式 
		[StructLayout(LayoutKind.Sequential)]
		public struct WAVEFORMAT
		{
			public int wFormatTag;
			public int nChannels;
			public int nSamplesPerSec;
			public int nAvgBytesPerSec;
			public int nBlockAlign;
		}

		///   <summary> 
		///   waveform-audio   缓存格式 
		///   </summary> 
		[StructLayout(LayoutKind.Sequential)]
		public struct WAVEHDR
		{
			///   <summary> 
			///   指向锁定的数据缓冲区的指针   
			///   </summary> 
			public string lpData;
			///   <summary> 
			///   数据缓冲区的大小 
			///   </summary> 
			public int dwBufferLength;
			///   <summary> 
			///   录音时指明缓冲区中的数据量 
			///   </summary> 
			public int dwBytesRecorded;
			///   <summary> 
			///   用户数据 
			///   </summary> 
			public int dwUser;
			///   <summary> 
			///   提供缓冲区信息的标志 
			///   </summary> 
			public int dwFlags;
			///   <summary> 
			///   循环播放的次数 
			///   </summary> 
			public int dwLoops;
			///   <summary> 
			///   保留 
			///   </summary> 
			public int lpNext;
			///   <summary> 
			///   保留 
			///   </summary> 
			public int Reserved;
		}

		//struct WAVEFORMAT
		//{
		//    public short wFormatTag;
		//    public short nChannels;
		//    public int nSamplesPerSec;
		//    public int nAvgBytesPerSec;
		//    public short nBlockAlign;
		//}

		//查询指定波形输出设备的当前音量设置
		[DllImport("winmm.dll")]
		public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

		[DllImport("winmm.dll")]
		public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

		//为波形输入准备一个输入缓冲区
		[DllImport("winmm.dll ", EntryPoint = "waveInPrepareHeader ")]
		public static extern int waveInPrepareHeader(
		  int hWaveIn,
		  ref   WAVEHDR lpWaveInHdr,
		 int uSize
		   );

		[DllImport("winmm.dll ")]
		public static extern int waveInOpen(out IntPtr phwi, int uDeviceID, WAVEFORMAT lpFormat, int dwCallback, int dwInstance, int dwFlags);

		//给输入设备增加一个缓存 
		[DllImport("winmm.dll ", EntryPoint = "waveInAddBuffer ")]
		public static extern int waveInAddBuffer(int hWaveIn, ref   WAVEHDR lpWaveInHdr, int uSize);

		//开始录音 
		[DllImport("winmm.dll ", EntryPoint = "waveInStart ")]
		public static extern int waveInStart(int hWaveIn);

		//清除缓存   
		[DllImport("winmm.dll ", EntryPoint = "waveInUnprepareHeader ")]
		public static extern int waveInUnprepareHeader(int hWaveIn, ref   WAVEHDR lpWaveInHdr, int uSize);

		//停止录音 
		[DllImport("winmm.dll ", EntryPoint = "waveInReset ")]
		public static extern int waveInReset(int hWaveIn);

		//关闭录音设备 
		[DllImport("winmm.dll ", EntryPoint = "waveInClose ")]
		public static extern int waveInClose(int hWaveIn);

		//打开回放设备 
		[DllImport("winmm.dll ", EntryPoint = "waveOutOpen ")]
		public static extern int waveOutOpen(
		ref   int lphWaveOut,
		int uDeviceID,
		ref   WAVEFORMAT lpFormat,
		int dwCallback,
		int dwInstance,
		int dwFlags
		);

		//为回放设备准备内存块 
		[DllImport("winmm.dll ", EntryPoint = "waveOutPrepareHeader ")]
		public static extern int waveOutPrepareHeader(
		int hWaveOut,
		ref   WAVEHDR lpWaveOutHdr,
		int uSize
		);

		//写数据（放音） 
		[DllImport("winmm.dll ", EntryPoint = "waveOutWrite ")]
		public static extern int waveOutWrite(
		int hWaveOut,
		ref   WAVEHDR lpWaveOutHdr,
		int uSize
		);

		[DllImport("winmm.dll")]
		public static extern long PlaySound(string lpszName, int hModule, int dwFlags);

		//打开设备时消息，在此期间我们可以进行一些初始化工作 
		public const int MM_WIM_OPEN = 0x3BE;
		//当缓存已满或者停止录音时的消息，处理这个消息可以对缓存进行重新分配，实现不限长度录音 
		public const int MM_WIM_DATA = 0x3C0;
		//关闭录音设备时的消息 
		public const int MM_WOM_CLOSE = 0x3BC;
		// 
		public const int WAVE_FORMAT_PCM = 1;
		public const int WAVE_MAPPER = -1;

		public static void StartRecordWave()
		{
			//waveInOpen();
		}

		#endregion
	}
}
