using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartEarning.Strategies;

namespace SmartEarning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockRecommendationController : ControllerBase
    {
        private readonly IRecommendationStrategy[] Strategies = { new BlindfoldedMonkeyStrategy() };
        [HttpGet("/")]
        public double GetRecommendation()
        {
            RecommendationInfo info = GetRecommendationInfo();
            double sum = 0;
            foreach (var strategy in Strategies)
            {
                sum += strategy.GetRecommendation(info);
            }
            return sum / Strategies.Length;
        }

        private RecommendationInfo GetRecommendationInfo()
        {
            return new();
        }
    }
}
