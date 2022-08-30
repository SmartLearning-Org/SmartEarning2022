namespace SmartEarning.Strategies
{
    public interface IRecommendationStrategy
    {
        /// <summary>
        /// Calculates the recommendation score using this strategy
        /// </summary>
        /// <param name="info">object containing all relevant info for the strategi to run</param>
        /// <returns>A recommendation rate in the interval -100 to +100 (both included)</returns>
        double GetRecommendation(RecommendationInfo info);
    }

}
