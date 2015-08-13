using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Client
{
    public class Logger
    {
		private IErrorLogger ErrorLoggerFactory()
		{
			return null;
		}
		
		public ErrorAggregator ReportError
		(Exception ex, string message,
		[CallerMemberName] string memberName = null,
		[CallerFilePath] string filePath = null,
		[CallerLineNumber] int lineNumber = 0)
		{
			IErrorLogger logger = null;
			var token = Guid.NewGuid();
			logger.Log(token, ex, message, filePath, lineNumber);

			return new ErrorAggregator(logger, token);
		}

		public void Assert()
		{
			
		}
	
		
    }
}
