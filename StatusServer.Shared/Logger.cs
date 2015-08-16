using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared
{
    public class Logger
    {
		IErrorRecorder _error_logger;
		public Logger(IErrorRecorder errorLogger)
		{
			//This constructor is temporary
			_error_logger = errorLogger;
		}
		
		public ErrorAggregator ReportError
		(Exception ex, string message,
		[CallerMemberName] string memberName = null,
		[CallerFilePath] string filePath = null,
		[CallerLineNumber] int lineNumber = 0)
		{
			var token = Guid.NewGuid();
			_error_logger.Log(token, ex, message, filePath, memberName, lineNumber);
			return new ErrorAggregator(_error_logger, token);
		}

		public void Assert()
		{
			
		}
	
		
    }
}
