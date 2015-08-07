using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.DAL
{
	public class ErrorRepository
	{
		public void RecordError(Error error)
		{
			using (var dc = new DAL.Context())
			{
				dc.Errors.Add(error);
				dc.SaveChanges();
			}

        }

		public void UpdateError(int Id, Error error)
		{
			using (var dc = new DAL.Context())
			{
				dc.Errors.Attach(error);
				dc.Entry(error).State = System.Data.Entity.EntityState.Modified;
				dc.SaveChanges();
			}

		}

		public Error ReadError(int Id)
		{
			using (var dc = new DAL.Context())
			{
				var result = dc.Errors.Find(Id);
				return result;
			}
		}

		public void AddErrorDetail(Guid token, ObjectState item)
		{
			using (var dc = new DAL.Context())
			{
				var error = dc.Errors.Single(e => e.Token == token);
				error.ObjectStates.Add(item);
				throw new NotImplementedException();
			}

		}
	}
}
