using System.Data;
using NUnit.Framework;
using WeatherApi.Converters.Implementation;
using WeatherApi.Tests.Mocks;

namespace WeatherApi.Tests.Converters.DataTableConverterTests
{
   [TestFixture]
   public class ConvertToDataTableMethodTests
   {
      [Test]
      public void ShouldReturnDataTable()
      {
         DataTableConverter converter = new DataTableConverter();

         var expected = ModelMocks.WeatherForCityAndDays;
         DataTable actual = converter.ConvertToDataTable(expected);

         Assert.AreEqual(actual.Columns.Count, 7);
         Assert.AreEqual(actual.Rows.Count, 1);
      }
   }
}
