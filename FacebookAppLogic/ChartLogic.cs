using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public abstract class ChartLogic
    {
        protected readonly Dictionary<int, int> r_ChartXy = new Dictionary<int, int>();
        protected readonly FacebookAppManager r_AppManager = FacebookAppManager.Instance;
        private readonly int r_MaxNumOfX;
        public readonly List<Post>[] r_UserPostsOrdered;
        public float m_PostAverage;
        private bool m_CharChosen=false;


        protected ChartLogic()
        {
            r_MaxNumOfX = MaxNumberOfX();
            r_UserPostsOrdered = new List<Post>[r_MaxNumOfX];
            InitDataList();
        }


        public void InitUserPostsOrderedBy()
        {
            for(int i = 0; i < r_MaxNumOfX; i++)
            {
                r_UserPostsOrdered[i] = new List<Post>();
            }
        }

        protected void InitDataList()
        {
            InitUserPostsOrderedBy();
            int xValue = 0;

            foreach(Post post in r_AppManager.UserPostsList)
            {
                xValue = GetXValueByPost(post);

                r_UserPostsOrdered[xValue].Add(post);
            }
        }


        public Dictionary<int, int> ChartXY
        {
            get
            {
                return r_ChartXy;
            }
        }

        protected abstract float AverageOfPosts();

        protected abstract int MinimumNumberOfX();

        protected abstract int GetXValueByPost(Post i_Post);

        protected abstract int JumpsBetweenEachX();

        protected abstract int MaxNumberOfX();

        public Dictionary<int, int> FillInChart()
        {
            int numberOfX = MaxNumberOfX();
            int jumpsBetweenEachX = JumpsBetweenEachX();
            if(!m_CharChosen)
            {
                for(int i = MinimumNumberOfX(); i < numberOfX; i = i + jumpsBetweenEachX)
                {
                    r_ChartXy.Add(i, r_UserPostsOrdered[i].Count);
                }

                m_CharChosen = true;

                m_PostAverage = AverageOfPosts();
            }

            return r_ChartXy;
        }
    }
}