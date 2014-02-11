using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFSerialization
{
	public class XmlOrder
	{
		private Guid _orderID;
		private DateTime _orderDate;
		private XmlProduct _product;
		private int _quantity;

		public XmlOrder()
		{
			this._orderID = new Guid();
			this._orderDate = DateTime.MinValue;
			this._quantity = int.MinValue;

			Console.WriteLine("The constructor of DataContractOrder has been invocated!");
		}

		public XmlOrder(Guid id, DateTime date, XmlProduct product, int quantity)
		{
			this._orderID = id;
			this._orderDate = date;
			this._product = product;
			this._quantity = quantity;
		}

		public Guid OrderID { get { return _orderID; } set { _orderID = value; } }
		public DateTime OrderDate { get { return _orderDate; } set { _orderDate = value; } }
		public XmlProduct Product { get { return _product; } set { _product = value; } }
		public int Quantity { get { return _quantity; } set { _quantity = value; } }

		public override string ToString()
		{
			return string.Format("ID: {0}\nDate:{1}\nProduct:\n\tID:{2}\n\tName:{3}\n\tProducing Area:{4}\n\tPrice:{5}\nQuantity:{6}",
				this._orderID, this._orderDate, this._product.ProductID, this._product.ProductName, this._product.ProducingArea, this._product.UnitPrice, this._quantity);
		}
	}
}
