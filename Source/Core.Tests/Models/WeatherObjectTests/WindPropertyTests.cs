using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class WindPropertyTests
    {
        [Test]
        public void GetAndSetWind()
        {
            var expected = new Wind()
            {
                Speed = 12.0,
                Degree = 3          
            };

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.Wind = expected;

            var actual = weatherObject.Wind;

            Assert.AreEqual(actual, expected);
        }
    }
}
