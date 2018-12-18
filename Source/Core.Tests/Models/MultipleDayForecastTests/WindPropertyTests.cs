using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MultipleDayForecastTests
{
    [TestFixture]
    public class WindPropertyTests
    {
        [Test]
        public void GetAndSetClouds()
        {
            var expected = new Wind()
            {
                Speed = 2.0,
                Degree = 3.0
            };

            MultipleDayForecast multipleDayForecast = new MultipleDayForecast();
            multipleDayForecast.Wind = expected;

            var actual = multipleDayForecast.Wind;

            Assert.AreEqual(actual, expected);
        }
    }
}
