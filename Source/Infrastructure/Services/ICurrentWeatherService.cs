﻿using System.Threading.Tasks;

namespace Infrastructure.Services
{
   public interface ICurrentWeatherService
   {
      Task GetCurrentWeather();
   }
}
