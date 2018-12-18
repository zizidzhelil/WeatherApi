using Common.Constants;
using Infrastructure.Providers;
using Microsoft.Extensions.Configuration;

namespace WeatherApi.Providers
{
   public class AppSettingsProvider : IAppSettingsProvider
   {
      private readonly IConfigurationRoot _configuration;

      public AppSettingsProvider(IConfigurationRoot configuration)
      {
         _configuration = configuration;
      }

      public string ApiKey => _configuration[AppSettingsConstants.WeatherApiKey];
   }
}
