using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class CloudsPropertyTests
    {
        [Test]
        public void GetAndSetClouds()
        {
            var expected = new Clouds()
            {
                CloudinessPercent = 23
            };

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.Clouds = expected;

            var actual = weatherObject.Clouds;

            Assert.AreEqual(actual, expected);
        }
    }
}
