using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class PressurePropertyTests
    {
        [Test]
        public void GetAndSetPressure()
        {
            double expected = 29.92;

            WeatherDetails weatherDetails = new WeatherDetails();
            weatherDetails.Pressure = expected;

            double actual = weatherDetails.Pressure;

            Assert.AreEqual(actual, expected);
        }
    }
}
