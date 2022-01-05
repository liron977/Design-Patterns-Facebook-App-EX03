using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    class PostsChartLogic
    {
        public const int k_CurrentYear = 22;
        public const int k_NumberOfMonths = 13;
        public const int k_Millennium = 2000;
        public readonly List<Post>[] r_UserPostsOrderedByMonth = new List<Post>[13];
        public readonly List<Post>[] r_UserPostsOrderedByYear = new List<Post>[k_CurrentYear];
        public void InitUserPostsOrderedByMonthList()
        {
            for (int i = 0; i < k_NumberOfMonths; i++)
            {
                r_UserPostsOrderedByMonth[i] = new List<Post>();
            }
        }

        public void InitUserPostsOrderedByYearList()
        {
            for (int i = 0; i < k_CurrentYear; i++)
            {
                r_UserPostsOrderedByYear[i] = new List<Post>();
            }
        }
        public int CurrentYear
        {
            get
            {
                return k_CurrentYear;
            }
        }
        public int NumberOfMonths
        {
            get
            {
                return k_NumberOfMonths;
            }
        }
        public Dictionary<Post, int> UserPosts
        {
            get
            {
                return r_UserPosts;
            }
        }
        public List<Post>[] UserPostsOrderedByMonth
        {
            get
            {
                return r_UserPostsOrderedByMonth;
            }
        }
        public List<Post>[] UserPostsOrderedByYear
        {
            get
            {
                return r_UserPostsOrderedByYear;
            }
        }
    }
}
