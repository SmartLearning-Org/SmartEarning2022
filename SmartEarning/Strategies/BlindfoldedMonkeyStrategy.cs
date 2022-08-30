namespace SmartEarning.Strategies
{
    /// <summary>
    /// Strategy based on this article https://www.wsj.com/articles/SB991681622136214659
    /// </summary>
    public class BlindfoldedMonkeyStrategy : IRecommendationStrategy
    {
        public double GetRecommendation(RecommendationInfo info)
        {
            return -100 + Random.Shared.Next(200);
        }
    }
}
