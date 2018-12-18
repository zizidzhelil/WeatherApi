using BL.DependencyResolver;
using Infrastructure.Providers;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApi.DependencyResolver;

namespace WeatherApi
{
   public class Program
   {
      public static void Main(string[] args)
      {
         IConfigurationRoot configguration = new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build();

         ServiceProvider serviceProvider = new ServiceCollection()
            .RegisterConcreteTypes(configguration)
            .RegisterTypes()
            .BuildServiceProvider();

         // var currentWeatherService = serviceProvider.GetService<ICurrentWeatherService>();
         // var result = currentWeatherService.GetCurrentWeather().GetAwaiter().GetResult();

         var fiveDayForecastService = serviceProvider.GetService<IFiveDayForecastService>();
         var resultFiveDayForecast = fiveDayForecastService.GetFiveDayForecast().GetAwaiter().GetResult();
      }
   }
}
