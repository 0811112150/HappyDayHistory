using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace Human.MainWindow.HelperCommon
{
	public static class ControlDataCheckHelper
	{
		public static string IDCardNumberRegex { get { return @"^\d{17}[\d|x|X]$|^\d{15}$"; } }
		public static string MobilePhoneRegex { get { return @"^\d{11}$"; } }

		public static void IntCheck(Control checkControl, ErrorProvider errorProvider, CancelEventArgs e)
		{
			int result;
			if (!string.IsNullOrEmpty(checkControl.Text) && !int.TryParse(checkControl.Text, out result)) {
				e.Cancel = true;
				errorProvider.SetError(checkControl, "请输入数字!");
			} else {
				errorProvider.Clear();
			}
		}

		public static void NotNullCheck(Control checkControl, ErrorProvider errorProvider, CancelEventArgs e)
		{
			if (string.IsNullOrEmpty(checkControl.Text)) {
				e.Cancel = true;
				errorProvider.SetError(checkControl, "不能为空!");
			} else {
				errorProvider.Clear();
			}
		}

		public static void RegexCheck(Control checkControl, ErrorProvider errorProvider, string regexStr, CancelEventArgs e)
		{
			if (!Regex.IsMatch(checkControl.Text, regexStr)) {
				e.Cancel = true;
				errorProvider.SetError(checkControl, "格式不正确!");
			} else {
				errorProvider.Clear();
			}
		}

		public static void FloatCheck(Control checkControl, ErrorProvider errorProvider, CancelEventArgs e)
		{
			float result;
			if (!string.IsNullOrEmpty(checkControl.Text) && !float.TryParse(checkControl.Text, out result)) {
				e.Cancel = true;
				errorProvider.SetError(checkControl, "请输入数字!");
			} else {
				errorProvider.Clear();
			}
		}
	}
}
