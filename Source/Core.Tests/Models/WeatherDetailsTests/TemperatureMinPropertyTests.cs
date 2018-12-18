using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class TemperatureMinPropertyTests
    {
        [Test]
        public void GetAndSetTemperatureMin()
        {
            double expected = -1.00;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.TemperatureMin = expected;

            double actual = weatherDetails.TemperatureMin;

            Assert.AreEqual(actual, expected);
        }
    }
}
