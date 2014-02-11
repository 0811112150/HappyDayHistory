using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Human.BLL;
using Human.Common;
using System.IO;

namespace Human.MainWindow
{
	public partial class PeoplePicUserControl : UserControl
	{
		private string _delColumnName = "btnDel";
		private string _editColumName = "btnEdit";
		private string _downloadColumName = "btnDownload";

		private int _currentPeopleID;

		public PeoplePicUserControl(int peopleID)
		{
			this._currentPeopleID = peopleID;
			InitializeComponent();
			BindDataList();
		}

		private void BindDataList()
		{
			this.dgvPicList.AutoGenerateColumns = false;
			this.dgvPicList.DataSource = new PeoplePicBLL().GetPeoplePicList(_currentPeopleID).Data;
		}

		private void dgvPicList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;
			//AddCode
			if (rowIndex == -1) {
				return;
			}
			//AddCode
			if (this.dgvPicList.Columns[columnIndex] == this.dgvPicList.Columns[_delColumnName]) {
				var dialogResult = MessageBox.Show("确定要删除吗?", SystemInfo.ReminderStr, MessageBoxButtons.OKCancel);
				if (dialogResult == DialogResult.OK) {
					var PicID = (int)dgvPicList.Rows[rowIndex].Cells["PicID"].Value;
					var result = new PeoplePicBLL().DeletePeoplePicByID(PicID);
					if (result.Code > 0) {
						MessageBox.Show(result.Message, SystemInfo.ErrorReminderStr, MessageBoxButtons.OK);
					}
					BindDataList();
				}
			} else if (this.dgvPicList.Columns[columnIndex] == this.dgvPicList.Columns[_editColumName]) {
				var PicID = (int)dgvPicList.Rows[rowIndex].Cells["PicID"].Value;
				var form = new PeoplePicInfoForm(true, PicID, null);
				form.callbackEvent += delegate {
					BindDataList();
				};
				form.ShowDialog();
			} else if (this.dgvPicList.Columns[columnIndex] == this.dgvPicList.Columns[_downloadColumName]) {
				var picID = (int)dgvPicList.Rows[rowIndex].Cells["PicID"].Value;
				var pic = new PeoplePicBLL().GetPeoplePicByID(picID).Data;
				if (pic == null) {
					MessageBox.Show("文件不存在！");
				}
				var projectDir = Path.GetDirectoryName(Path.GetDirectoryName(Application.StartupPath));
				var picPath = Path.Combine(projectDir, pic.PicPath);
				var saveFileDlg = new SaveFileDialog();
				saveFileDlg.Filter = SystemInfo.FileFilter;
				if (saveFileDlg.ShowDialog() == DialogResult.OK) {
					var stream = saveFileDlg.OpenFile();
					var sourceFileStream = new FileStream(picPath, FileMode.Open, FileAccess.Read);
					sourceFileStream.CopyTo(stream);
					stream.Close();
					sourceFileStream.Close();
				}
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			var contractInfoForm = new PeoplePicInfoForm(false, null, this._currentPeopleID);
			contractInfoForm.callbackEvent += BindDataList;
			contractInfoForm.ShowDialog();
		}

		private void dgvPicList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow row in this.dgvPicList.Rows) {
				var fileExt = Path.GetExtension(row.Cells["PicPath"].Value.ToString());
				if (fileExt == SystemInfo.JpgPicExt
					|| fileExt == SystemInfo.PngPicExt
					|| fileExt == SystemInfo.TIFFPicExt
					|| fileExt == SystemInfo.BmpPicExt) {
					row.Cells["FileType"].Value = "图片";
				} else if (fileExt == SystemInfo.WordExt
					|| fileExt == SystemInfo.WordXExt) {
					row.Cells["FileType"].Value = "Word";
				} else if (fileExt == SystemInfo.ExcelExt
					|| fileExt == SystemInfo.ExcelXExt) {
					row.Cells["FileType"].Value = "Excel";
				}
			}
		}
	}
}
