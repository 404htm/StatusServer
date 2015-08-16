using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared
{
	public class ErrorAggregator
	{
		Guid _token;
		IErrorRecorder _logger;

		internal ErrorAggregator(IErrorRecorder logger, Guid token)
		{
			_token = token;
			_logger = logger;
		}

		public ErrorAggregator AddNote(string note, object[] args)
		{
			return this;
		}

		public ErrorAggregator IncludeObject(string variableName, Object @object, int depths = 0, string description = null)
		{

			return this;
		}

		public ErrorAggregator IncludeFile(string filename, string description = null)
		{
			return this;
		}

		public ErrorAggregator IncludeSQL()
		{
			return this;

		}


	}
}
