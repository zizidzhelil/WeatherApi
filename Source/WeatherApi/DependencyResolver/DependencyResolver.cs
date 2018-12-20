using Infrastructure.Providers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApi.Converters;
using WeatherApi.Converters.Implementation;
using WeatherApi.Providers;

namespace WeatherApi.DependencyResolver
{
   public static class DependencyResolver
   {
      public static ServiceCollection RegisterConcreteTypes(this ServiceCollection serviceCollection, IConfigurationRoot configuration)
      {
         serviceCollection.AddSingleton<IAppSettingsProvider>(new AppSettingsProvider(configuration));
         serviceCollection.AddScoped<IDataTableConverter, DataTableConverter>();

         return serviceCollection;
      }
   }
}
