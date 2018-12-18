using Core.Models;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Weather.Queries;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DAL.Weather.Queries
{
   public class GetCurrentWeatherQuery : IGetCurrentWeatherQuery
   {
      private readonly IWeatherContext _context;
      private readonly IAppSettingsProvider _appSettingsProvider;

      public GetCurrentWeatherQuery(IWeatherContext context, IAppSettingsProvider appSettingsProvider)
      {
         _context = context;
         _appSettingsProvider = appSettingsProvider;
      }

      public async Task<WeatherObject> Execute()
      {
         string result = await _context.MakeRequest($"https://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid={_appSettingsProvider.ApiKey}");
         return JsonConvert.DeserializeObject<WeatherObject>(result);
      }
   }
}
