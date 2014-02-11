using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;

namespace WCFSerialization
{
	class Program
	{
		static void Main(string[] args)
		{
			//DataContractToXmlSerialization();
			//DataContractReadFromXml();

			XmlToXmlSerialization();
			XmlReadFromXml();
		}

		#region DataContractSerialization
		private static void DataContractToXmlSerialization()
		{
			var product = new DataContractProduct(Guid.NewGuid(), "productTestName", "china", 10.25);
			var order = new DataContractOrder(Guid.NewGuid(), DateTime.Now, product, 10);

			var baseDir = AppDomain.CurrentDomain.BaseDirectory;
			var fileName = "../xml.xml";
			var fullFileName = Path.Combine(baseDir, fileName);

			using (var stream = new FileStream(fullFileName, FileMode.Create)) {
				var serializationTool = new DataContractSerializer(typeof(XmlOrder));
				using (var writer = XmlDictionaryWriter.CreateTextWriter(stream)) {
					serializationTool.WriteObject(writer, order);
				}
				Process.Start(fullFileName);
			}
		}

		private static void DataContractReadFromXml()
		{
			var baseDir = AppDomain.CurrentDomain.BaseDirectory;
			var fileName = "../xml.xml";
			var fullFileName = Path.Combine(baseDir, fileName);
			DataContractOrder order;

			using (var stream = new FileStream(fullFileName, FileMode.Open)) {
				using (var reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas())) {
					var serializationTool = new DataContractSerializer(typeof(DataContractOrder));
					order = serializationTool.ReadObject(reader) as DataContractOrder;

				}
			}
			Console.WriteLine(order.ToString());
			Console.Read();
		}
		#endregion

		#region XmlSerialization
		private static void XmlToXmlSerialization()
		{
			var product = new XmlProduct(Guid.NewGuid(), "productTestName", "china", 10.25);
			var order = new XmlOrder(Guid.NewGuid(), DateTime.Now, product, 10);

			var baseDir = AppDomain.CurrentDomain.BaseDirectory;
			var fileName = "../xml.xml";
			var fullFileName = Path.Combine(baseDir, fileName);

			using (var stream = new FileStream(fullFileName, FileMode.Create)) {
				var serializationTool = new XmlSerializer(typeof(XmlOrder));
				using (var writer = XmlDictionaryWriter.CreateTextWriter(stream)) {
					serializationTool.Serialize(writer, order);
				}
				Process.Start(fullFileName);
			}
		}

		private static void XmlReadFromXml()
		{
			var baseDir = AppDomain.CurrentDomain.BaseDirectory;
			var fileName = "../xml.xml";
			var fullFileName = Path.Combine(baseDir, fileName);
			XmlOrder order;

			using (var stream = new FileStream(fullFileName, FileMode.Open)) {
				using (var reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas())) {
					var serializationTool = new XmlSerializer(typeof(XmlOrder));
					order = serializationTool.Deserialize(reader) as XmlOrder;

				}
			}
			Console.WriteLine(order.ToString());
			Console.Read();
		}
		#endregion
	}
}
