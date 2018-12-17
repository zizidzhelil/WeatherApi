using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WindTests
{
    public class SpeedPropertyTests
    {
        [Test]
        public void GetAndSetSpeed()
        {
            double expected = 2.2;

            Wind wind = new Wind();
            wind.Speed = expected;

            double actual = wind.Speed;

            Assert.AreEqual(actual, expected);
        }
    }
}
