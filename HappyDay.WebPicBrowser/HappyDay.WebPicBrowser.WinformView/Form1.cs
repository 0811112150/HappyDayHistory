using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;

namespace HappyDay.WebPicBrowser.WinformView
{
	public partial class Form1 : Form
	{
		private List<string> _imageUrlList = new List<string>();
		private int _currentIndex = -1;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (_currentIndex >= _imageUrlList.Count - 1) {
				_currentIndex = -1;
			}
			_currentIndex++;
			if (_currentIndex >= 0) {
				pictureBox1.ImageLocation = _imageUrlList[_currentIndex];
			}
		}

		private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			_imageUrlList.Clear();
			var imageHtmlList = webBrowser1.Document.Images;
			foreach (HtmlElement imageHtml in imageHtmlList) {
				var src = imageHtml.GetAttribute("src");
				_imageUrlList.Add(src);
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			webBrowser1.Url = new Uri(txtUrl.Text);
		}
	}
}
