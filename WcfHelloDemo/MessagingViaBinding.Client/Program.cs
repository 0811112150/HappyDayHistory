using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace MessagingViaBinding.Client
{
	class Program
	{
		static void Main(string[] args)
		{
			EndpointAddress address = new EndpointAddress("http://localhost:1111/MessageViaBinding");
			var binding = new BasicHttpBinding();

			var channelFactory = binding.BuildChannelFactory<IRequestChannel>();
			channelFactory.Open();

			var channel = channelFactory.CreateChannel(address);
			channel.Open();

			var message = Message.CreateMessage(MessageVersion.Soap11, "http://MessageViaBinding", "The is a request message manually created for the purpose of testing.");
			Message replayMessage=channel.Request(message);
			
			Console.WriteLine("Receive a reply message:\n{0}", replayMessage);
			channel.Close();
			channelFactory.Close();
			Console.ReadLine();
		}
	}
}
