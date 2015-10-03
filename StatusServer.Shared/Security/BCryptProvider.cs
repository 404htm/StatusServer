using System;
using System.Linq;
using System.Text;
using static BCrypt.Net.BCrypt;

namespace StatusServer.Shared.Security
{
	public class BCryptProvider : SecurityProvider
	{
		const int WORK_FACTOR = 12;
		static BCryptProvider()
		{
			ProviderType = "BCrypt";
        }

		public override string GenerateApiPassword()
		{
			return BCrypt.Net.BCrypt.GenerateSalt(WORK_FACTOR).Substring(0, PassLength);
		}

		public override string GenerateSalt()
		{
			return BCrypt.Net.BCrypt.GenerateSalt(WORK_FACTOR);
        }

		public override string HashPassword(string password, string salt)
		{
			return BCrypt.Net.BCrypt.HashPassword(Combine(password, salt), WORK_FACTOR);
        }

		public override bool VerifyPassword(string password, string salt, string hash)
		{
			return BCrypt.Net.BCrypt.Verify(Combine(password, salt), hash);
		}

		private string Combine(string password, string salt)
		{
			return String.Concat(password + "|" + salt);
		}
	}
}