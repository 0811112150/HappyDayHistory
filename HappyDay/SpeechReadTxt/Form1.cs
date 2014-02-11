using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.Web;
using System.Xml;

namespace HappyDay.SpeechReadTxt
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "txt|*.txt";
			var dlgResult = openFileDialog1.ShowDialog();
			if (dlgResult != DialogResult.OK) {
				return;
			} else {
				txtFilePath.Text = openFileDialog1.FileName;
				btnStart.Enabled = true;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btnStart.Enabled = false;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			btnSelectFile.Enabled = false;
			btnStart.Enabled = false;

			SpeechReadFile.speechReader.SpeakCompleted += Finish;

			SpeechReadFile.ReadFile(txtFilePath.Text);
		}

		private void Finish(object s, SpeakCompletedEventArgs arg)
		{
			btnStart.Enabled = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var webClient = new WebClient() { Encoding = Encoding.UTF8 };
			var location = webClient.DownloadString("http://int.dpool.sina.com.cn/iplookup/iplookup.php?format=json");
			var json = new JavaScriptSerializer().Deserialize<dynamic>(location);
			var city = HttpUtility.UrlDecode(json["city"]);
			var weather = webClient.DownloadString(string.Format("http://php.weather.sina.com.cn/xml.php?city={0}&password=DJOYnieT8234jlsK&day=0", HttpUtility.UrlEncode(json["city"], Encoding.GetEncoding("GB2312"))));
			var xml = new XmlDocument();
			xml.LoadXml(weather);
			//Get weather detail
			var root = xml.SelectSingleNode("/Profiles/Weather");
			var detail = root["status1"].InnerText + "，" + root["direction1"].InnerText
							+ root["power1"].InnerText.Replace("-", "到") + "级，"
							+ root["gm_s"].InnerText + root["yd_s"].InnerText;

			var str = "今天是" + DateTime.Now.ToShortDateString() + "，" + city + " " + detail;
			richTextBox1.Text = str;
			SpeechReadFile.ReadString(str);
		}
	}
}
