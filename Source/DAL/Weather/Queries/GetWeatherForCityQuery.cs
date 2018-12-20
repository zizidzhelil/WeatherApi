using Core.Models;
using Infrastructure.Context;
using Infrastructure.Providers;
using Infrastructure.Weather.Queries;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.UrlFactory;
using Infrastructure.UrlFactory.UrlBuilder;

namespace DAL.Weather.Queries
{
   public class GetWeatherForCityQuery : IGetWeatherForCityQuery
   {
      private readonly IWeatherContext _context;
      private readonly IUrlFactory _urlFactory;

      public GetWeatherForCityQuery(IWeatherContext context, IUrlFactory urlFactory)
      {
         _context = context;
         _urlFactory = urlFactory;
      }

      public async Task<Forecast> Execute(string city)
      {
         string result = await _context.MakeRequest(_urlFactory.Create(
            nameof(WeatherForCityAndDaysUrlBuilder),
            city));

         Forecast forecast = JsonConvert.DeserializeObject<Forecast>(result);
         return forecast;
      }
   }
}
