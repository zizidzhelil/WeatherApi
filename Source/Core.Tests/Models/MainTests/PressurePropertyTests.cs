using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class PressurePropertyTests
    {
        [Test]
        public void GetAndSetPressure()
        {
            double expected = 29.92;

            Main main = new Main();
            main.Pressure = expected;

            double actual = main.Pressure;

            Assert.AreEqual(actual, expected);
        }
    }
}
