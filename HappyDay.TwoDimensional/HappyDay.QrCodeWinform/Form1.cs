using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;

namespace HappyDay.QrCodeWinform
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			qrCodeGraphicControl1.Text = txtToConvert.Text;
			//var toConvertStr = txtToConvert.Text;
			//var qrEncoder = new QrEncoder(ErrorCorrectionLevel.M);
			//var qrCode = qrEncoder.Encode(toConvertStr);
			//var sizeCal = new FixedModuleSize(12, QuietZoneModules.Four);
			//var render = new GraphicsRenderer(sizeCal);
			//render.Draw(pnlTwoDim.CreateGraphics(), qrCode.Matrix);

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var fileName = "";
			using (var saveDlg = new SaveFileDialog()) {
				saveDlg.Filter = "*|*.png";
				if (saveDlg.ShowDialog() != DialogResult.OK) {
					return;
				} else {
					fileName = saveDlg.FileName;
				}
			}

			var qrCode = qrCodeGraphicControl1.GetQrMatrix();
			var sizeCal = new FixedModuleSize(12, qrCodeGraphicControl1.QuietZoneModule);
			var render = new GraphicsRenderer(sizeCal);
			//new FixedCodeSize(width, m_QuietZoneModule)
			var memoryStream = new MemoryStream();
			render.WriteToStream(qrCode, ImageFormat.Png, memoryStream);

			var image = Image.FromStream(memoryStream);

			image.Save(fileName);
		}
	}
}
