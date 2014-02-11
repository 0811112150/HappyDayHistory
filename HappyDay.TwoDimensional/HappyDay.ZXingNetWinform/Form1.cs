using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;

namespace HappyDay.ZXingNetWinform
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() != DialogResult.OK) {
				return;
			}
			pictureBox1.ImageLocation = openFileDialog1.FileName;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var reader = new MultiFormatReader();
			var img = (Bitmap)Bitmap.FromFile(pictureBox1.ImageLocation);

			BitmapLuminanceSource ls = new BitmapLuminanceSource(img);
			var binarizer = new HybridBinarizer(ls);
			BinaryBitmap binaryBitmap = new BinaryBitmap(binarizer);
			var result = reader.decode(binaryBitmap);
			richTextBox1.Text = result.Text.Trim();
		}
	}
}
