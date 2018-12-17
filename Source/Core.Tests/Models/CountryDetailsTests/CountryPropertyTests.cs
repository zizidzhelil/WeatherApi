using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.SysTests
{
    [TestFixture]
    public class CountryPropertyTests
    {
        [Test]
        public void GetAndSetCountry()
        {
            string expected = "Bulgaria";

            CountryDetails sys = new CountryDetails();
            sys.Country = expected;

            string actual = sys.Country;

            Assert.AreEqual(actual, expected);
        }
    }
}
