using System.Security.Cryptography;

namespace UNiDAYS.Testing
{
	public abstract class WithKeySpecification : Specification
	{
		protected byte[] key;

		protected override void Given()
		{
			this.key = new byte[128];
			using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
				cryptoServiceProvider.GetBytes(this.key);
		}
	}
}