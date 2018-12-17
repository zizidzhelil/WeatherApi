using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class CityNamePropertyTests
    {
        [Test]
        public void GetAndSetCityName()
        {
            string expected = "Sofia";

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.CityName = expected;

            string actual = weatherObject.CityName;

            Assert.AreEqual(actual, expected);
        }
    }
}
