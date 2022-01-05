using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostsChartByYearForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade;

        public PostsChartByYearForm(PostRankFacade i_AppPostsFacade)
        {
            r_AppPostsFacade = i_AppPostsFacade;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_E)
        {
            displayedCommentsChartOrderedByYear();
        }

        private void displayedCommentsChartOrderedByYear()
        {
            Dictionary<int, int> chartXY = r_AppPostsFacade.GetChartByYearXY();

            foreach(KeyValuePair<int, int> xY in chartXY)
            {
                commentsChart.Series["Posts"].Points.AddXY(xY.Key + 2000, xY.Value);
            }

            YearAveragePosts.Text = r_AppPostsFacade.GetChartByYearPostsAverage().ToString();
        }
    }
}