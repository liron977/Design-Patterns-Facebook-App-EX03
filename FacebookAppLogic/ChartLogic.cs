using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public abstract class ChartLogic
    {
        protected readonly Dictionary<int, int> r_ChartXy=new Dictionary<int, int>();
        protected readonly FacebookAppManager r_AppManager= FacebookAppManager.Instance;
        private int m_MaxNumOfX;
        public readonly List<Post>[] r_UserPostsOrdered;

        public float postAverage;

        protected ChartLogic()
        {
            m_MaxNumOfX = MaxNumberOfX();
            r_UserPostsOrdered = new List<Post>[m_MaxNumOfX];
            //r_PostRank =i_PostRank;
            InitDataList();
            postAverage=fillInChart();
        }


        public void InitUserPostsOrderedBy()
        {
            for (int i = 0; i < m_MaxNumOfX; i++)
            {
                r_UserPostsOrdered[i] = new List<Post>();
            }
        }
        protected void InitDataList()
        {
             InitUserPostsOrderedBy();
            int xValue;
            foreach (Post post in r_AppManager.UserPostsList)
            {
                xValue = GetXValueByPost(post);

                r_UserPostsOrdered[xValue].Add(post);
            }


        }

      /*  public int GetYByX(int x)
        {
            return r_UserPostsOrdered[x].Count;

        }*/
        public Dictionary<int, int> ChartXY
        {
            get
            {
                return r_ChartXy;
            }
        }

        protected abstract float averageOfPosts();
        protected abstract int MinimumNumberOfX();

        protected abstract int GetXValueByPost(Post i_Post);
        protected abstract int JumpsBetweenEachX();
        protected abstract int MaxNumberOfX();
        /*protected abstract int GetYByX(int x);*/
        private float fillInChart()
        {
           
            int numberOfX = MaxNumberOfX();
            int jumpsBetweenEachX = JumpsBetweenEachX();
            for (int i = MinimumNumberOfX(); i < numberOfX; i=i+ jumpsBetweenEachX)
            {
                r_ChartXy.Add(i, r_UserPostsOrdered[i].Count);
            }

            return averageOfPosts();
        }
    }
}
