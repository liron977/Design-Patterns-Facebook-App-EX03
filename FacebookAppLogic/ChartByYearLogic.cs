using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    class ChartByYearLogic : ChartLogic
    {
        private int CurrentYear;
      /*  public readonly List<Post>[] r_UserPostsOrderedByYear = new List<Post>[22];*/

      
        protected override int MaxNumberOfX()
        {
            CurrentYear = int.Parse(DateTime.Now.Year.ToString())-2000;
            return CurrentYear;
        }
        protected override int GetXValueByPost(Post i_Post)
        {
            return i_Post.CreatedTime.Value.Year-2000;
        }

        /*public void InitUserPostsOrderedByYearList()
        {
            for (int i = 0; i < 22; i++)
            {
                r_UserPostsOrderedByYear[i] = new List<Post>();
            }
        }*/

        protected override int MinimumNumberOfX()
        {
            return (CurrentYear - 10);
        }

        protected override int JumpsBetweenEachX()
        {
            return 1;
        }
        protected override float averageOfPosts()
        {
            int sumOfPosts = 0;
            float averageOfThePosts = 0;
            foreach (KeyValuePair<int, int> xY in r_ChartXy)
            {
                sumOfPosts += xY.Value;
            }

            averageOfThePosts = sumOfPosts / (10);

            return averageOfThePosts;
        }
        /*  protected override void InitDataList()
          {
              InitUserPostsOrderedByYearList();

              int postCreatedYear;
              foreach (Post post in r_AppManager.UserPostsList)
              {
                  postCreatedYear = post.CreatedTime.Value.Year;

                  r_UserPostsOrdered[postCreatedYear -2000].Add(post);
              }

          }
  */
        /* protected override int GetYByX(int x)
         {
                return r_UserPostsOrdered[x].Count;

         }*/
    }
}
