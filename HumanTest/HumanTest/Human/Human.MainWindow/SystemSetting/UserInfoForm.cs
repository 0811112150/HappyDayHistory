using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.BLL;
using Human.Common;
using Human.ViewModel;

namespace Human.MainWindow.SystemSetting
{
	public partial class UserInfoForm : Form
	{
		public UserInfoForm()
		{
			InitializeComponent();
		}

		private void UserInfoForm_Load(object sender, EventArgs e)
		{
			var currentUserName = MainForm.CurrentUserName;
			var result = new UserBLL().GetUserInfoByName(currentUserName);

			if (result.Code > 0) {
				MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
				this.Close();
			}

			this.txtUserInfoID.Text = result.Data.UserID.ToString();
			this.txtUserName.Text = result.Data.UserName;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			var userName = this.txtUserName.Text;
			var oldPassword = this.txtOldPassword.Text;
			var newPassword = this.txtNewPassword.Text;
			var confirmPassword = this.txtConfirmPassword.Text;

			if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(oldPassword)
				|| string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword)) {
				MessageBox.Show("请填写基本信息!", "信息错误!");
				return;
			}
			if (newPassword != confirmPassword) {
				MessageBox.Show("两次填写的密码不一致!", "信息错误!");
				return;
			}

			var webUserInfo = new WebUserInfo() {
				UserID = int.Parse(this.txtUserInfoID.Text),
				UserName = userName,
				ConfirmPassword = confirmPassword,
				NewPassword = newPassword,
				OldPassword = oldPassword,
			};
			var result = new UserBLL().UpdateUserInfo(webUserInfo);
			if (result.Code > 0) {
				MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
			} else {
				MessageBox.Show("修改成功", SystemInfo.SuccessReminderStr, MessageBoxButtons.OK);
				this.Close();
			}
		}
	}
}
