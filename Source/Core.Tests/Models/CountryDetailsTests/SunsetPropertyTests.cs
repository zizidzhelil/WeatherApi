using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.SysTests
{
    [TestFixture]
    class SunsetPropertyTests
    {
        [Test]
        public void GetAndSetSunset()
        {
            string expected = "16:53";

            CountryDetails sys = new CountryDetails();
            sys.Sunset = expected;

            string actual = sys.Sunset;

            Assert.AreEqual(actual, expected);
        }
    }
}
