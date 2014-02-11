using System;
using System.Windows.Forms;
using Human.MainWindow.SystemSetting;
using Human.Common;

namespace Human.MainWindow
{
	public partial class MainForm : Form
	{
		public static string CurrentUserName { get; set; }

		public MainForm()
		{
			InitializeComponent();
		}

		//private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		//{
		//    Application.Exit();
		//}

		private void TSMnuUserInfo_Click(object sender, EventArgs e)
		{
			var userInfoForm = new UserInfoForm();
			userInfoForm.ShowDialog();

			//var t = new UserInfoUserControl();
			//this.pnlMain.Controls.Clear();
			//this.pnlMain.Controls.Add(t);
		}

		private void TSMnuSystemSetting_Click(object sender, EventArgs e)
		{

		}

		private void 档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var workerBseInfoUserControl = new WorkerListControl();

			//<AddCode>
			workerBseInfoUserControl.Dock = DockStyle.Fill;
			//</AddCode>
			this.pnlMain.Controls.Clear();
			this.pnlMain.Controls.Add(workerBseInfoUserControl);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.lblCurrentUser.Text = string.Format("欢迎您,{0}!", MainForm.CurrentUserName);
			this.Text = string.Format("{0} ({1})", this.Text, MainForm.CurrentUserName);
		}

		private void btnLoginOut_Click(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show("确定要退出系统吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
			if (dialogResult == DialogResult.OK) {
				Application.Exit();
			}
		}

		//AddCode
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.ApplicationExitCall) {
				e.Cancel = false;
			} else {
				e.Cancel = true;
				btnLoginOut.PerformClick();
			}
		}
		//AddCode
	}
}
