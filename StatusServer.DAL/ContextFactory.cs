using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.DAL
{
	internal class ContextFactory
	{
		public static DAL.Context GetContext() {
			var cnn = ConfigurationManager.ConnectionStrings["StatusServerEF"]?.ConnectionString;
			if (cnn == null) return null;
			else return new DAL.Context(cnn);
		}
	}
}
