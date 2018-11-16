using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalysisSoftware
{
    public partial class DataAnalysisSystemPanel : Form
    {
        public DataAnalysisSystemPanel()
        {
            InitializeComponent();
        }

        private void DataAnalysisSystemPanel_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// /Open Dialog to search hrm file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Open .HRM file";
            opd.Filter = "HRM files (*.hrm|*.hrm|All files (*.*)|*.*";
            if (opd.ShowDialog() == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// Add Chart Mode in the Content Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContent.Controls.Clear(); //Clear Existing controls
                ChartMode chart = new ChartMode();
                chart.TopLevel = false;
                pnlContent.Controls.Add(chart);
                chart.FormBorderStyle = FormBorderStyle.None;
                chart.Dock = DockStyle.Fill;
                chart.Show();
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Add Data Summary in Content Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataSummary_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContent.Controls.Clear();
                DataSummary summary = new DataSummary();
                summary.TopLevel = false;
                pnlContent.Controls.Add(summary);
                summary.Dock = DockStyle.Fill;
                summary.Show();
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
