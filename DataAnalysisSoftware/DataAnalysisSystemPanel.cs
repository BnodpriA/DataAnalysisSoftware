using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

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
        string version = "1.0";
        string monitor = "0";
        string sMode = "00000000";
        string date = "20181123";
        string startTime = "00:00:00.0";
        string length = "00:00:00.0";
        string interval = "0";
        string upper1 = "160";
        string lower1 = "80";
        string upper2 = "160";
        string lower2 = "80";
        string upper3 = "160";
        string lower3 = "80";
        string timer1 = "00:00";
        string timer2 = "00:00";
        string timer3 = "00:00";
        string activeLimit = "0";
        string maxHR = "192";
        string restHR = "52";
        string startDelay = "300";
        string vo2Max = "50";
        string weight = "75";

        private string HRM;
        IDictionary<string, string> Params = new Dictionary<string, string>();

        ParameterClass pc = new ParameterClass();
        
        private void DataAnalysisSystemPanel_Load(object sender, EventArgs e)
        {
            //Setting date formate to YYYY/MM/DD
            date = date.Insert(4, "/");///Adding foreslash after 4 digit in date
            date = date.Insert(7, "/");///Adding foreslash after 7 digit in date


            pc.Version = version;
            pc.Monitor = monitor;
            pc.SMode = sMode;
            pc.Date = date;
            pc.StartTime = startTime;
            pc.Length = length;
            pc.Interval = interval;
            pc.Upper1 = upper1;
            pc.Lower1 = lower1;
            pc.Upper2 = upper2;
            pc.Lower2 = lower2;
            pc.Upper3 = upper3;
            pc.Lower3 = lower3;
            pc.Timer1 = timer1;
            pc.Timer2 = timer2;
            pc.Timer3 = timer3;
            pc.ActiveLimit = activeLimit;
            pc.MaxHR = maxHR;
            pc.RestHR = restHR;
            pc.StartDelay = startDelay;
            pc.VO2max = vo2Max;
            pc.Weight = weight;
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
                txtFileName.Text = opd.FileName;
            }
            else
            {
                MessageBox.Show("No File Selected");
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
                summary.version = pc.Version;
                summary.monitor = pc.Monitor;
                summary.sMode = pc.SMode;
                summary.date = pc.Date;
                summary.startTime = pc.StartTime;
                summary.length = pc.Length;
                summary.interval = pc.Interval;
                summary.upper1 = pc.Upper1;
                summary.upper2 = pc.Upper2;
                summary.upper3 = pc.Upper3;
                summary.lower1 = pc.Lower1;
                summary.lower2 = pc.Lower2;
                summary.lower3 = pc.Lower3;
                summary.timer1 = pc.Timer1;
                summary.timer2 = pc.Timer2;
                summary.timer3 = pc.Timer3;
                summary.activeLimit = pc.ActiveLimit;
                summary.maxHR = pc.MaxHR;
                summary.restHR = pc.RestHR;
                summary.startDelay = pc.StartDelay;
                summary.vo2Max = pc.VO2max;
                summary.weight = pc.Weight;
                summary.Show();
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Method to load Parameter (Params) of hrm file to InitialParams variables
        /// </summary>
        public void LoadParametersToInitialParams()
        {
            version = Params["Version"];
            monitor = Params["Monitor"];
            sMode = Params["SMode"];
            date = Params["Date"];
            startTime = Params["StartTime"];
            length = Params["Length"];
            interval = Params["Interval"];
            upper1 = Params["Upper1"];
            lower1 = Params["Lower1"];
            upper2 = Params["Upper2"];
            lower2 = Params["Lower2"];
            upper3 = Params["Upper3"];
            lower3 = Params["Lower3"];
            timer1 = Params["Timer1"];
            timer2 = Params["Timer2"];
            timer3 = Params["Timer3"];
            activeLimit = Params["ActiveLimit"];
            maxHR = Params["MaxHR"];
            restHR = Params["RestHR"];
            startDelay = Params["StartDelay"];
            vo2Max = Params["VO2max"];
            weight = Params["Weight"];
        }
        private void FetchData()
        {
            StreamReader reader = new StreamReader(txtFileName.Text, Encoding.Default);
        }
    }
}
