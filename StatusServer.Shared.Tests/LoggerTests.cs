using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatusServer.Shared.Tests
{
	[TestClass]
	public class LoggerTests
	{

		[TestInitialize]
		public void Initialize()
		{
			
		}

		[TestMethod]
		public void ConstructorTest()
		{
			var el = new Fakes.StubIErrorRecorder();
			var logger = new Logger(el);
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
				LogGuidExceptionStringStringStringNullableOfInt32 = (token, ex, message, file, method, line) =>
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
				LogGuidExceptionStringStringStringNullableOfInt32 = (token, ex, message, file, method, line) =>
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

			var logger = new Logger(el);


			var testobj1 = "This is a string";

			var result =
				logger
				.ReportError(new InvalidCastException(), "This method tests the object writer")
				.IncludeObject("testObj1", testobj1);

			Assert.AreNotEqual(_token1, new Guid());
			Assert.AreEqual(_token1, _token2);
			Assert.AreEqual("testObj1", testobj1);
			Assert.IsNotNull(_obj);
			Assert.IsNotNull(result, "Error aggregator not created");
		}
	}
}
