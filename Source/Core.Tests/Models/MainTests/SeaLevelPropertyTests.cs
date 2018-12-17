using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
    [TestFixture]
    public class SeaLevelPropertyTests
    {
        [Test]
        public void GetAndSetSeaLevel()
        {
            double expected = 5.0;

            Main main = new Main();
            main.SeaLevel = expected;

            double actual = main.SeaLevel;

            Assert.AreEqual(actual, expected);
        }
    }
}
