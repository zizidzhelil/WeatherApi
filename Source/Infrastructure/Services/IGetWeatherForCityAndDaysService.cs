using Infrastructure.Models;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
   public interface IGetWeatherForCityAndDaysService
   {
      Task<WeatherForCityAndDaysModel> GetWeatherForCityAndDays(string city, int weatherForDays);
   }
}
