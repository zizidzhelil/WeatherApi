using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.SysTests
{
    [TestFixture]
    public class MessagePropertyTests
    {
        [Test]
        public void GetAndSetMessage()
        {
            string expected = "Cloudy";

            CountryDetails sys = new CountryDetails();
            sys.Message = expected;

            string actual = sys.Message;

            Assert.AreEqual(actual, expected);
        }
    }
}
