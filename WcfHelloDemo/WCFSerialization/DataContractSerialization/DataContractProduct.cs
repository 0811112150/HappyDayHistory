using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFSerialization
{
	[DataContract]
	[KnownType(typeof(XmlProduct))]
	public class DataContractProduct
	{
		private Guid _productID;
		private string _productName;
		private string _producingArea;
		private double _unitPrice;

		public DataContractProduct()
		{
			Console.WriteLine("The constructor of DataContractProduct has been invocated!");
		}

		public DataContractProduct(Guid id, string name, string producingArea, double price)
		{
			this._productID = id;
			this._productName = name;
			this._producingArea = producingArea;
			this._unitPrice = price;
		}

		[DataMember]
		public Guid ProductID { get { return _productID; } set { _productID = value; } }

		[DataMember]
		public string ProductName { get { return _productName; } set { _productName = value; } }

		[DataMember]
		public string ProducingArea { get { return _producingArea; } set { _producingArea = value; } }

		[DataMember]
		public double UnitPrice { get { return _unitPrice; } set { _unitPrice = value; } }
	}
}
