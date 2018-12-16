using System.Threading.Tasks;
using Infrastructure.Context;

namespace DAL.Context
{
   public class WeatherContext : IWeatherContext
   {
      // TODO: Implement api call here
      public async Task<string> MakeRequest(string url)
      {
         await Task.Delay(1);
         return string.Empty;
      }
   }
}
