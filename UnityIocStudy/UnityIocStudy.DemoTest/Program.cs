using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;
using Ninject;
using Ninject.Planning.Bindings;

namespace UnityIocStudy.DemoTest
{
	class Program
	{
		static void Main(string[] args)
		{
			NinjectIoc();
		}

		static private void ConfigIoc()
		{
			IUnityContainer container = new UnityContainer();

			var section = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
			container.LoadConfiguration(section, "FirstClass");

			//解析默认对象
			IClass cbClass = container.Resolve<IClass>();
			cbClass.ShowInfo();

			//指定命名解析对象
			IClass ecClass = container.Resolve<IClass>("ec");
			ecClass.ShowInfo();

			//获取容器中所有IClass的注册的已命名对象
			IEnumerable<IClass> classList = container.ResolveAll<IClass>();
			foreach (var item in classList) {
				item.ShowInfo();
			}

			Console.ReadKey();
		}

		static private void CodeIoc()
		{
			IUnityContainer container = new UnityContainer();

			container.RegisterType<IClass, CbClass>();

			container.RegisterType<IClass, EcClass>("ec");

			IClass ecClass = container.Resolve<IClass>("ec");
			ecClass.ShowInfo();

			IClass dcClass = container.Resolve<IClass>();
			dcClass.ShowInfo();

			IEnumerable<IClass> classList = container.ResolveAll<IClass>();
			foreach (var item in classList) {
				item.ShowInfo();
			}

			Console.ReadKey();
		}

		static private void NinjectIoc()
		{
			var kernel = new StandardKernel();

			kernel.Bind<IClass>().To<EcClass>();
			kernel.Bind<IClass>().To<CbClass>();

			var ecClass = kernel.Get<IClass>();
			ecClass.ShowInfo();
		}
	}
}
