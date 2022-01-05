using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    class ChartByYearLogic : ChartLogic
    {
        private int m_CurrentYear;
        private readonly int r_Millennium = DateTime.Now.Year - DateTime.Now.Year % 1000;
        private readonly int r_NumberOfYearsToShow = 10;
        private readonly int r_JumpsBetweenEachX = 1;

        protected override int MaxNumberOfX()
        {
            m_CurrentYear = int.Parse(DateTime.Now.Year.ToString()) - r_Millennium;
            return m_CurrentYear;
        }

        protected override int GetXValueByPost(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Year - r_Millennium;
        }


        protected override int MinimumNumberOfX()
        {
            return (m_CurrentYear - r_NumberOfYearsToShow);
        }

        protected override int JumpsBetweenEachX()
        {
            return r_JumpsBetweenEachX;
        }

        protected override float AverageOfPosts()
        {
            int sumOfPosts = 0;
            float averageOfThePosts;
            foreach(KeyValuePair<int, int> xY in r_ChartXy)
            {
                sumOfPosts += xY.Value;
            }

            averageOfThePosts = sumOfPosts / r_NumberOfYearsToShow;

            return averageOfThePosts;
        }
    }
}