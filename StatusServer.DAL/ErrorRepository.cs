using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.DAL
{
	public class ErrorRepository
	{
		public void RecordError(ErrorLog error)
		{
			using (var dc = new DAL.Context())
			{
				dc.ErrorLogs.Add(error);
				dc.SaveChanges();
			}

        }

		public void UpdateError(int Id, ErrorLog error)
		{
			using (var dc = new DAL.Context())
			{
				dc.ErrorLogs.Attach(error);
				dc.Entry(error).State = System.Data.Entity.EntityState.Modified;
				dc.SaveChanges();
			}

		}

		public ErrorLog ReadError(int Id)
		{
			using (var dc = new DAL.Context())
			{
				var result = dc.ErrorLogs.Find(Id);
				return result;
			}
		}

		public void AddErrorDetail(Guid token, ObjectData item)
		{
			using (var dc = new DAL.Context())
			{
				var error = dc.ErrorLogs.Single(e => e.Token == token);
				error.ObjectDatas.Add(item);
				throw new NotImplementedException();
			}

		}
	}
}
