using Core.Models;
using System.Threading.Tasks;

namespace Infrastructure.Weather.Queries
{
   public interface IGetWeatherForDaysQuery
   {
      Task<Forecast> Execute(int weatherDays, Coordinates coordinates);
   }
}
