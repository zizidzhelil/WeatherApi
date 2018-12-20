using BL.Converters;
using NUnit.Framework;
using System;

namespace BL.Tests.Converters.UnixDateTimeConverterTests
{
   [TestFixture]
   public class ConvertUnixTimestampToDateTimeMethodTests
   {
      [Test]
      public void ShouldReturnValidDateTime()
      {
         UnixDateTimeConverter unixDateTimeConverter = new UnixDateTimeConverter();

         var actual = unixDateTimeConverter.ConvertUnixTimestampToDateTime(1485799200);
         var expected = new DateTime(2017, 1, 30, 20, 0, 0);

         Assert.AreEqual(actual, expected);
      }
   }
}
