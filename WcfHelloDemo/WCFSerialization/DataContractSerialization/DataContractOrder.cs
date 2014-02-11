using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFSerialization
{
	[DataContract(Name = "Order", Namespace = "zlm")]
	public class DataContractOrder
	{
		private Guid _orderID;
		private DateTime _orderDate;
		private DataContractProduct _product;
		private int _quantity;

		public DataContractOrder()
		{
			this._orderID = new Guid();
			this._orderDate = DateTime.MinValue;
			this._quantity = int.MinValue;

			Console.WriteLine("The constructor of DataContractOrder has been invocated!");
		}

		public DataContractOrder(Guid id, DateTime date, DataContractProduct product, int quantity)
		{
			this._orderID = id;
			this._orderDate = date;
			this._product = product;
			this._quantity = quantity;
		}

		[DataMember(Name = "ID")]
		public Guid OrderID { get { return _orderID; } set { _orderID = value; } }
		[DataMember(Name = "Date")]
		public DateTime OrderDate { get { return _orderDate; } set { _orderDate = value; } }
		[DataMember(Name = "Product")]
		public DataContractProduct Product { get { return _product; } set { _product = value; } }
		[DataMember(Name = "Amount")]
		public int Quantity { get { return _quantity; } set { _quantity = value; } }

		public override string ToString()
		{
			return string.Format("ID: {0}\nDate:{1}\nProduct:\n\tID:{2}\n\tName:{3}\n\tProducing Area:{4}\n\tPrice:{5}\nQuantity:{6}",
				this._orderID, this._orderDate, this._product.ProductID, this._product.ProductName, this._product.ProducingArea, this._product.UnitPrice, this._quantity);
		}
	}
}
