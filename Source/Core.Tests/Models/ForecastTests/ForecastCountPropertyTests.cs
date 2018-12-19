using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.ForecastTests
{
    [TestFixture]
    public class ForecastCountPropertyTests
    {
        [Test]
        public void GetAndSetForecastCount()
        {
            int expected = 1;

            Forecast forecastObject = new Forecast();
            forecastObject.ForecastCount = expected;

            int actual = forecastObject.ForecastCount;

            Assert.AreEqual(actual, expected);
        }
    }
}
