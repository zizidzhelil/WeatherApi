using Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Models
{
   public class WeatherForCityAndDaysModel
   {
      public List<WeatherForCityAndDayModel> Weather { get; set; }

      public string CityName { get; set; }
   }
}
