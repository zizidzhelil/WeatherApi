using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.CoordTests
{
   [TestFixture]
   public class LongitudePropertyTests
   {
      [Test]
      public void GetAndSetLongitude()
      {
         double expected = 1.1111;

         Coord coord = new Coord();
         coord.Longitude = expected;

         double actual = coord.Longitude;

         Assert.AreEqual(actual, expected);
      }
   }
}
