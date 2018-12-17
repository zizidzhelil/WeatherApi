using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WeatherObjectTests
{
    [TestFixture]
    public class CoordinatesPropertyTests
    {
        [Test]
        public void GetAndSetCoordinates()
        {
            var expected = new Coordinates()
            {
                Longitude = 4.0,
                Latitude = 6.3              
            };

            WeatherObject weatherObject = new WeatherObject();
            weatherObject.Coordinates = expected;

            var actual = weatherObject.Coordinates;

            Assert.AreEqual(actual, expected);
        }
    }
}
