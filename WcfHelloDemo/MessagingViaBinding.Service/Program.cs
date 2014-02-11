using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MessagingViaBinding.Service
{
	class Program
	{
		static void Main(string[] args)
		{
			var address = new Uri("http://localhost:1111/MessageViaBinding");
			var binding = new BasicHttpBinding();

			var channelListener = binding.BuildChannelListener<IReplyChannel>(address);
			channelListener.Open();

			var replayChannel = channelListener.AcceptChannel();
			replayChannel.Open();
			Console.WriteLine("server channel has open~");

			while (true) {
				var requestContext = replayChannel.ReceiveRequest();
				Console.WriteLine("Receive a request message:\n{0}", requestContext.RequestMessage);
				Message message = Message.CreateMessage(MessageVersion.Soap11, "http://MessageViaBinding",
						"This is a mannualy created reply message for the purpose of testing");
				requestContext.Reply(message);
			}
		}
	}
}
