using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatusServer.Shared.Helpers;
using System.Text;

namespace StatusServer.Shared.Tests.Helpers
{
	[TestClass]
	public class ObjectMapperTests
	{
		[TestMethod]
		public void ToJsonString()
		{
			var test = new { prop_str = "mystring", prop_int= 42, prop_dateTime = new DateTime(2015, 1, 1), prop_complex = new StringBuilder() };
			var result = ObjectMapper.ToJsonString(test, 1);

			Assert.IsTrue(result.Contains("\"prop_str\":\"mystring\""));
			Assert.IsTrue(result.Contains("\"prop_int\":42"));
		}
	}
}
