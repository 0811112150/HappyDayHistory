using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human.DomainModel
{
	public class InsuranceFund
	{
		private string _number;
		private string _paymentAddress;

		public int InsuranceFundID { get; set; }
		public int InsuranceFundType { get; set; }

		public string Number
		{
			get { return _number; }
			set { _number = value; }
		}
		public string PaymentAddress
		{
			get { return _paymentAddress; }
			set { _paymentAddress = value; }
		}
		public DateTime? PaymentStartDate { get; set; }
		public DateTime? PaymentEndDate { get; set; }
		public float BasicNum { get; set; }

		public int PeopleID { get; set; }
	}
}
