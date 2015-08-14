using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatusServer.Shared.Tests
{
	[TestClass]
	public class LoggerTests
	{

		Logger _logger;

		[TestInitialize]
		public void Initialize()
		{
			_logger = new Logger();
		}

		[TestMethod]
		public void LoggerCreationTest()
		{
			
		}

		[TestMethod]
		public void RecordErrorTest()
		{
			var result = _logger.ReportError(new InvalidCastException(), "This is a test message");
			Assert.IsNotNull(result, "Error aggregator not created");
		}
	}
}
