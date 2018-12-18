using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    class TemperaturePropertyTests
    {
        [Test]
        public void GetAndSetTemperature()
        {
            double expected = 3;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.Temperature = expected;

            double actual = weatherDetails.Temperature;

            Assert.AreEqual(actual, expected);
        }
    }
}
