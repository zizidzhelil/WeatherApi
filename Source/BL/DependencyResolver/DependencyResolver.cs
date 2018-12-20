using BL.Converters;
using BL.Grouper;
using BL.Services;
using DAL.Context;
using DAL.Factories;
using DAL.Factories.ConcreteUrlBuilders;
using DAL.Weather.Queries;
using Infrastructure.Context;
using Infrastructure.Converters;
using Infrastructure.Grouper;
using Infrastructure.Providers;
using Infrastructure.Services;
using Infrastructure.UrlFactory;
using Infrastructure.UrlFactory.UrlBuilder;
using Infrastructure.Weather.Queries;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace BL.DependencyResolver
{
   public static class DependencyResolver
   {
      public static ServiceCollection RegisterTypes(this ServiceCollection serviceCollection)
      {
         serviceCollection.AddScoped<IWeatherContext, WeatherContext>();

         serviceCollection.AddScoped<IGetWeatherForCityAndDaysService, GetWeatherForCityAndDaysService>();

         serviceCollection.AddScoped<IGetWeatherForCityQuery, GetWeatherForCityQuery>();

         serviceCollection.AddScoped<IUrlFactory>((serviceProvider) =>
            new UrlFactory(new Dictionary<string, Func<IUrlBuilder>>()
            {
               { nameof(WeatherForCityAndDaysUrlBuilder), () => new WeatherForCityAndDaysUrlBuilder(serviceProvider.GetService<IAppSettingsProvider>()) }
            }));

         serviceCollection.AddScoped<IGroupWeatherByDay, GroupWeatherByDay>();

         serviceCollection.AddScoped<IUnixDateTimeConverter, UnixDateTimeConverter>();

         serviceCollection.AddHttpClient();

         return serviceCollection;
      }
   }
}
