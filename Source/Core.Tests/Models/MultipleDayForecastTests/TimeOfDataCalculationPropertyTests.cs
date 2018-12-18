using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MultipleDayForecastTests
{
    [TestFixture]
    public class TimeOfDataCalculationPropertyTests
    {
        [Test]
        public void GetAndSetTimeOfDataCalculation()
        {
            var expected = 3;

            MultipleDayForecast multipleDayForecast = new MultipleDayForecast();
            multipleDayForecast.TimeOfDataCalculation = expected;

            var actual = multipleDayForecast.TimeOfDataCalculation;

            Assert.AreEqual(actual, expected);
        }
    }
}
