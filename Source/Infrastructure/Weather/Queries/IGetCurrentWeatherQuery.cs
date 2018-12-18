using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Weather.Queries
{
   public interface IGetCurrentWeatherQuery
   {
      Task<WeatherObject> Execute();
   }
}
