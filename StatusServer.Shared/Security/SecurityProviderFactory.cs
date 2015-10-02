using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusServer.Shared.Security
{
	public static class SecurityProviderFactory
	{
		public static SecurityProvider GetProvider(string providerType)
		{
			switch(providerType)
			{
				case "BCrypt" : return new BCryptProvider();
				default: throw new NotImplementedException(string.Format("Security Provider {0} is not implemented", providerType));
            }
		}
	}
}
