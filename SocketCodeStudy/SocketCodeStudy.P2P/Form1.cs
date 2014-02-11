using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCodeStudy.P2P
{
	public partial class Form1 : Form
	{
		private Dictionary<int, PeerNameRegistration> resourceNameReg = new Dictionary<int, PeerNameRegistration>();
		private int seedCount = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			var resourceNameStr = this.txtResource.Text;
			var resourceName = new PeerName(resourceNameStr, PeerNameType.Unsecured);
			resourceNameReg[seedCount] = new PeerNameRegistration(resourceName, int.Parse(this.txtPort.Text));
			resourceNameReg[seedCount].Comment = resourceName.ToString();
			resourceNameReg[seedCount].Data = Encoding.UTF8.GetBytes(string.Format("{0}", DateTime.Now.ToString()));
			resourceNameReg[seedCount].Start();
			seedCount++;
			this.cbxResourceList.Items.Add(resourceName.ToString());
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.richTxtSearchResult.Clear();
			PeerName searchSeed = new PeerName("0." + txtSearch.Text);
			PeerNameResolver resolver = new PeerNameResolver();
			PeerNameRecordCollection recordCollection = resolver.Resolve(searchSeed);
			foreach (PeerNameRecord record in recordCollection) {
				foreach (var endPoint in record.EndPointCollection) {
					if (endPoint.AddressFamily.Equals(AddressFamily.InterNetwork)) {
						this.richTxtSearchResult.AppendText("\n" + endPoint.ToString() + ";" + Encoding.UTF8.GetString(record.Data));
					}
				}
			}
		}
	}
}
