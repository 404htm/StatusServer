using StatusServer.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.DAL
{
	public class DBErrorRecorder : IErrorRecorder
	{
		internal DBErrorRecorder()
		{
			
		}

		public void AddFile(Guid token, string filename, byte[] data)
		{
			using (var dc = ContextFactory.GetContext())
			{
			
			}
		}

		public void AddObjectState(Guid token, string object_data, string name, string format)
		{
			using (var dc = ContextFactory.GetContext())
			{
				//TODO: Instance Name
				var obj = new ObjectState() { ClassName = name, Data = object_data, Format = format };
				dc.Errors.Single(e => e.Token == token).ObjectStates.Add(obj);
				dc.SaveChanges();
			}
		}

		public void Log(Exception e, string message)
		{
			Log(Guid.NewGuid(), e, message, null, null, null);
		}

		public void Log(Guid token, Exception e, string message)
		{
			Log(token, e, message, null, null, null);
		}

		public void Log(Exception e, string message, string caller_file_name, string caller_member_name, int? line_number)
		{
			Log(Guid.NewGuid(), e, message, caller_file_name, caller_member_name, line_number);
		}

		public void Log(Guid token, Exception e, string message, string caller_file_name, string caller_member_name, int? line_number)
		{
			using (var dc = ContextFactory.GetContext())
			{
				var error = new Error();
				error.Token = token;
				error.ExceptionDetail = e.ToString();
				error.Message = message;
				//error.File
				//error.Module = caller_file_name;
				error.LineNumber = line_number;

				dc.Errors.Add(error);
				dc.SaveChanges();
            }
		}
	}
}
