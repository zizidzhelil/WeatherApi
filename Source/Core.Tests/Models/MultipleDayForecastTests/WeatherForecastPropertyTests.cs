using Core.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Tests.Models.MultipleDayForecastTests
{
    [TestFixture]
    public class WeatherForecastPropertyTests
    {
        [Test]
        public void GetAndSetWeatherForecast()
        {
            var expected = new List<Weather>()
            {
                new Weather()
                {
                    Id = 3,
                    Main = "A",
                    Description = "Sunny",
                    Icon = "Cloud"
                }
            };

            MultipleDayForecast multipleDayForecast = new MultipleDayForecast();
            multipleDayForecast.WeatherForecast = expected;

            var actual = multipleDayForecast.WeatherForecast;

            Assert.AreEqual(actual, expected);
        }
    }
}
