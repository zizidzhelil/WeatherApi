using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class SeaLevelPropertyTests
    {
        [Test]
        public void GetAndSetSeaLevel()
        {
            double expected = 5.0;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.SeaLevel = expected;

            double actual = weatherDetails.SeaLevel;

            Assert.AreEqual(actual, expected);
        }
    }
}
