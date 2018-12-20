using System.Data;
using Infrastructure.Models;

namespace WeatherApi.Converters
{
   public interface IDataTableConverter
   {
      DataTable ConvertToDataTable(WeatherForCityAndDaysModel weatherForCityAndDays);
   }
}
