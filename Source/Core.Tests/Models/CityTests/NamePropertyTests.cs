using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CityTests
{
    [TestFixture]
    public class NamePropertyTests
    {
        [Test]
        public void GetAndSetName()
        {
            string expected = "Burgas";

            City city = new City();
            city.Name = expected;

            string actual = city.Name;

            Assert.AreEqual(actual, expected);
        }
    }
}
