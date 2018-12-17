using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CoordTests
{
    [TestFixture]
    public class LongitudePropertyTests
    {
        [Test]
        public void GetAndSetLongitude()
        {
            double expected = 1.1111;

            Coordinates coordinates = new Coordinates();
            coordinates.Longitude = expected;

            double actual = coordinates.Longitude;

            Assert.AreEqual(actual, expected);
        }
    }
}
