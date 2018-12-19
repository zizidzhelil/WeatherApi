using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.ForecastTests
{
    [TestFixture]
    public class MessagePropertyTests
    {
        [Test]
        public void GetAndSetMessage()
        {
            double expected = 1.2;

            Forecast forecastObject = new Forecast();
            forecastObject.Message = expected;

            double actual = forecastObject.Message;

            Assert.AreEqual(actual, expected);
        }
    }
}
