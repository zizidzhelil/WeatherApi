using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class GroundLevelPropertyTests
    {
        [Test]
        public void GetAndSetGroundLevel()
        {
            double expected = 8.7;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.GroundLevel = expected;

            double actual = weatherDetails.GroundLevel;

            Assert.AreEqual(actual, expected);
        }
    }
}
