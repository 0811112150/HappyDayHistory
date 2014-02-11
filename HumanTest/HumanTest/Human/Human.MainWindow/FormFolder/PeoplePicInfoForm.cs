using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.BLL;
using Human.DomainModel;
using Human.Common;
using Human.MainWindow.HelperCommon;
using System.IO;

namespace Human.MainWindow
{
	public partial class PeoplePicInfoForm : Form
	{
		public delegate void CallBackFunction();
		public event CallBackFunction callbackEvent;

		private int? _currentPicID = null;
		private int? _peopleID = null;
		private bool _isEdit = false;

		public PeoplePicInfoForm(bool isEdit, int? pictID, int? peopleID)
		{
			InitializeComponent();

			this.openFileDialog1.Filter = SystemInfo.FileFilter;
			this.openFileDialog1.FileName = "";

			this._isEdit = isEdit;
			if (pictID.HasValue) {
				this._currentPicID = pictID;
			}
			if (peopleID.HasValue) {
				this._peopleID = peopleID;
			}

			if (isEdit) {
				InitControlValue();
			}
		}

		private void InitControlValue()
		{
			if (this._currentPicID.HasValue) {
				var pic = new PeoplePicBLL().GetPeoplePicByID(this._currentPicID.Value).Data;
				this.txtPicTitle.Text = pic.PicTitle;
				this.txtPicPath.Text = Path.GetFileName(pic.PicPath);
				this.openFileDialog1.FileName = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath)), pic.PicPath);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(this.txtPicPath.Text) || !File.Exists(this.openFileDialog1.FileName)) {
				MessageBox.Show("请选择文件！");
				return;
			}

			var pic = new PeoplePic();
			pic.PicTitle = this.txtPicTitle.Text;
			pic.PicPath = this.openFileDialog1.FileName;

			var bll = new PeoplePicBLL();
			CResult<bool> result = new CResult<bool>(false);
			if (this._isEdit) {
				pic.PicID = this._currentPicID.Value;
				result = bll.UpdatePeoplePic(pic);
			} else {
				pic.PeopleID = this._peopleID.Value;
				result = bll.InsertPeoplePic(pic);
			}

			MessageHelper.ShowSaveDbResultMessage(result);
			if (result.Code == 0) {
				this.Dispose();
				if (callbackEvent != null) {
					callbackEvent.Invoke();
				}
			}

		}

		private void btnSelectPic_Click(object sender, EventArgs e)
		{
			var dialogResult = this.openFileDialog1.ShowDialog();
			if (dialogResult == DialogResult.OK) {
				this.txtPicPath.Text = Path.GetFileName(openFileDialog1.FileName);
				//this.pBoxPic.Image = Image.FromFile(openFileDialog1.FileName);
			}
		}
	}
}
