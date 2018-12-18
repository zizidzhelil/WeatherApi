using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    public class TemperatureMaxPropertyTests
    {
        [Test]
        public void GetAndSetTemperatureMax()
        {
            double expected = 10.00;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.TemperatureMax = expected;

            double actual = weatherDetails.TemperatureMax;

            Assert.AreEqual(actual, expected);
        }
    }
}
