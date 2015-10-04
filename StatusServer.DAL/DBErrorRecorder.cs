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
				var obj = new ObjectData() { ClassName = name, Data = object_data, Format = format };
				dc.ErrorLogs.Single(e => e.Token == token).ObjectDatas.Add(obj);
				dc.SaveChanges();
			}
		}

		public void Log(int appId, Exception e, string message)
		{
			Log(appId, Guid.NewGuid(), e, message, null, null, null);
		}

		public void Log(int appId, Guid token, Exception e, string message)
		{
			Log(appId, token, e, message, null, null, null);
		}

		public void Log(int appId, Exception e, string message, string caller_file_name, string caller_member_name, int? line_number)
		{
			Log(appId, Guid.NewGuid(), e, message, caller_file_name, caller_member_name, line_number);
		}

		public void Log(int appId, Guid token, Exception e, string message, string caller_file_name, string caller_member_name, int? line_number)
		{
			using (var dc = ContextFactory.GetContext())
			{
				var error = new ErrorLog();
				//error.ApplicationId = appId;
				error.Time = DateTime.UtcNow;
				error.Token = token;
				error.ExceptionDetail = e.ToString();
				error.Message = message;
				//error.File
				//error.Module = caller_file_name;
				error.LineNumber = line_number;

				dc.ErrorLogs.Add(error);
				dc.SaveChanges();
            }
		}
	}
}
