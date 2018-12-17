using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class HumidityPropertyTests
    {
        [Test]
        public void GetAndSetHumidity()
        {
            int expected = 71;

            Main main = new Main();
            main.Humidity = expected;

            int actual = main.Humidity;

            Assert.AreEqual(actual, expected);
        }
    }
}
