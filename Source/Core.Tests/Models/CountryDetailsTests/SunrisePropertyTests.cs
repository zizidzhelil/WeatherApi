using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.SysTests
{
    [TestFixture]
    class SunrisePropertyTests
    {
        [Test]
        public void GetAndSetSunrise()
        {
            string expected = "07:40";

            CountryDetails sys = new CountryDetails();
            sys.Sunrise = expected;

            string actual = sys.Sunrise;

            Assert.AreEqual(actual, expected);
        }
    }
}
