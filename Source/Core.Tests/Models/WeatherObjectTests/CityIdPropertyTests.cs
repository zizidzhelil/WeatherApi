using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class CityIdPropertyTests
    {
        [Test]
        public void GetAndSetCityId()
        {
            int expected = 3;

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.CityId = expected;

            int actual = weatherObject.CityId;

            Assert.AreEqual(actual, expected);
        }
    }
}
