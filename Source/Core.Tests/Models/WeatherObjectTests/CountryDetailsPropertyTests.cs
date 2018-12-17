using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class CountryDetailsPropertyTests
    {
        [Test]
        public void GetAndSetCountryDetails()
        {
            var expected = new CountryDetails()
            {
                Message = "Cloudy",
                Country = "Bulgaria",
                Sunrise = "07:40",
                Sunset = "16:53"
            };

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.CountryDetails = expected;

            var actual = weatherObject.CountryDetails;

            Assert.AreEqual(actual, expected);
        }
    }
}
