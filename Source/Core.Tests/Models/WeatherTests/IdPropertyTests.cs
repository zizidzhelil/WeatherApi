using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherTests
{
    [TestFixture]
    public class IdPropertyTests
    {
        [Test]
        public void GetAndSetId()
        {
            int expected = 4;

            Weather weather = new Weather();
            weather.Id = expected;

            int actual = weather.Id;

            Assert.AreEqual(actual, expected);
        }
    }
}
