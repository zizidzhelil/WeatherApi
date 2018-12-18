using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MultipleDayForecastTests
{
    [TestFixture]
    public class CloudsPropertyTests
    {
        [Test]
        public void GetAndSetClouds()
        {
            var expected = new Clouds()
            {
                CloudinessPercent = 2
            };

            MultipleDayForecast multipleDayForecast = new MultipleDayForecast();
            multipleDayForecast.Clouds = expected;

            var actual = multipleDayForecast.Clouds;

            Assert.AreEqual(actual, expected);
        }
    }
}
