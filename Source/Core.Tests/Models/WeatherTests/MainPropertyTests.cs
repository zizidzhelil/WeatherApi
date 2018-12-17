using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherTests
{
    [TestFixture]
    public class MainPropertyTests
    {
        [Test]
        public void GetAndSetDescription()
        {
            string expected = "Rain";

            Weather weather = new Weather();
            weather.Main = expected;

            string actual = weather.Main;

            Assert.AreEqual(actual, expected);
        }
    }
}
