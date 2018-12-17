using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.MainTests
{
   public class TemperatureMaxPropertyTests
    {
        [Test]
        public void GetAndSetTemperatureMax()
        {
            double expected = 10.00;

            Main main = new Main();
            main.TemperatureMax = expected;

            double actual = main.TemperatureMax;

            Assert.AreEqual(actual, expected);
        }
    }
}
