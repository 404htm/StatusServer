using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared
{
	public class PasswordUtils
	{
		const int BCRYPT_WORK_FACTOR = 8;

		public string GenerateAPIPassword() {
			return BCrypt.Net.BCrypt.GenerateSalt(BCRYPT_WORK_FACTOR);
		}

		public byte[] GenerateSalt()
		{
			return BCrypt.Net.BCrypt.GenerateSalt(BCRYPT_WORK_FACTOR);
		}

		public byte[] Hash

	}
}
