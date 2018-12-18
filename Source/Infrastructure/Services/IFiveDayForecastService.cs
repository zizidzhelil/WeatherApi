using Infrastructure.Models;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IFiveDayForecastService
    {
        Task<FiveDayForecastModel> GetFiveDayForecast();
    }
}
