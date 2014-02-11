using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SocketCodeStudy.TCPDemo
{
	/// <summary>
	/// ClientForm.xaml 的交互逻辑
	/// </summary>
	public partial class ClientForm : Window
	{
		private TcpClient client;
		private NetworkStream messageStream;

		public ClientForm()
		{
			InitializeComponent();
			this.txtIPAddress.Text = "127.0.0.1";
			this.txtPort.Text = "8888";
			client = new TcpClient();

		}
		//连接服务器
		private void btnStartListen_Click(object sender, RoutedEventArgs e)
		{
			var ipAddress = this.txtIPAddress.Text;
			var port = this.txtPort.Text;
			if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(port)) {
				MessageBox.Show("请输入IP地址或端口号", "错误");
				return;
			}
			var portNum = int.Parse(port);
			client.Connect(IPAddress.Parse(ipAddress), portNum);
			if (client.Connected) {
				messageStream = client.GetStream();
				AppendStrToRichText("连接成功");
			}
		}
		//断开连接
		private void btnStopListen_Click(object sender, RoutedEventArgs e)
		{
			client.Close();
		}
		//清空消息
		private void btnClearContent_Click(object sender, RoutedEventArgs e)
		{
			this.richTxtMessageList.Document.Blocks.Clear();
		}
		//接收
		private void btnAccept_Click(object sender, RoutedEventArgs e)
		{
			if (client != null && client.Connected) {
				if (messageStream == null) {
					messageStream = client.GetStream();
				}
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
			messageStream.Write(buffer, 0, buffer.Length);
		}
		private string GetRichTextBoxText(RichTextBox textBox)
		{
			TextRange textRange = new TextRange(textBox.Document.ContentStart, textBox.Document.ContentEnd);
			return textRange.Text;
		}
		//发送
		private void btnSendMessage_Click(object sender, RoutedEventArgs e)
		{
			var message = GetRichTextBoxText(richTxtMessage);
			this.richTxtMessage.Document.Blocks.Clear();
			WriteStrToStream(message);
		}
		//关闭
		private void btnStopConnect_Click(object sender, RoutedEventArgs e)
		{
			client.Close();
		}
	}
}
