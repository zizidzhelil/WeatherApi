using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.ForecastObjectTests
{
    [TestFixture]
    public class MessagePropertyTests
    {
        [Test]
        public void GetAndSetMessage()
        {
            double expected = 1.2;

            ForecastObject forecastObject = new ForecastObject();
            forecastObject.Message = expected;

            double actual = forecastObject.Message;

            Assert.AreEqual(actual, expected);
        }
    }
}
