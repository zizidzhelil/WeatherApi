using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.Models;
using Infrastructure.Services;
using Infrastructure.Weather.Queries;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BL.Tests.Services.FiveDayForecastServiceTests
{
    [TestFixture]
    public class GetFiveDayForecastMethodTests
    {
        private readonly IGetFiveDayForecastQuery _getFiveDayForecastQueryMock;

        public GetFiveDayForecastMethodTests()
        {
            Mock<IGetFiveDayForecastQuery> getFiveDayForecastQueryMock = new Mock<IGetFiveDayForecastQuery>();
            getFiveDayForecastQueryMock.Setup(c => c.Execute()).ReturnsAsync(QueryMocks.GetFiveDayForecastQueryResult);

            _getFiveDayForecastQueryMock = getFiveDayForecastQueryMock.Object;
        }

        [Test]
        public async Task ShouldReturnForecastModel()
        {
            IFiveDayForecastService fiveDayForecastService = new FiveDayForecastService(_getFiveDayForecastQueryMock);

            FiveDayForecastModel actualObject = await fiveDayForecastService.GetFiveDayForecast();
            FiveDayForecastModel expectedObject = new FiveDayForecastModel(QueryMocks.GetFiveDayForecastQueryResult);

            var actual = JsonConvert.SerializeObject(actualObject);
            var expected = JsonConvert.SerializeObject(expectedObject);

            Assert.AreEqual(actual, expected);
        }
    }
}
