using Core.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class WeatherPropertyTests
    {
        [Test]
        public void GetAndSetWeather()
        {
            var expected = new List<Weather>()
            {
                new Weather()
                {
                    Id = 4,
                    Main = "Rain",
                    Description = "Mostly Cloudy",
                    Icon = "cloud"
                }
            };

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.Weather = expected;

            var actual = weatherObject.Weather;

            Assert.AreEqual(actual, expected);
        }
    }
}
