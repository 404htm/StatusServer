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
			var el = new Fakes.StubIErrorLogger();
			_logger = new Logger(el);
		}

		[TestMethod]
		public void RecordErrorTest()
		{
			Guid _token = new Guid();
			Exception _ex = null;
			string _message, _file, _method = null;
			int _line = 0;

			var el = new Fakes.StubIErrorLogger
			{
				LogGuidExceptionStringStringStringInt32 = (token, ex, message, file, method, line) =>
				{
					_token = token;
					_ex = ex;
					_message = message;
					_file = file;
					_method = method;
					_line = line;
				}
			};

			var logger = new Logger(el);
			var result = logger.ReportError(new InvalidCastException(), "This is a test message");

			Assert.IsNotNull(_ex);
			Assert.AreNotEqual(_token, new Guid());
			Assert.AreEqual(_method, "RecordErrorTest");
			Assert.AreNotEqual(_line, 0);
			

			Assert.IsNotNull(result, "Error aggregator not created");
		}

		[TestMethod]
		public void RecordObjectTest()
		{
			

			


            var testObj1 = "This is a string";

			var result =
				_logger
				.ReportError(new InvalidCastException(), "This method tests the object writer")
				.IncludeObject("testObj1", testObj1);

			Assert.IsNotNull(result);
		}
	}
}
