using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared.Security
{
	public abstract class SecurityProvider
	{
		protected int SaltLength = 60;
		protected int PassLength = 10;

		public static string ProviderType { get; protected set; }

		public abstract string GenerateApiPassword();

		public abstract string GenerateSalt();

		public abstract string HashPassword(string password, string salt);

		public abstract bool VerifyPassword(string password, string salt, string hash);

	}
}
