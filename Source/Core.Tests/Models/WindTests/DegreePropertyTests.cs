using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.WindTests
{
    [TestFixture]
    public class DegreePropertyTests
    {
        [Test]
        public void GetAndSetDegree()
        {
            int expected = 4;

            Wind wind = new Wind();
            wind.Degree = expected;

            int actual = wind.Degree;

            Assert.AreEqual(actual, expected);
        }
    }
}
