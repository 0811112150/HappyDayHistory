using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SocketCodeStudy.QQClass
{
	public class SerializerHelper
	{
		//将实体装换位Byte
		public static byte[] ConvertObjectToBytes<T>(T source)
		{
			var messageStream = new MemoryStream();
			new XmlSerializer(typeof(T)).Serialize(messageStream, source);
			return messageStream.ToArray();
		}
		//将Byte转换为实体
		public static T ConvertBytesToObject<T>(byte[] source)
		{
			var stream = new MemoryStream(source);
			return (T)new XmlSerializer(typeof(T)).Deserialize(stream);
		}
	}
}
