using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CloudsTests
{
    [TestFixture]
    public class CloudinessPercentPropertyTests
    {
        [Test]
        public void GetAndSetCloudinessPercent()
        {
            int expected = 5;

            Clouds clouds = new Clouds();
            clouds.CloudinessPercent = expected;

            int actual = clouds.CloudinessPercent;

            Assert.AreEqual(actual, expected);
        }
    }
}
