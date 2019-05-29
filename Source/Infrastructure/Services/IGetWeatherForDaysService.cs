﻿using Infrastructure.Models;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
   public interface IGetWeatherForDaysService
   {
      Task<WeatherForDaysModel> GetWeatherForDays(int weatherForDays);
   }
}
