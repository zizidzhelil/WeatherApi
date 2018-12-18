using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CityTests
{
    [TestFixture]
    public class IdPropertyTests
    {
        [Test]
        public void GetAndSetId()
        {
            int expected = 5;

            City city = new City();
            city.Id = expected;

            int actual = city.Id;

            Assert.AreEqual(actual, expected);
        }
    }
}
