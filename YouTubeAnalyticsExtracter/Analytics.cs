#region Code Info
/*
 * Date                 Comments
 * 2013-10-20           Initially Created  
 */
#endregion Code Info


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Google.Apis.YouTubeAnalytics.v1;
using Google.Apis.Services;
using Google.Apis.Authentication.OAuth2;
using DotNetOpenAuth.OAuth2;

namespace YouTubeAnalyticsExtracter
{
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "yyyy-MM-dd";

            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "yyyy-MM-dd";

            cmbResourceType.SelectedIndex = 0;
            lstMetrics.SelectedIndex = 0;
        }

        private void btnSubmitQuery_Click(object sender, EventArgs e)
        {
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date should be less than End Date !!");
            } 
            else if (txtClientId.Text.Length > 0 && txtClientSecret.Text.Length > 0 && txtRefreshToken.Text.Length > 0 && txtResourceId.Text.Length > 0)
            {
                this.pictureBox.Image = Properties.Resources.Animation;
                this.backgroundWorker.RunWorkerAsync();

                // Here passing ClientId, Client Secret 
                var client = new WebServerClient(GoogleAuthenticationServer.Description, txtClientId.Text, txtClientSecret.Text);

                var auth = new OAuth2Authenticator<WebServerClient>(client, Authenticatestate);

                var _analyticService = new YouTubeAnalyticsService(new BaseClientService.Initializer
                {
                    Authenticator = auth
                });

                // create comma seperated list of Metrics
                string requestedMetrics = GetSelectedMterics();

                // Here requesting YouTube data by passing ChannelId, StartDate, EndDate and Metrics
                Google.Apis.YouTubeAnalytics.v1.Data.ResultTable result = _analyticService.Reports.Query(cmbResourceType.Text + "==" + txtResourceId.Text, dtpStartDate.Text, dtpEndDate.Text, requestedMetrics).Execute();

                DataTable youTubeResponseData = new DataTable();

                // Process the YouTube API response
                if (result != null && result.Rows != null && result.Rows.Count > 0)
                {
                    foreach (Google.Apis.YouTubeAnalytics.v1.Data.ResultTable.ColumnHeadersData header in result.ColumnHeaders)
                    {
                        youTubeResponseData.Columns.Add(header.Name, typeof(string));
                    }

                    int rowNumber = 0;
                    DataRow youTubeRow = youTubeResponseData.NewRow();
                    foreach (var metricValue in result.Rows[0])
                    {                        
                        youTubeRow[rowNumber] = metricValue;
                        rowNumber++;
                    }
                    youTubeResponseData.Rows.Add(youTubeRow);
                }
                else
                {
                    MessageBox.Show("No Data Available !!");
                }

                if (youTubeResponseData.Rows.Count > 0)
                {
                    dgYouTubeResponse.DataSource = youTubeResponseData;                  
                }

                this.pictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("All fields are compulsory. Please provide it !!");
            }

            this.backgroundWorker.CancelAsync();
        }

        /// <summary>
        ///  This Method will provide comma seperated lis of selected Metrics
        /// </summary>
        /// <returns></returns>
        private string GetSelectedMterics()
        {
            string selectedMterics = string.Empty;

            foreach(Object selecteditem in lstMetrics.SelectedItems)
            {
                selectedMterics = selectedMterics + "," +  (string)selecteditem;
            }

            return selectedMterics.Trim(',');
        }

        /// <summary>
        /// This Method is to Autheticate state using Refresh Token
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private IAuthorizationState Authenticatestate(WebServerClient client)
        {
            IAuthorizationState state = new AuthorizationState(new string[] { }) { RefreshToken = txtRefreshToken.Text };

            client.RefreshToken(state);
            return state;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {         
               
        }
    }
}
