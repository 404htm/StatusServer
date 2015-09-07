using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared
{
	public interface IErrorRecorder
	{
		void Log(int appId, Exception e, string message);

		void Log(int appId, Guid token, Exception e, string message);

		void Log(int appId, Exception e, string message, string caller_file_name, string caller_member_name, int? line_number);

		void Log(int appId, Guid token, Exception e, string message, string caller_file_name, string caller_member_name, int? line_number);

		void AddObjectState(Guid token, string @object_data, string name, string format);

		void AddFile(Guid token, string filename, byte[] data);

	}
}
