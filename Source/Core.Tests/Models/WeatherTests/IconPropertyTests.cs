using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherTests
{
    [TestFixture]
    public class IconPropertyTests
    {
        [Test]
        public void GetAndSetIcon()
        {
            string expected = "cloud";

            Weather weather = new Weather();
            weather.Icon = expected;

            string actual = weather.Icon;

            Assert.AreEqual(actual, expected);
        }
    }
}
