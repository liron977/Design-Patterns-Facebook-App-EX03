using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostRankFacade
    {
        private readonly PostRankFormLogic r_PostRank = new PostRankFormLogic();
        private  ChartByMonthsLogic r_ChartByMonths;
        private ChartByYearLogic r_ChartByYear;

        public Dictionary<Post, int> GetUserPosts()
        {
            return r_PostRank.UserPosts;
        }

        public void InitPostsInfo()
        {
            /*r_PostRank.InitUserPostsOrderedByMonthList();
            r_PostRank.InitUserPostsOrderedByYearList();*/
            r_PostRank.InitPostsList();
            r_ChartByMonths = new ChartByMonthsLogic();
            r_ChartByYear = new ChartByYearLogic();
        }

        public Dictionary<int, int> GetChartByMonthsXY()
        {
            return r_ChartByMonths.ChartXY;
        }
        public Dictionary<int, int> GetChartByYearXY()
        {
            return r_ChartByYear.ChartXY;
        }
        public float GetChartByYearPostsAverage()
        {
            return r_ChartByYear.postAverage;
        }
        public float GetChartByMonthPostsAverage()
        {
            return r_ChartByMonths.postAverage;
        }
        public Post GetTheMostPopularPostByComments()
        {
            return r_PostRank.TheMostPopularPostByComments();
        }

       /* public int GetNumberOfMonths()
        {
            return r_PostRank.NumberOfMonths;
        }

        public int GetCurrentYear()
        {
            return r_PostRank.CurrentYear;
        }*/

        /*public int GetUserPostsOrderedByMonth(int i_Index)
        {
            return r_PostRank.UserPostsOrderedByMonth[i_Index].Count;
        }

        public int GetUserPostsOrderedByYear(int i_Index)
        {
            return r_PostRank.UserPostsOrderedByYear[i_Index].Count;
        }*/
    }
}