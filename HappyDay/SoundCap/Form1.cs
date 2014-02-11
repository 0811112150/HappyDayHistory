using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyDay.SoundCap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			btnStart.Enabled = false;
			btnStop.Enabled = false;
		}

		private void btnSelectFilePath_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "*.wav|.wav";
			var dlgResult = saveFileDialog1.ShowDialog();
			if (dlgResult != DialogResult.Yes) {
				var fileName = saveFileDialog1.FileName;
				txtFilePath.Text = fileName;
				btnStart.Enabled = true;
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFilePath.Text)) {
				return;
			}

			btnSelectFilePath.Enabled = false;
			btnStart.Enabled = false;
			btnStop.Enabled = true;

			SoundCaptureAPI.StartRecordSendString();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			btnSelectFilePath.Enabled = true;
			btnStart.Enabled = true;
			btnStop.Enabled = false;

			SoundCaptureAPI.StopRecordAndSaveSendString(txtFilePath.Text);
		}
	}
}
