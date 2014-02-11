using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace HappyDay.SpeechReadTxt
{
	public class SpeechReadFile
	{
		public static readonly int Test;

		public static SpeechSynthesizer speechReader = new SpeechSynthesizer();

		public static void ReadFile(string fileName)
		{
			var fileReader = new StreamReader(fileName, Encoding.UTF8);
			var str = fileReader.ReadToEnd();
			ReadString(str);
		}

		public static void ReadString(string toReedString)
		{
			if (string.IsNullOrWhiteSpace(toReedString)) {
				return;
			}
			speechReader.SpeakAsync(toReedString);
		}

		public static void StopRead()
		{
			speechReader.Pause();
		}

		public static void ContinueRead()
		{
			speechReader.Resume();
		}
	}
}
