using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResponsibleService.Contract;
using System.ServiceModel;

namespace ResponsibleService.LocalService
{
	public class OrderRessponseService : IOrderRessponse
	{
		public void SubmitOrderResponse(Guid orderNo, FaultException exception)
		{
			Console.WriteLine("It's be ");
			if (exception == null) {
				Console.WriteLine("It's successful to process the order!\n\tOrder No.: {0}", orderNo);
			} else {
				Console.WriteLine("It's fail to process the order!\n\tOrder No.: {0}\n\tReason: {1}", orderNo, exception.Message);
			}
			Console.Read();
		}
	}
}
