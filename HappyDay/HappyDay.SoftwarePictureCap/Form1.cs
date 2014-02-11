using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Resources;

namespace HappyDay.SoftwarePictureCap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//openFileDialog1.Filter = "*|*.dll";
			//openFileDialog1.Multiselect = true;

			//if (openFileDialog1.ShowDialog() == DialogResult.OK) {
			//	var fileNames = openFileDialog1.FileNames;
			//	foreach (var fileName in fileNames) {
			//		try {
			//			var assembly = Assembly.LoadFile(fileName);
			//			var count = assembly.GetManifestResourceNames().Count();
			//			if (count > 0) {
			//				assembly.GetManifestResourceInfo("load_bearing_wall_place.ico");
			//				MessageBox.Show("");
			//			}
			//		} catch (System.Exception ex) {

			//		}
			//	}
			//}

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				var path = folderBrowserDialog1.SelectedPath;
				var dir = Directory.CreateDirectory(path);
				GetPic(dir);
			}
		}

		private void GetPic(DirectoryInfo dir)
		{
			foreach (var file in dir.GetFiles()) {
				if (file.Name.EndsWith(".exe") || file.Name.EndsWith(".dll")) {
					var assembly = Assembly.LoadFile(file.FullName);
					var list = assembly.GetManifestResourceNames();
					foreach (var item in list) {
						using (var stream = assembly.GetManifestResourceStream(item)) {
							if (item.EndsWith(".resources")) {
								using (var reader = new ResourceReader(stream)) {
									var enumer = reader.GetEnumerator();
									while (enumer.MoveNext()) {
										listBox1.Items.Add(enumer.Key + ":" + enumer.Value.ToString());
									}
								}
							}
						}
					}
				}
			}
			foreach (var folder in dir.GetDirectories()) {
				GetPic(folder);
			}
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tabControl1.TabPages.Add(new TabPage("1"));
			tabControl1.TabPages.Add(new TabPage("2"));
		}
	}
}
