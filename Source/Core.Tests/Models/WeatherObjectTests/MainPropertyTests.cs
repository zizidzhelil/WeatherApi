using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class MainPropertyTests
    {
        [Test]
        public void GetAndSetMain()
        {
            var expected = new WeatherDetails()
            {
                Temperature = 4.0,
                Pressure = 6.3,
                Humidity = 5,
                TemperatureMin = -10.5,
                TemperatureMax = 20.6,
                SeaLevel = 07.6,
                GroundLevel = 12.0
            };

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.WeatherDetails = expected;

            var actual = weatherObject.WeatherDetails;

            Assert.AreEqual(actual, expected);
        }
    }
}
