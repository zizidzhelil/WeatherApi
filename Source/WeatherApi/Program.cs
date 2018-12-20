using BL.DependencyResolver;
using ConsoleTableExt;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WeatherApi.Converters;
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

         var weatherForDaysService = serviceProvider.GetService<IGetWeatherForCityAndDaysService>();
         var result = weatherForDaysService.GetWeatherForCityAndDays("Burgas", 4).GetAwaiter().GetResult();

         var converter = serviceProvider.GetService<IDataTableConverter>();
         var weatherDataTable = converter.ConvertToDataTable(result);

         Console.WriteLine($"Weather for {result.CityName}:");
         ConsoleTableBuilder
            .From(weatherDataTable)
            .WithFormat(ConsoleTableBuilderFormat.Default)
            .ExportAndWriteLine();
      }
   }
}
