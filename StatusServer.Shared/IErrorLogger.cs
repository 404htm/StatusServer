using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared
{
	public interface IErrorRecorder
	{
        void Log(Exception e, string message);

		void Log(Guid token, Exception e, string message);

		void Log(Exception e, string message, string caller_file_name, string caller_member_name, int line_number);

		void Log(Guid token, Exception e, string message, string caller_file_name, string caller_member_name, int line_number);

		void AddObjectState(Guid token, Object @object, string name, int depth = 1);

		void AddFile(string filename, byte[] data);

	}
}
