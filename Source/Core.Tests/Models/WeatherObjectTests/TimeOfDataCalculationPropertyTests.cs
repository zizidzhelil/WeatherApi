using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class TimeOfDataCalculationPropertyTests
    {
        [Test]
        public void GetAndSetTimeOfDataCalculation()
        {
            int expected = 10;

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.TimeOfDataCalculation = expected;

            int actual = weatherObject.TimeOfDataCalculation;

            Assert.AreEqual(actual, expected);
        }
    }
}
