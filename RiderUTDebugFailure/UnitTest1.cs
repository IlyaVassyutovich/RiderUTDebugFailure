using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RiderUTDebugFailure
{
	[TestClass]
	public class UnitTestClass
	{
		[TestMethod]
		public void TestMethod()
		{
			// put breakpoint at Assert.Fail
			Assert.Fail("Hello there!");
		}
	}
}