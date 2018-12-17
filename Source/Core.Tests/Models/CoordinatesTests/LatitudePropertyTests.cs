using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CoordTests
{
    [TestFixture]
    public class LatitudePropertyTests
    {
        [Test]
        public void GetAndSetLatitude()
        {
            double expected = 2.123123;

            Coordinates coordinates = new Coordinates();
            coordinates.Latitude = expected;

            double actual = coordinates.Latitude;

            Assert.AreEqual(actual, expected);
        }
    }
}
