using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MultipleDayForecastTests
{
    [TestFixture]
    public class ForecastCalculationUtcPropertyTests
    {
        [Test]
        public void GetAndSetForecastCalculationUtc()
        {
            var expected = "utc";
           
            MultipleDayForecast multipleDayForecast = new MultipleDayForecast();
            multipleDayForecast.ForecastCalculationUtc = expected;

            var actual = multipleDayForecast.ForecastCalculationUtc;

            Assert.AreEqual(actual, expected);
        }
    }
}
