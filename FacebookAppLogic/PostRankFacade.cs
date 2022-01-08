using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostRankFacade
    {
        private readonly PostRankFormLogic r_PostRank = new PostRankFormLogic();
        private ChartByMonthsLogic m_ChartByMonths;
        private ChartByYearLogic m_ChartByYear;

        public Dictionary<Post, int> GetUserPosts()
        {
            return r_PostRank.UserPosts;
        }

        public void InitPostsInfo()
        {
            r_PostRank.InitPostsList();
            m_ChartByMonths = new ChartByMonthsLogic();
            m_ChartByYear = new ChartByYearLogic();
        }

        public Dictionary<int, int> GetChartByMonthsXY()
        {
            return m_ChartByMonths.FillInChart();
        }

        public Dictionary<int, int> GetChartByYearXY()
        {
            return m_ChartByYear.FillInChart();
        }

        public float GetChartByYearPostsAverage()
        {
            return m_ChartByYear.m_PostAverage;
        }

        public float GetChartByMonthPostsAverage()
        {
            return m_ChartByMonths.m_PostAverage;
        }

        public Post GetTheMostPopularPostByComments()
        {
            return r_PostRank.TheMostPopularPostByComments();
        }
    }
}