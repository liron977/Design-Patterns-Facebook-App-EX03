
﻿namespace BasicFacebookFeatures
{
    partial class PostsChartByMonthsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.monthPostsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.PostsAverage = new System.Windows.Forms.Label();
            this.MonthAveragePosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthPostsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // monthPostsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.monthPostsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monthPostsChart.Legends.Add(legend1);
            this.monthPostsChart.Location = new System.Drawing.Point(59, 106);
            this.monthPostsChart.Name = "monthPostsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Posts";
            this.monthPostsChart.Series.Add(series1);
            this.monthPostsChart.Size = new System.Drawing.Size(824, 379);
            this.monthPostsChart.TabIndex = 3;
            this.monthPostsChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.text.Location = new System.Drawing.Point(166, 46);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(511, 40);
            this.text.TabIndex = 5;
            this.text.Text = "The chart displays the number of posts the user has posted per months\r\n\r\n";
            // 
            // PostsAverage
            // 
            this.PostsAverage.AutoSize = true;
            this.PostsAverage.Location = new System.Drawing.Point(717, 164);
            this.PostsAverage.Name = "PostsAverage";
            this.PostsAverage.Size = new System.Drawing.Size(116, 20);
            this.PostsAverage.TabIndex = 6;
            this.PostsAverage.Text = "Posts Average:";
            // 
            // MonthAveragePosts
            // 
            this.MonthAveragePosts.AutoSize = true;
            this.MonthAveragePosts.Location = new System.Drawing.Point(717, 205);
            this.MonthAveragePosts.Name = "MonthAveragePosts";
            this.MonthAveragePosts.Size = new System.Drawing.Size(35, 20);
            this.MonthAveragePosts.TabIndex = 7;
            this.MonthAveragePosts.Text = "text";
            // 
            // PostsChartByMonthsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(995, 518);
            this.Controls.Add(this.MonthAveragePosts);
            this.Controls.Add(this.PostsAverage);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthPostsChart);
            this.Name = "PostsChartByMonthsForm";
            this.Text = "PostChartByMonths";
            ((System.ComponentModel.ISupportInitialize)(this.monthPostsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart monthPostsChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label PostsAverage;
        private System.Windows.Forms.Label MonthAveragePosts;
    }
}