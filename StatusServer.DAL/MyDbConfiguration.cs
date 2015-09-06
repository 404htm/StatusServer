using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.DAL
{
	public class MyDbConfiguration : DbConfiguration
	{
		public MyDbConfiguration()
		{
			//var ds = (DataSet)ConfigurationManager.GetSection("system.data");
			//SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
			//SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
			//SetProviderFactory("System.Data.EntityClient")
			
		}
	}
}
