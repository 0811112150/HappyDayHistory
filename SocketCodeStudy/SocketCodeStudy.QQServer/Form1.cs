using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml.Serialization;
using SocketCodeStudy.QQClass;
using System.IO;

namespace SocketCodeStudy.QQServer
{
	public partial class Form1 : Form
	{
		private UdpClient udpClient;
		private TcpListener listener;
		private int tcpPort;
		private List<UserInfo> userList = new List<UserInfo>();

		public Form1()
		{
			InitializeComponent();

			this.txtIPAddress.Text = "192.168.131.5";
			this.txtPort.Text = "8888";
			this.btnStart.Enabled = true;
			this.btnStop.Enabled = false;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			this.btnStart.Enabled = false;
			this.btnStop.Enabled = true;

			IPAddress serverIPAddress = IPAddress.Parse(this.txtIPAddress.Text);
			int port = int.Parse(this.txtPort.Text);
			IPEndPoint serverEndPoint = new IPEndPoint(serverIPAddress, port);

			udpClient = new UdpClient(serverEndPoint);
			tcpPort = port + 1;
			new Thread(ReceiveMessage).Start();

			listener = new TcpListener(serverIPAddress, tcpPort);
			listener.Start();
			new Thread(ListenClientConnect).Start();
		}
		//udp接收消息
		private void ReceiveMessage()
		{
			while (true) {
				IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
				var receiveBytes = udpClient.Receive(ref remoteEndPoint);
				var stream = new MemoryStream(receiveBytes);
				var userInfo = (UserInfo)new XmlSerializer(typeof(UserInfo)).Deserialize(stream);
				if (userInfo.IsLoginOn) {
					userList.Add(userInfo);
					SendAcceptMessage(userInfo);

					var reminderStr = string.Format("{0}:{1}上线了", userInfo.UserName, userInfo.RemoteIPEndpoint);
					foreach (var user in userList) {
						if (user.UserName != userInfo.UserName) {
							SendtoClientString(user, reminderStr);
						}
					}
				} else {
					var reminderStr = string.Format("{0}:{1}下线了", userInfo.UserName, userInfo.RemoteIPEndpoint);
					userList.Remove(userInfo);
					foreach (var user in userList) {
						SendtoClientString(user, reminderStr);
					}
				}
			}

		}
		//发送应答消息
		private void SendAcceptMessage(UserInfo user)
		{
			var loginInfo = new LoginInfo(true, tcpPort);
			//var messageStream = new MemoryStream();
			//new XmlSerializer(typeof(LoginInfo)).Serialize(messageStream, loginInfo);
			var messageBytes = SerializerHelper.ConvertObjectToBytes<LoginInfo>(loginInfo);
			udpClient.Send(messageBytes, messageBytes.Length, user.RemoteIPEndpoint);
		}
		//发送消息(上线提醒)
		private void SendtoClientString(UserInfo user, string message)
		{
			var bytes = Encoding.UTF8.GetBytes(message);
			udpClient.Send(bytes, bytes.Length, user.RemoteIPEndpoint);
		}

		//TCP监听连接
		private void ListenClientConnect()
		{
			TcpClient tcpClient = null;
			while (true) {
				tcpClient = listener.AcceptTcpClient();
				this.listBox1.Items.Add(string.Format("接受客户端{0}的TCP请求", tcpClient.Client.RemoteEndPoint));
				SendUserListData(tcpClient);
			}
		}
		//同步在线用户信息
		private void SendUserListData(TcpClient tcpClient)
		{
			var message = SerializerHelper.ConvertObjectToBytes<List<UserInfo>>(userList);
			tcpClient.GetStream().Write(message, 0, message.Length);
		}
	}
}
