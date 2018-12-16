using System.Threading.Tasks;

namespace Infrastructure.Context
{
   public interface IWeatherContext
   {
      Task<string> MakeRequest(string url);
   }
}
