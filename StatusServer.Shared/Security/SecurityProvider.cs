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

		public abstract byte[] GenerateSalt();

		public abstract byte[] HashPassword(string password, byte[] salt);

		public abstract bool VerifyPassword(string password, byte[] salt, byte[] hash);

	}
}
