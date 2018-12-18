using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class HumidityPropertyTests
    {
        [Test]
        public void GetAndSetHumidity()
        {
            int expected = 71;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.Humidity = expected;

            int actual = weatherDetails.Humidity;

            Assert.AreEqual(actual, expected);
        }
    }
}
