using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatusServer.Shared.Tests
{
	[TestClass]
	public class LoggerTests
	{
		const int TEST_APPLICATION = 1;

		[TestInitialize]
		public void Initialize()
		{
			
		}

		[TestMethod]
		public void ConstructorTest()
		{
			var el = new Fakes.StubIErrorRecorder();
			var logger = new Logger(el, TEST_APPLICATION);
		}

		[TestMethod]
		public void RecordErrorTest()
		{
			Guid _token = new Guid();
			Exception _ex = null;
			string _message, _file, _method = null;
			int? _line = null;

			var el = new Fakes.StubIErrorRecorder
			{
				LogInt32GuidExceptionStringStringStringNullableOfInt32= (appId, token, ex, message, file, method, line) =>
				{
					_token = token;
					_ex = ex;
					_message = message;
					_file = file;
					_method = method;
					_line = line;
				}
			};

			var logger = new Logger(el, TEST_APPLICATION);
			var result = logger.ReportError(new InvalidCastException(), "This is a test message");

			Assert.IsNotNull(result, "Error aggregator not created");
			Assert.IsNotNull(_ex);
			Assert.AreNotEqual(_token, new Guid());
			Assert.AreEqual(_method, "RecordErrorTest");
			Assert.AreNotEqual(_line, null);
		}

		[TestMethod]
		public void RecordObjectTest()
		{
			Guid _token1 = new Guid(), _token2 = new Guid();
			Object _obj = null;
			string _name = null;


			var el = new Fakes.StubIErrorRecorder
			{
				LogInt32GuidExceptionStringStringStringNullableOfInt32 = (appId, token, ex, message, file, method, line) =>
				{
					_token1 = token;
				},
				AddObjectStateGuidStringStringString= (token, obj, name, format)  =>
				{
					_token2 = token;
					_obj = obj;
					_name = name;
				}
			};

			var logger = new Logger(el, TEST_APPLICATION);


			var testobj1 = "This is a string";

			var result =
				logger
				.ReportError(new InvalidCastException(), "This method tests the object writer")
				.IncludeObject("testObj1", testobj1);

			Assert.AreNotEqual(_token1, new Guid(), "Token ID was not recorded correctly");
			Assert.AreEqual(_token1, _token2, "Token ID did not match original report");
			Assert.AreEqual(testobj1, _obj, "Object does not match");
			Assert.IsNotNull(result, "Error aggregator not created");
		}
	}
}
