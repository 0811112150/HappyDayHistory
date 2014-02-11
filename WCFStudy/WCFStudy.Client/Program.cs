using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFStudy.Client.CalculatorService;
using System.ServiceModel;
using WCFStudy.Services;
using WCFStudy.Contracts;

namespace WCFStudy.Client
{
	class Program
	{
		//static void Main(string[] args)
		//{
		//    using (CalculatorServiceClient client = new CalculatorServiceClient()) {
		//        Console.WriteLine("x + y = {2} when x = {0} and y = {1}", 1, 2, client.Add(1, 2));
		//        Console.WriteLine("x - y = {2} when x = {0} and y = {1}", 1, 2, client.Subtract(1, 2));
		//        Console.WriteLine("x * y = {2} when x = {0} and y = {1}", 1, 2, client.Multiply(1, 2));
		//        Console.WriteLine("x / y = {2} when x = {0} and y = {1}", 1, 2, client.Divide(1, 2));
		//        Console.Read();
		//    }
		//}

		static void Main(string[] args)
		{
			using (ChannelFactory<ICalculator> ChannelFactory = new ChannelFactory<ICalculator>("calculatorservice")) {
				ICalculator cal = ChannelFactory.CreateChannel();
				using (cal as IDisposable) {
					Console.WriteLine("x + y = {2} when x = {0} and y = {1}", 1, 2, cal.Add(1, 2));
					Console.WriteLine("x - y = {2} when x = {0} and y = {1}", 1, 2, cal.Subtract(1, 2));
					Console.WriteLine("x * y = {2} when x = {0} and y = {1}", 1, 2, cal.Multiply(1, 2));
					Console.WriteLine("x / y = {2} when x = {0} and y = {1}", 1, 2, cal.Divide(1, 2));
					Console.Read();
				}
			}

		}
	}
}
