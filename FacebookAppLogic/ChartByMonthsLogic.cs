using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class ChartByMonthsLogic : ChartLogic
    {
        private const int k_NumberOfMonths = 13;
        private readonly int r_FromMonth = 1;
        private readonly int r_JumpsBetweenEachX = 1;

        protected override int MaxNumberOfX()
        {
            return k_NumberOfMonths;
        }


        protected override int MinimumNumberOfX()
        {
            return r_FromMonth;
        }

        protected override int JumpsBetweenEachX()
        {
            return r_JumpsBetweenEachX;
        }

        protected override float AverageOfPosts()
        {
            int sumOfPosts = 0;
            float averageOfThePosts = 0;
            foreach(KeyValuePair<int, int> xY in r_ChartXy)
            {
                sumOfPosts += xY.Value;
            }

            averageOfThePosts = sumOfPosts / (k_NumberOfMonths - r_FromMonth);

            return averageOfThePosts;
        }

        protected override int GetXValueByPost(Post post)
        {
            return post.CreatedTime.Value.Month;
        }
    }
}