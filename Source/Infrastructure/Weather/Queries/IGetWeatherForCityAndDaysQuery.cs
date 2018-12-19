using Core.Models;
using System.Threading.Tasks;

namespace Infrastructure.Weather.Queries
{
   public interface IGetWeatherForCityAndDaysQuery
   {
      Task<Forecast> Execute(string city, int weatherDays);
   }
}
