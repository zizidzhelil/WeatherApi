using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    class TemperaturePropertyTests
    {
            [Test]
            public void GetAndSetTemperature()
            {
                double expected = 3;

                Main main = new Main();
                main.Temperature = expected;

                double actual = main.Temperature;

                Assert.AreEqual(actual, expected);
            }
    }
}
