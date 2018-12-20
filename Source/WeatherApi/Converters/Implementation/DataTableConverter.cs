using System.Data;
using Infrastructure.Models;

namespace WeatherApi.Converters.Implementation
{
   public class DataTableConverter : IDataTableConverter
   {
      public DataTable ConvertToDataTable(WeatherForCityAndDaysModel weatherForCityAndDays)
      {
         DataTable dataTable = new DataTable($"Weather For Days For {weatherForCityAndDays.CityName}");

         dataTable.Columns.Add("Date");
         dataTable.Columns.Add("Temperature C");
         dataTable.Columns.Add("Description");
         dataTable.Columns.Add("Cloudiness Percent");
         dataTable.Columns.Add("Wind Speed");
         dataTable.Columns.Add("Humidity Percent");
         dataTable.Columns.Add("Pressure");

         foreach (WeatherForCityAndDayModel weather in weatherForCityAndDays.Weather)
         {
            dataTable.Rows.Add(
               weather.Date,
               weather.Temperature,
               weather.Description,
               weather.CloudinessPercent,
               weather.WindSpeed,
               weather.Humidity,
               weather.Pressure);
         }

         return dataTable;
      }
   }
}
