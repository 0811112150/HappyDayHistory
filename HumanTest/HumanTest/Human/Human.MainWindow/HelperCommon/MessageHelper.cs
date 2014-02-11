using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Human.Common;
using System.Windows.Forms;

namespace Human.MainWindow.HelperCommon
{
	public class MessageHelper
	{
		public static void ShowSaveDbResultMessage(CResult<bool> result)
		{
			if (result.Code > 0) {
				MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
				return;
			} else {
				MessageBox.Show(SystemInfo.SuccessReminderStr, SystemInfo.ReminderStr, MessageBoxButtons.OK);
			}
		}
	}
}
