using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatusServer.DAL.Tests
{
	[TestClass]
	public class DBErrorRecorderTests
	{
		const int TEST_APPLICATION = 1;

		[TestMethod]
		public void GetContext()
		{
			var context = ContextFactory.GetContext();
			Assert.IsNotNull(context);
		}

		[TestMethod]
		public void Log_exception_message()
		{ 
			var logger = new DBErrorRecorder();
			var token = Guid.NewGuid();

			logger.Log(TEST_APPLICATION, token, new InvalidCastException(), "Test Exception");


		}
	}
}
