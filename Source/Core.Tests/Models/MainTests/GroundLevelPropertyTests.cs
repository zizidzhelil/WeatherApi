using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class GroundLevelPropertyTests
    {
        [Test]
        public void GetAndSetGroundLevel()
        {
            double expected = 8.7;

            Main main = new Main();
            main.GroundLevel = expected;

            double actual = main.GroundLevel;

            Assert.AreEqual(actual, expected);
        }
    }
}
