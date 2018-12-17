using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherTests
{
    [TestFixture]
    public class DescriptionPropertyTests
    {
        [Test]
        public void GetAndSetDescription()
        {
            string expected = "Mostly Cloudy";

            Weather weather = new Weather();
            weather.Description = expected;

            string actual = weather.Description;

            Assert.AreEqual(actual, expected);
        }
    }
}
