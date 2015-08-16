using StatusServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.DAL
{
	public class DBErrorLogger : IErrorRecorder
	{
		public void AddFile(string filename, byte[] data)
		{
			throw new NotImplementedException();
		}

		public void AddObjectState(Guid token, object @object, string name, int depth = 1)
		{
			throw new NotImplementedException();
		}

		public void Log(Exception e, string message)
		{
			throw new NotImplementedException();
		}

		public void Log(Guid token, Exception e, string message)
		{
			throw new NotImplementedException();
		}

		public void Log(Exception e, string message, string caller_file_name, string caller_member_name, int line_number)
		{
			throw new NotImplementedException();
		}

		public void Log(Guid token, Exception e, string message, string caller_file_name, string caller_member_name, int line_number)
		{
			throw new NotImplementedException();
		}
	}
}
