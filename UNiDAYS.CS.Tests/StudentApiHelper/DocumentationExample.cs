using System;
using NUnit.Framework;
using UNiDAYS.Testing.NUnit;

namespace UNiDAYS.CS.Tests.StudentApiHelper
{
	[TestFixture]
	public class DocumentationExample
	{
		[Test]
		public void FullExample()
		{
			// Your key as provided by UNiDAYS
			const string unidaysSigningKey = @"tnFUmqDkq1w9eT65hF9okxL1On+d2BQWUyOFLYE3FTOwHjmnt5Sh/sxMA3/i0od3pV5EBfSAmXo//fjIdAE3cIAatX7ZZqVi0Dr8qEYGtku+ZRVbPSmTcEUTA/gXYo3KyL2JqXaZ/qhUvCMbLWyV07qRiFOjyLdOWhioHlJM5io=";
			// Turn key into a byte array
			var key = Convert.FromBase64String(unidaysSigningKey);

			// Obtain parameters from the query string. Be sure to URL Decode them
			var ud_s = "Do/faqh330SGgCnn4t3X4g==";
			var ud_t = 1395741712;
			var ud_h = "i38dJdX+XLKuE4F5tv+Knpl5NPtu5zrdsjnqBQliJEJE4NkMmfurVnUaT46WluRYoD1/f5spAqU36YgeTMCNeg==";

			var timestamp = UNiDAYS.StudentApiHelper.ParseTimestamp(ud_t);

			var studentApiHelper = new UNiDAYS.StudentApiHelper(key);
			var verified = studentApiHelper.VerifyHash(ud_s, timestamp, ud_h);
			verified.ShouldBeTrue();
		}
	}
}