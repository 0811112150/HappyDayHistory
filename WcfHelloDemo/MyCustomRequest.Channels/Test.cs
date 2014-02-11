using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;

namespace MyCustomRequest.Channels
{
	class Test
	{
		public Test()
		{
			var class1 = new ClassTest2();
			(class1 as InterfaceTest1).Get();
		}
	}

	interface InterfaceTest1
	{
		void Get();
	}

	class ClassTest1 : InterfaceTest1
	{

		public void Get()
		{
			throw new NotImplementedException();
		}
	}

	class ClassTest2 : InterfaceTest1
	{

		void InterfaceTest1.Get()
		{
			throw new NotImplementedException();
		}
	}
}
