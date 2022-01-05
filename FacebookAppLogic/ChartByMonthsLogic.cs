using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    class ChartByMonthsLogic:ChartLogic
    {
        private const  int k_NumberOfMonths=13;

       /* public readonly List<Post>[] r_UserPostsOrderedbyMnew List<Post>[k_NumberOfMonths];

        protected override void InitUserPostsOrderedBy()
        {
            for (int i = 0; i < m_MaxNumOfX; i++)
            {
                r_UserPostsOrdered[i] = new List<Post>();
            }
        }*/
        protected override int MaxNumberOfX()
        {
            return k_NumberOfMonths;
        }

     
        protected override int MinimumNumberOfX()
        {
            return (1);
        }

        protected override int JumpsBetweenEachX()
        {
            return 1;
        }

        protected override float averageOfPosts()
        {
            int sumOfPosts=0;
            float averageOfThePosts=0;
            foreach (KeyValuePair<int, int> xY in r_ChartXy)
            {
                sumOfPosts += xY.Value;
            }

            averageOfThePosts = sumOfPosts/(k_NumberOfMonths - 1);

            return averageOfThePosts;
        }
        protected override int GetXValueByPost(Post post)
        {
            return post.CreatedTime.Value.Month;
        }
       
    }
}
