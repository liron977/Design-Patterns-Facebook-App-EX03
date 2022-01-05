using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    internal partial class PostsChartByMonthsForm : Form
    {
        private readonly PostRankFacade r_AppPostsFacade;

        public PostsChartByMonthsForm(PostRankFacade i_AppPostsFacade)
        {
            r_AppPostsFacade = i_AppPostsFacade;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs i_E)
        {
            displayedCommentsChartOrderedByMonths();
        }

        private void displayedCommentsChartOrderedByMonths()
        {
            Dictionary<int, int> chartXY = r_AppPostsFacade.GetChartByMonthsXY();

            foreach(KeyValuePair<int, int> xY in chartXY)
            {
                monthPostsChart.Series["Posts"].Points.AddXY(xY.Key, xY.Value);
            }

            MonthAveragePosts.Text = r_AppPostsFacade.GetChartByMonthPostsAverage().ToString();
        }
    }
}