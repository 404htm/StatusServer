using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Client
{
	public class ErrorAggregator
	{
		Guid _token;
		IErrorLogger _logger;

		internal ErrorAggregator(IErrorLogger logger, Guid token)
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
