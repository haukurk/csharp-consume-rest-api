using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using samskip.rating_browser.Clients;
using samskip.rating_browser.Models;

namespace samskip.rating_browser
{
    public partial class MainView : UserControl
    {
        readonly APIClient _clientAPI = new Clients.APIClient();
        
        public MainView()
        {
            InitializeComponent();

            // Get the chart from the view.

        }

        private void OnClickUpdateLastYear(object sender, EventArgs e)
        {
            var asyncRatingsObject = _clientAPI.Get<RatingsAPICall>("api/v1.1/rate/lastyear?key=" + Settings.Default.ITAPIKEY).Result;
            dataGridViewResult.DataSource = asyncRatingsObject.Data.Ratings;
            //graphView.SetChart(asyncRatingsObject.Data.Ratings);
        }

        private void OnClickLoadMonth(object sender, EventArgs e)
        {
            var asyncRatingsObject = _clientAPI.Get<RatingsAPICall>("api/v1.1/rate/lastmonth?key=" + Settings.Default.ITAPIKEY).Result;
            dataGridViewResult.DataSource = asyncRatingsObject.Data.Ratings;
            //graphView.SetChart(asyncRatingsObject.Data.Ratings);  
        }

        private void OnClickLoadLastWeek(object sender, EventArgs e)
        {
            RatingsAPICall asyncRatingsObject = _clientAPI.Get<RatingsAPICall>("api/v1.1/rate/lastweek?key=" + Settings.Default.ITAPIKEY).Result;
            dataGridViewResult.DataSource = asyncRatingsObject.Data.Ratings;
            //graphView.SetChart(asyncRatingsObject.Data.Ratings);

        }

        private void OnClickQuit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnClickExportExcel(object sender, EventArgs e)
        {
            MessageBox.Show("I'm terribly sorry, but this feature has not been implemented.");
        }

        private void dataGridViewResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
