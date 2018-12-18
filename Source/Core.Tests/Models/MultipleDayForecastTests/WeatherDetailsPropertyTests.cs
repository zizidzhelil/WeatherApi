using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MultipleDayForecastTests
{
    [TestFixture]
    public class WeatherDetailsPropertyTests
    {
        [Test]
        public void GetAndSetWeatherDetails()
        {
            var expected = new WeatherDetails()
            {
                Temperature = 1,
                Pressure = 2,
                Humidity = 6,
                TemperatureMin = -2.0,
                TemperatureMax = 30.0,
                SeaLevel = 5.6,
                GroundLevel = 2.3
            };

            MultipleDayForecast multipleDayForecast = new MultipleDayForecast();
            multipleDayForecast.WeatherDetails = expected;

            var actual = multipleDayForecast.WeatherDetails;

            Assert.AreEqual(actual, expected);
        }
    }
}
