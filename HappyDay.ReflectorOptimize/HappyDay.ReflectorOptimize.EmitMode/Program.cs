using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using HappyDay.ReflectorOptimize.ModelClass;
using System.Diagnostics;

namespace HappyDay.ReflectorOptimize.EmitMode
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Student stu = new Student();
			int count = 1000000;
			var type = stu.GetType();
			var property = type.GetProperty("Name");

			var stopWatch1 = Stopwatch.StartNew();
			for (int i = 0; i < count; i++) {
				stu.Name = "zhang";
			}
			stopWatch1.Stop();
			Console.WriteLine(stopWatch1.Elapsed.ToString());

			var method = DynamicMethodFactory.CreatePropertySetter(property);
			var stopWatch2 = Stopwatch.StartNew();
			for (int i = 0; i < count; i++) {
				method.Invoke(stu, "Name");
			}
			stopWatch2.Stop();
			Console.WriteLine(stopWatch2.Elapsed.ToString());

			var stopWatch3 = Stopwatch.StartNew();
			for (int i = 0; i < count; i++) {
				property.SetValue(stu, "Name", null);
			}
			stopWatch3.Stop();
			Console.WriteLine(stopWatch3.Elapsed.ToString());
			

			PropertyAccesstorFactory.SetValue(stu, property, "zhang");
			var stopWatch4 = Stopwatch.StartNew();
			for (int i = 0; i < count; i++) {
				PropertyAccesstorFactory.SetValue(stu, property, "zhang");
			}
			stopWatch4.Stop();
			Console.WriteLine(stopWatch4.Elapsed.ToString());


			Console.WriteLine(stu.Name);
			Console.ReadLine();
		}
	}
}
