using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFSerialization
{
	public class XmlProduct
	{
		private Guid _productID;
		private string _productName;
		private string _producingArea;
		private double _unitPrice;

		public XmlProduct()
		{
			Console.WriteLine("The constructor of DataContractProduct has been invocated!");
		}

		public XmlProduct(Guid id, string name, string producingArea, double price)
		{
			this._productID = id;
			this._productName = name;
			this._producingArea = producingArea;
			this._unitPrice = price;
		}

		public Guid ProductID { get { return _productID; } set { _productID = value; } }
		public string ProductName { get { return _productName; } set { _productName = value; } }
		public string ProducingArea { get { return _producingArea; } set { _producingArea = value; } }
		public double UnitPrice { get { return _unitPrice; } set { _unitPrice = value; } }
	}
}
