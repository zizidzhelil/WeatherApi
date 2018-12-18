using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.ForecastObjectTests
{
    [TestFixture]
    public class ForecastCountPropertyTests
    {
        [Test]
        public void GetAndSetForecastCount()
        {
            int expected = 1;

            ForecastObject forecastObject = new ForecastObject();
            forecastObject.ForecastCount = expected;

            int actual = forecastObject.ForecastCount;

            Assert.AreEqual(actual, expected);
        }
    }
}
