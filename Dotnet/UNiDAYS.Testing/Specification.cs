using System;
using NUnit.Framework;

namespace UNiDAYS.Testing
{
	[TestFixture]
	public abstract class Specification
	{
		Type expectedExceptionType;
		Exception thrownException;

		[TestFixtureSetUp]
		public void SetUp()
		{
			this.Given();

			try
			{
				this.Expect();
				this.When();
			}
			catch (Exception e)
			{
				if (this.expectedExceptionType == null || !this.expectedExceptionType.IsInstanceOfType(e))
					throw;

				this.thrownException = e;
			}
		}

		protected virtual void Expect()
		{
			
		}

		protected void Exception<TException>() where TException : Exception
		{
			this.expectedExceptionType = typeof(TException);
		}

		protected TException Thrown<TException>() where TException : Exception
		{
			return this.thrownException as TException;
		}

		protected virtual void Given() { }
		protected abstract void When();

		[TestFixtureTearDown]
		public virtual void TidyUp()
		{
		}
	}
}