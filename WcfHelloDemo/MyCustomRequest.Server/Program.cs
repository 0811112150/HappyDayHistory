using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyCustomRequest.Channels;
using System.ServiceModel.Channels;
using System.Runtime.Serialization;

namespace MyCustomRequest.Server
{
	class Program
	{
		static void Main(string[] args)
		{
			MyBinding binding = new MyBinding();

			IChannelListener<IReplyChannel> channelListener = binding.BuildChannelListener<IReplyChannel>(
							new Uri("http://127.0.0.1:8888/messagingviabinding"));
			channelListener.Open();

			while (true) {
				IReplyChannel channel = channelListener.AcceptChannel(TimeSpan.MaxValue);
				channel.Open();
				Console.WriteLine("open");

				RequestContext context = channel.ReceiveRequest(TimeSpan.MaxValue);
				Console.WriteLine("Receive a request message:\n{0}", context.RequestMessage);
				Message replayMessage = Message.CreateMessage(MessageVersion.Soap11, "http://artech.messagingviabinding",
					"This is a mannualy created reply message for the purpose of testing");

				context.Reply(replayMessage);
				channel.Close();
			}
		}
	}
}
