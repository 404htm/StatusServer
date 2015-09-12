using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;


namespace StatusServer.Shared.Helpers
{
	
	internal static class ObjectMapper
	{
		public static string ToJsonString(Object obj, int depth)
		{
			var settings = new JsonSerializerSettings { MaxDepth = depth };
			return JsonConvert.SerializeObject(obj, Formatting.Indented, settings);
		}



	}
}
