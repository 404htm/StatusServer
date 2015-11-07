using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StatusServer.Web.Identity
{
	public class AppIdentityUser
	{
		public Guid Id { get; set; }

		public string UserName { get; set; }

		public bool IsAPIUser { get; set; }

		private void SetupClaims(int appId)
		{
			
		}

	}
}
