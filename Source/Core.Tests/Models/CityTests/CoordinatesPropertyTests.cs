using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CityTests
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

            City city = new City();
            city.Coordinates = expected;

            var actual = city.Coordinates;

            Assert.AreEqual(actual, expected);
        }
    }
}
