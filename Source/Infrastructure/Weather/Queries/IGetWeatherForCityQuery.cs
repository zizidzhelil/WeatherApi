using Core.Models;
using System.Threading.Tasks;

namespace Infrastructure.Weather.Queries
{
   public interface IGetWeatherForCityQuery
   {
      Task<Forecast> Execute(string city);
   }
}
