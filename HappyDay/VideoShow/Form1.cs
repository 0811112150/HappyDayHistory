using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyDay.VideoShow
{
	public partial class Form1 : Form
	{
		Camera camera;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			camera = new Camera(panel1.Handle, panel1.Width, panel1.Height);
			camera.StartCamera();
		}
	}
}
