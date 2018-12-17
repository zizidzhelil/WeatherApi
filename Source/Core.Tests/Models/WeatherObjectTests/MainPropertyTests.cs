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
            var expected = new Main()
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
            weatherObject.Main = expected;

            var actual = weatherObject.Main;

            Assert.AreEqual(actual, expected);
        }
    }
}
