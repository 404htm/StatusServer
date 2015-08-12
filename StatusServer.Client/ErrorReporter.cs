using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Client
{
	public class ErrorReporter
	{
		Guid _token;
		DateTime _date;

		internal ErrorReporter(ErrorLogger logger)
		{
			_token = Guid.NewGuid();
			_date = DateTime.UtcNow;
		}

		public ErrorReporter AddNote(string note, object[] args)
		{
			return this;
		}

		public ErrorReporter IncludeObject(string variableName, Object @object, int depths = 0, string description = null)
		{

			return this;
		}

		public ErrorReporter IncludeFile(string filename, string description = null)
		{
			return this;
		}

		public ErrorReporter IncludeSQL()
		{
			return this;

		}
	}
}
