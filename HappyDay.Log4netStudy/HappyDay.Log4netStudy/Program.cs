using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HappyDay.Log4netStudy
{
	class Program
	{
		static void Main(string[] args)
		{
			//log4net.Config.XmlConfigurator.Configure();
			var logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().Name);
			logger.Info("Test");
		}
	}
}
