using System;
using System.Linq;
using System.Text;
using static BCrypt.Net.BCrypt;

namespace StatusServer.Shared.Security
{
	public class BCryptProvider : SecurityProvider
	{
		const int WORK_FACTOR = 8;
		static BCryptProvider()
		{
			ProviderType = "BCrypt";
        }

		public override string GenerateApiPassword()
		{
			return BCrypt.Net.BCrypt.GenerateSalt(WORK_FACTOR).Substring(0, PassLength);
		}

		public override byte[] GenerateSalt()
		{
			var strSalt = BCrypt.Net.BCrypt.GenerateSalt(WORK_FACTOR);
			return Convert.FromBase64String(strSalt);
        }

		public override byte[] HashPassword(string password, byte[] salt)
		{
			var strSalt = Convert.ToBase64String(salt);
			var strHash = BCrypt.Net.BCrypt.HashPassword(password + strSalt, WORK_FACTOR);
			return Convert.FromBase64String(strHash);
        }

		public override bool VerifyPassword(string password, byte[] salt, byte[] hash)
		{
			var compare_hash = HashPassword(password, salt);
			return hash.SequenceEqual(compare_hash);
		}
	}
}