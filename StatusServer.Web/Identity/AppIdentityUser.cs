using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatusServer.Web.Identity
{
	public class AppIdentityUser
	{
		public string Id { get; set; }

		public string UserName { get; set; }
	}
}
