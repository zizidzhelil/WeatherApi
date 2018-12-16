using BL.Services;
using DAL.Context;
using DAL.Weather.Queries;
using Infrastructure.Context;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace BL.DependencyResolver
{
   public static class DependencyResolver
   {
      public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
      {
         serviceCollection.AddScoped<IWeatherContext, WeatherContext>();

         serviceCollection.AddScoped<ICurrentWeatherService, CurrentWeatherService>();

         serviceCollection.AddScoped<IGetCurrentWeatherQuery, GetCurrentWeatherQuery>();

         return serviceCollection;
      }
   }
}
