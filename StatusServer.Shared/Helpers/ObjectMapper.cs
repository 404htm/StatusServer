using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;


namespace StatusServer.Shared.Helpers
{
	
	internal static class ObjectMapper
	{
		public static string ToJsonString(Object obj, int depth)
		{
			var jss = new JavaScriptSerializer();
			jss.RecursionLimit = depth;
			return jss.Serialize(obj);
		}


	}
}
