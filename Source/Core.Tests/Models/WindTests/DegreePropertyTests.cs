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
            double expected = 4.0;

            Wind wind = new Wind();
            wind.Degree = expected;

            double actual = wind.Degree;

            Assert.AreEqual(actual, expected);
        }
    }
}
