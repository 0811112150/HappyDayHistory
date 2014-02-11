using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ResponsibleService.Contract
{
	[DataContract]
	public class Order
	{
		private Guid _orderNo;
		private DateTime _orderDate;
		private Guid _supplierID;
		private string _supplierName;

		public Order(Guid orderNo, DateTime orderDate, Guid supplierID, string supplierName)
		{
			this._orderNo = orderNo;
			this._orderDate = orderDate;
			this._supplierID = supplierID;
			this._supplierName = supplierName;
		}

		[DataMember]
		public Guid OrderNo
		{
			get { return _orderNo; }
			set { _orderNo = value; }
		}

		[DataMember]
		public DateTime OrderDate
		{
			get { return _orderDate; }
			set { _orderDate = value; }
		}

		[DataMember]
		public Guid SupplierID
		{
			get { return _supplierID; }
			set { _supplierID = value; }
		}

		[DataMember]
		public string SupplierName
		{
			get { return _supplierName; }
			set { _supplierName = value; }
		}

		public override string ToString()
		{
			string description = string.Format("Order No.\t: {0}\n\tOrder Date\t: {1}\n\tSupplier No.\t: {2}\n\tSupplier Name\t: {3}",
				this._orderNo, this._orderDate.ToString("yyyy/MM/dd"), this._supplierID, this._supplierName);
			return description;
		}
	}
}
