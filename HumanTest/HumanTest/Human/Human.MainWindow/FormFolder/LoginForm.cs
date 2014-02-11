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

namespace Human.MainWindow
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var userName = this.txtUserName.Text;
			var password = this.txtPassword.Text;
			var result = new UserBLL().IsUserCorrect(userName, password);

			if (result.Code > 0) {
				MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
			} else if (result.Data == true) {
				MainForm.CurrentUserName = userName;
				var mainForm = new MainForm();
				mainForm.Show();
				this.Hide();
			}
		}

		private void btnLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) {
				btnLogin_Click(sender, e);
			}
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}
