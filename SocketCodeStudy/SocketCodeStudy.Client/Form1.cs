using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Xml.Serialization;
using SocketCodeStudy.QQClass;
using System.Threading;
using System.IO;

namespace SocketCodeStudy.Client
{
	public partial class Form1 : Form
	{
		private TcpClient tcpClient;
		private UdpClient udpClient;

		private IPEndPoint serverEndpointUdp;
		private IPEndPoint localEndPoint;
		private int ServerTcpPort;
		public Form1()
		{
			InitializeComponent();
			this.txtServerIPAddress.Text = "192.168.131.5";
			this.txtServerPort.Text = "8888";
			this.txtLocalIPAddress.Text = "192.168.131.5";
			this.txtLocalPort.Text = "10000";
			this.txtUserName.Text = "用户1";
			this.btnLoginOut.Enabled = false;
			this.btnLogin.Enabled = true;
		}

		private void tbnLogin_Click(object sender, EventArgs e)
		{
			this.btnLoginOut.Enabled = true;
			this.btnLogin.Enabled = false;
			IPAddress serverIPAddress = IPAddress.Parse(this.txtServerIPAddress.Text);
			var serverPort = int.Parse(this.txtServerPort.Text);
			serverEndpointUdp = new IPEndPoint(serverIPAddress, serverPort);
			new Thread(ReceiveReplayMeesage).Start();

			var locaIPAddress = IPAddress.Parse(this.txtLocalIPAddress.Text);
			var localPort = int.Parse(this.txtLocalPort.Text);
			localEndPoint = new IPEndPoint(locaIPAddress, localPort);
			udpClient = new UdpClient(localEndPoint);
			SendMessageToServer(true);
		}

		//登陆和退出
		private void SendMessageToServer(bool isLogin)
		{
			var userInfo = new UserInfo(this.txtUserName.Text, localEndPoint, isLogin);
			var bytes = SerializerHelper.ConvertObjectToBytes<UserInfo>(userInfo);
			udpClient.Send(bytes, bytes.Length, serverEndpointUdp);
		}
		//接收服务器消息
		private void ReceiveReplayMeesage()
		{
			var bytes = udpClient.Receive(ref serverEndpointUdp);
			var loginInfo = SerializerHelper.ConvertBytesToObject<LoginInfo>(bytes);
			ServerTcpPort = loginInfo.ServerListenPort;


			tcpClient = new TcpClient();
			tcpClient.Connect(serverEndpointUdp.Address, loginInfo.ServerListenPort);
			if (tcpClient != null && tcpClient.Connected) {
				var stream = tcpClient.GetStream();
				var userList = (List<UserInfo>)new XmlSerializer(typeof(List<UserInfo>)).Deserialize(stream);
				foreach (var item in userList) {
					this.listBox1.Items.Add(item.UserName + ":" + item.RemoteIPEndpoint);
				}
			}
		}
	}
}
