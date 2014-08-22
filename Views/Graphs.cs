using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using samskip.rating_browser.Models;

namespace samskip.rating_browser
{
    public partial class Graphs : UserControl
    {
        public Graphs()
        {
            InitializeComponent();
        }

        public void SetChart(List<Rating> ratings)
        {
            Series ratingsSeries = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Pie
            };
            chartRatings.Series.Add(ratingsSeries);
            ratingsSeries.Points.Add(70000);
            ratingsSeries.Points.Add(30000);
            var p1 = ratingsSeries.Points[0];
            p1.AxisLabel = "70000";
            p1.LegendText = "Hiren Khirsaria";
            var p2 = ratingsSeries.Points[1];
            p2.AxisLabel = "30000";
            p2.LegendText = "ABC XYZ";
            chartRatings.Invalidate();
        }

    }
}
