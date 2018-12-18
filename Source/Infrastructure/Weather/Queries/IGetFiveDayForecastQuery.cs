using Core.Models;
using System.Threading.Tasks;

namespace Infrastructure.Weather.Queries
{
    public interface IGetFiveDayForecastQuery
    {
        Task<ForecastObject> Execute();
    }
}
