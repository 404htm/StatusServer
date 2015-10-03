using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace StatusServer.Shared.Tests
{
	/// <summary>
	/// Summary description for BcryptProviderTest
	/// </summary>
	[TestClass]
	public class BcryptProviderTest
	{
		public BcryptProviderTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		[TestMethod]
		public void GenerateApiPassword()
		{
			var sec = new Security.BCryptProvider();
			var pw1 = sec.GenerateApiPassword();
			var pw2 = sec.GenerateApiPassword();

			Assert.IsFalse(pw1.SequenceEqual(pw2));
		}

		[TestMethod]
		public void GenerateSalt()
		{
			var sec = new Security.BCryptProvider();
			var salt1 = sec.GenerateSalt();
			var salt2 = sec.GenerateSalt();

			Assert.IsFalse(salt1 == salt2);
		}

		[TestMethod]
		public void HashPassword()
		{
			var sec = new Security.BCryptProvider();
			var pw = "TEST1234";
			var salt = sec.GenerateSalt();

			var hash = sec.HashPassword(pw, salt);
			Assert.IsTrue(sec.VerifyPassword(pw, salt, hash));
		}

		[TestMethod]
		public void HashPassword2()
		{
			var sec = new Security.BCryptProvider();
			var password = "TEST1234";
            var pwds = new string[]{ "TeST1234", "test1234", "TEST12345", ""};
			var salt = sec.GenerateSalt();

			var stored = sec.HashPassword(password, salt);
			Assert.IsFalse(pwds.Any(p => sec.VerifyPassword(p, salt, stored)));

			Assert.IsTrue(sec.VerifyPassword(password, salt, stored));

		}

	}
}
