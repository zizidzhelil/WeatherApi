using Infrastructure.Models;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
   public interface ICurrentWeatherService
   {
      Task<CurrentWeatherModel> GetCurrentWeather();
   }
}
