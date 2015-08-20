using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatusServer.DAL.Tests
{
	[TestClass]
	public class DBErrorRecorderTests
	{
		[TestMethod]
		public void Log_exception_message()
		{
			var logger = new DBErrorRecorder();
			var token = Guid.NewGuid();

			logger.Log(token, new InvalidCastException(), "Test Exception");


		}
	}
}
