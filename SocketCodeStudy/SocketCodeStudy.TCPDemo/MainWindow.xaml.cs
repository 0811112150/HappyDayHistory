using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Sockets;
using System.Net.PeerToPeer;
using System.Windows.Markup;
using System.Net;

namespace SocketCodeStudy.TCPDemo
{
	/// <summary>
	/// MainWindow.xaml 的交互逻辑
	/// </summary>
	public partial class MainWindow : Window
	{
		private TcpListener listener;
		private TcpClient client;
		private NetworkStream messageStream;

		public MainWindow()
		{
			InitializeComponent();
			this.txtIPAddress.Text = "127.0.0.1";
			this.txtPort.Text = "8888";
		}

		//开始监听
		private void btnStartListen_Click(object sender, RoutedEventArgs e)
		{
			var ipAddress = this.txtIPAddress.Text;
			var port = this.txtPort.Text;
			if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(port)) {
				MessageBox.Show("请输入IP地址或端口号", "错误");
				return;
			}

			var portNum = int.Parse(port);
			listener = new TcpListener(IPAddress.Parse(ipAddress), portNum);
			listener.Start();
			AppendStrToRichText("开始监听");
		}

		//停止监听
		private void btnStopListen_Click(object sender, RoutedEventArgs e)
		{
			listener.Stop();
			AppendStrToRichText("停止监听");
		}
		//清空消息
		private void btnClearContent_Click(object sender, RoutedEventArgs e)
		{
			this.richTxtMessageList.Document.Blocks.Clear();
		}
		//接收消息
		private void btnAccept_Click(object sender, RoutedEventArgs e)
		{
			client = listener.AcceptTcpClient();
			if (client != null && client.Connected) {
				messageStream = client.GetStream();
				var message = ReadStrFromStream();
				AppendStrToRichText(message);
			}
		}

		private void AppendStrToRichText(string str)
		{
			this.richTxtMessageList.AppendText(str);
		}
		private string ReadStrFromStream()
		{
			var buffer = new byte[2558];
			var messageLength = messageStream.Read(buffer, 0, 2558);
			return Encoding.UTF8.GetString(buffer, 0, messageLength);
		}
		private void WriteStrToStream(string message)
		{
			var buffer = Encoding.UTF8.GetBytes(message);
			if (messageStream == null) {
				messageStream = client.GetStream();
			}
			messageStream.Write(buffer, 0, buffer.Length);
		}
		private string GetRichTextBoxText(RichTextBox textBox)
		{
			TextRange textRange = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
			return textRange.Text;
		}
		//断开连接
		private void btnStopConnect_Click(object sender, RoutedEventArgs e)
		{
			listener.Stop();
		}
		//发送消息
		private void btnSendMessage_Click(object sender, RoutedEventArgs e)
		{
			var message = GetRichTextBoxText(richTxtMessageList);
			this.richTxtMessageList.Document.Blocks.Clear();
			WriteStrToStream(message);
		}
	}
}
