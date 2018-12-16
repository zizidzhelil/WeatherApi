using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CoordTests
{
   [TestFixture]
   public class LatitudePropertyTests
   {
      [Test]
      public void GetAndSetLatitude()
      {
         double expected = 2.123123;

         Coord coord = new Coord();
         coord.Latitude = expected;

         double actual = coord.Latitude;

         Assert.AreEqual(actual, expected);
      }
   }
}
