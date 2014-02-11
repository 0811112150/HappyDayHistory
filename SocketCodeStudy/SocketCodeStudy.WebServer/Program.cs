using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace SocketCodeStudy.WebServer
{
	class Program
	{
		static void Main(string[] args)
		{
			//SocketRequest();
		}

		private void SocketRequest()
		{
			var localIPAddress = IPAddress.Loopback;
			var endPoint = new IPEndPoint(localIPAddress, 49155);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Bind(endPoint);
			socket.Listen(10);

			while (true) {
				Console.WriteLine("Wait an Connect Request...");
				var clientSocket = socket.Accept();
				Console.WriteLine("Client Address is:{0}", clientSocket.RemoteEndPoint);

				var buffer = new byte[2048];
				int receiverLength = clientSocket.Receive(buffer);
				var requestString = Encoding.UTF8.GetString(buffer, 0, receiverLength);
				Console.WriteLine(requestString);

				string statesLine = "HTTP/1.1 200 OK\r\n";
				var responseStatusLineBytes = Encoding.UTF8.GetBytes(statesLine);
				var responseBody = "<html><head><title>Default Page</title></head><body><p style='font:bold;font-size:24pt'>Welcome you</p></body></html>";
				var responseHeader = string.Format("Content-Type:text/html; charset=UTf-8\r\nContent-Length:{0}\r\n", responseBody.Length);
				var responseHeadreBytes = Encoding.UTF8.GetBytes(responseHeader);
				var responseBodyBytes = Encoding.UTF8.GetBytes(responseBody);

				clientSocket.Send(responseStatusLineBytes);
				clientSocket.Send(responseStatusLineBytes);
				clientSocket.Send(new byte[] { 13, 10 });
				clientSocket.Send(responseBodyBytes);

				clientSocket.Close();
				Console.ReadKey();
				break;
			}
			socket.Close();
		}

		private void TcpListenerRequest()
		{
			var localIPAddress = IPAddress.Loopback;
			var endPoint = new IPEndPoint(localIPAddress, 49155);
			var listener = new TcpListener(endPoint);
			listener.Start();
			Console.WriteLine("Wait an Connect Request...");
			while (true) {
				var client = listener.AcceptTcpClient();
				if (client.Connected) {
					Console.WriteLine("Created connection");
				}
				var stream = client.GetStream();
				var buffer = new byte[2048];
				int receiverLength = stream.Read(buffer, 0, 2048);
				var requestString = Encoding.UTF8.GetString(buffer, 0, receiverLength);
				Console.WriteLine(requestString);

				string statesLine = "HTTP/1.1 200 OK\r\n";
				var responseStatusLineBytes = Encoding.UTF8.GetBytes(statesLine);
				var responseBody = "<html><head><title>Default Page</title></head><body><p style='font:bold;font-size:24pt'>Welcome you</p></body></html>";
				var responseHeader = string.Format("Content-Type:text/html; charset=UTf-8\r\nContent-Length:{0}\r\n", responseBody.Length);
				var responseHeadreBytes = Encoding.UTF8.GetBytes(responseHeader);
				var responseBodyBytes = Encoding.UTF8.GetBytes(responseBody);

				stream.Write(responseStatusLineBytes, 0, responseStatusLineBytes.Length);
				stream.Write(responseHeadreBytes, 0, responseHeadreBytes.Length);
				stream.Write(new byte[] { 13, 10 }, 0, 2);
				stream.Write(responseBodyBytes, 0, responseBodyBytes.Length);

				client.Close();
				Console.ReadKey();
				break;
			}
			listener.Stop();
		}
	}
}
