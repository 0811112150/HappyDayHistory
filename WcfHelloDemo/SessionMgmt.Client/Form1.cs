using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SessionMgmt.Contract;

namespace SessionMgmt.Client
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string hostName = Dns.GetHostName();
			IPAddress[] ipAddressList = Dns.GetHostEntry(hostName).AddressList;
			string ipAddress = string.Empty;
			foreach (var item in ipAddressList) {
				if (item.AddressFamily == AddressFamily.InterNetwork) {
					ipAddress += item.ToString() + ";";
				}
			}
			ipAddress = ipAddress.TrimEnd(";".ToCharArray());

			string userName = this.textBox1.Text.Trim();
			if (string.IsNullOrEmpty(userName)) {
				return;
			}

			SessionClientInfo clientInfo = new SessionClientInfo() { IPAddress = ipAddress, HostName = hostName, UserName = userName };
			SessionUtility.StartSession(clientInfo);
			//this.groupBox2.Enabled = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			IList<SessionInfo> activeSessions = SessionUtility.GetActiveSessions();
			this.dataGridView1.DataSource = activeSessions;
			foreach (DataGridViewRow row in this.dataGridView1.Rows) {
				var sessionID = (Guid)row.Cells["SessionID"].Value;
				row.Cells["IPAddress"].Value = activeSessions.Where(session => session.SessionID == sessionID).
													ToList<SessionInfo>()[0].ClientInfo.IPAddress;
				row.Cells["UserName"].Value = activeSessions.Where(session => session.SessionID == sessionID).ToList<SessionInfo>()[0].ClientInfo.UserName;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var sessionIDs = new List<Guid>();
			foreach (DataGridViewRow row in this.dataGridView1.Rows) {
				var cell = row.Cells["Select"];
				if (cell.Value != null && (bool)cell.Value) {
					Guid sessionID = new Guid(row.Cells["SessionID"].Value.ToString());
					if (sessionID == SessionUtility.SessionID) {
						MessageBox.Show("You cannot kill your current session!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					sessionIDs.Add(sessionID);
				}
			}
			SessionUtility.KillSessions(sessionIDs);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//this.dataGridView1.AutoGenerateColumns = false;
			RegisterMouseMoveEvent(this);

		}

		private void RegisterMouseMoveEvent(Control control)
		{
			control.MouseHover += delegate {
				SessionUtility.LastActivityTime = DateTime.Now;
			};

			foreach (Control child in control.Controls) {
				this.RegisterMouseMoveEvent(child);
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.label2.Text = SessionUtility.SessionID.ToString();
		}
	}
}
