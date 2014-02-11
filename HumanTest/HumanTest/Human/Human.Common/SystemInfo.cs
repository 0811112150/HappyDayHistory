using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Human.Common
{
	public class SystemInfo
	{
		public static string ErrorReminderStr { get { return "操作失败!"; } }

		public static string SuccessReminderStr { get { return "操作成功!"; } }

		public static string ReminderStr { get { return "提示"; } }

		public static string ContractFirst { get { return "首签"; } }
		public static string ContractNotFirst { get { return "续签"; } }

		public static string UploadPeoplePicFolder { get { return "UploadFile\\PeoplePic\\"; } }

		public static string JpgPicExt { get { return ".jpg"; } }

		public static string PngPicExt { get { return ".png"; } }

		public static string BmpPicExt { get { return ".bmp"; } }

		public static string TIFFPicExt { get { return ".tiff"; } }

		public static string WordExt { get { return ".doc"; } }

		public static string WordXExt { get { return ".docx"; } }

		public static string ExcelExt { get { return ".xls"; } }

		public static string ExcelXExt { get { return ".xlsx"; } }

		public static string FileFilter { get { return "图片|*.jpg;*.png;*.bmp;*.tiff|Word|*.doc;*.docx|Excel|*.xls;*.xlsx"; } }
	}
}
