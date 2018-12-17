using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class TemperatureMinPropertyTests
    {
        [Test]
        public void GetAndSetTemperatureMin()
        {
            double expected = -1.00;

            Main main = new Main();
            main.TemperatureMin = expected;

            double actual = main.TemperatureMin;

            Assert.AreEqual(actual, expected);
        }
    }
}
