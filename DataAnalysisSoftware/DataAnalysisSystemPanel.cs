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
        /// <summary>
        /// Setting Initial Params values
        /// </summary>
        string version = "Initial Version";
        string monitor = "Initial Monitor";
        string sMode = "Initial SMode";
        string date = "Initial Date";
        string startTime = "Initial Start Time";
        string length = "Initial Length";
        string interval = "Initial Interval";
        string upper1 = "Initial Upper1";
        string lower1 = "Initial Lower1";
        string upper2 = "Initial Upper2";
        string lower2 = "Initial Lower2";
        string upper3 = "Initial Upper3";
        string lower3 = "Initial Lower3";
        string timer1 = "Initial Timer1";
        string timer2 = "Initial Timer2";
        string timer3 = "Initial Timer3";
        string activeLimit = "Initial Active Limit";
        string maxHR = "Initial MaxHR";
        string restHR = "Initial RestHR";
        string startDelay = "Initial Start Delay";
        string vo2Max = "Initial VO2Max";
        string weight = "Initial Weight";

        ParameterClass pc = new ParameterClass();
        
        private void DataAnalysisSystemPanel_Load(object sender, EventArgs e)
        {
            pc.Version = version;
            
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
                summary.FormBorderStyle = FormBorderStyle.None;
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
