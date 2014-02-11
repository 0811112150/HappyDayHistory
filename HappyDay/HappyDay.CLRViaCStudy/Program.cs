using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace HappyDay.CLRViaCStudy
{
	public class StatistcTest
	{

		private static int _t = 1;

		private static int _tt = 10;

		static StatistcTest()
		{

		}

		public static int T
		{
			get
			{
				return _t;
			}
			set
			{
				_t = value;
			}
		}
	}


	public class StatistcTest2
	{
		public static int B = 1;

		static StatistcTest2() { }
	}

	class Program
	{
		//public delegate void Test(int value);

		static void Main(string[] args)
		{
			#region
			//char s = '1';
			//Environment.NewLine
			//Char..GetUnicodeCategory()
			//var s = "s" + Environment.NewLine + "";
			//string.Compare("",StringComparison.)
			//String.Intern()
			//string.IsInterned()
			//var s1 = "hello";
			//var s2 = "hello";
			//var result = object.ReferenceEquals(s1, s2);
			//Console.WriteLine(result);

			//var t1 = new string('s', 5);
			//var t2 = new string('s', 5);
			//result = object.ReferenceEquals(t1, t2);
			//Console.WriteLine(result);

			//StringInfo strInfo = new StringInfo("");
			//StringInfo.GetTextElementEnumerator()

			//var strBuilder = new StringBuilder("123", 10);
			//strBuilder.Append("456");
			//strBuilder.Append("789");
			//var old = strBuilder;
			//strBuilder.Append("1011");
			//var test=new Test();


			//var sb = new StringBuilder();
			//var provider = new BoldInt32s();
			//sb.AppendFormat(provider, "{0} {1} {2:M}", "zhang", 123, DateTime.Now);

			//var array = Array.CreateInstance(typeof(double), new int[] { 2, 2 }, new int[] { 2000, 3000 });
			//Console.WriteLine(array);
			//Console.ReadKey();
			//Method3();

			//var timer = new Timer(TimerCallBack, null, 0, 2000);

			//Console.ReadLine();

			//var s = new Test(1);

			////System.Runtime.Remoting.RemotingServices.IsTransparentProxy()

			//Thread.GetDomain().FirstChanceException += Program_FirstChanceException;
			//try {
			//	throw new Exception() { };

			//} catch (Exception) {

			//}

			//Assembly.GetExecutingAssembly().GetExportedTypes
			//Activator.CreateInstanceFrom
			//Activator.CreateInstance
			//AppDomain.CurrentDomain.CreateInstanceAndUnwrap

			//var test = new Test();
			//var type = typeof(Test);
			//var methods = type.GetMethods();
			//foreach (var method in methods) {
			//	Console.WriteLine(method.Name + "  " + method.DeclaringType);
			//}
			//Console.ReadLine();

			//System.Runtime.Serialization.OptionalFieldAttribute

			//var cts = new CancellationTokenSource();
			//ThreadPool.QueueUserWorkItem(o => Count(cts.Token, 1000));

			//Thread.Sleep(1000);
			//Console.WriteLine("Press ENTER to stop");
			//Console.ReadLine();
			//cts.Cancel();
			//Console.ReadLine();
			//var task = new Task(Count);
			//task.Start();
			////task.ContinueWith()
			//TaskContinuationOptions
			//TaskFactory<>
			#endregion

			Console.WriteLine(StatistcTest.T);
			Console.WriteLine(StatistcTest2.B);
		}

		private static void Count(CancellationToken token, int countTo)
		{
			for (int i = 0; i < countTo; i++) {
				if (token.IsCancellationRequested) {
					Console.WriteLine("token.IsCancellationRequested Called");
					break;
				}
				Console.WriteLine(i);
				Thread.Sleep(200);
			}
		}



		private static void Program_FirstChanceException(object sender, FirstChanceExceptionEventArgs args)
		{

		}

		private static void TimerCallBack(object o)
		{
			Console.WriteLine(DateTime.Now.ToString());

			GC.Collect();
		}

		private static void Method1()
		{
			try {
				throw new Exception();
			} catch (System.MissingFieldException ex) {
				throw new Exception();
			} finally {

			}
			Console.WriteLine("1");
		}

		private static void Method2()
		{
			try {
				Method1();
			} catch (System.MissingFieldException ex) {
				throw new Exception();
			} finally {

			}
			Console.WriteLine("2");
		}

		private static void Method3()
		{
			try {
				Method2();
			} catch (System.Exception ex) {
			} finally {

			}
			Console.WriteLine("3");
		}

		//class BoldInt32s : IFormatProvider, ICustomFormatter
		//{
		#region IFormatProvider 成员

		public object GetFormat(Type formatType)
		{
			if (formatType == typeof(ICustomFormatter)) {
				return this;
			} else {
				return Thread.CurrentThread.CurrentCulture.GetFormat(formatType);
			}
		}

		#endregion

		//#region ICustomFormatter 成员

		//public string Format(string format, object arg, IFormatProvider formatProvider)
		//{
		//	string s;
		//	var formattable = arg as IFormattable;
		//	if (formattable == null) {
		//		s = arg.ToString();
		//	} else {
		//		s = formattable.ToString(format, formatProvider);
		//	}

		//	if (arg.GetType() == typeof(Int32)) {
		//		return "<B>" + s + "</B>";
		//	}
		//	return s;
		//}

		//#endregion
		//}

		//class Formater : ICustomFormatter
		//{
		//	#region ICustomFormatter 成员

		//	public string Format(string format, object arg, IFormatProvider formatProvider)
		//	{
		//		string s;
		//		var formattable = arg as IFormattable;
		//		if (formattable == null) {
		//			s = arg.ToString();
		//		} else {
		//			s = formattable.ToString(format, formatProvider);
		//		}

		//		if (arg.GetType() == typeof(Int32)) {
		//			return "<B>" + s + "</B>";
		//		}
		//		return s;
		//	}

		//	#endregion
		//}

		public class Test
		{
			public Test(int s)
			{

			}

			public Test()
			{

			}

			public void DoSomething()
			{
			}
			//public override string ToString()
			//{
			//	return "123";
			//}
		}
	}
}
