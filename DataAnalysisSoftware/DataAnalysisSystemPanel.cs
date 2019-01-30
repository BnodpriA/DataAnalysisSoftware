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

        
        /// <summary>
        /// Setting Initial [HRData] value
        /// </summary>

        private string fileName;

        /// <summary>
        /// Advance Matrics
        /// </summary>
        public static List<List<double>> intervalValues = new List<List<double>>();
        public static List<double> powerData = new List<double>(); // used in interval detection as well 
        public static List<double> intervalDetectionData = new List<double>(); // interval detection 
        public static List<double> powerInterval = new List<double>(); // interval detection 
        public static double threholdValueGlobal;  // interval detection 
        List<double> powerDataSlt = new List<double>();

        private static double PowerBalance { get; set; }
        private static double NormalizedPower { get; set; }
        private static double TrainingStressScore { get; set; }
        private static double IntensityFactor { get; set; }

        public static double ftpGlobal { get; set; }
        public static double ifGlobal { get; set; }
        public static double tssGlobal { get; set; }
        public static double avgPowerGlobal { get; set; }
        public static double normalizationPowerGlobal { get; set; }

        List<double> movAvgPow4 = new List<double>();
        List<double> movAvg = new List<double>();
        List<double> movAvgPow4Slt = new List<double>();
        List<double> movAvgSlt = new List<double>();
        // string singleLine;
        //  IDictionary<string, string> Params = new Dictionary<string, string>();

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
                fileName = opd.FileName;
                DialogResult dr = MessageBox.Show(fileName + " has been successfully loaded", "Do you like to view the data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    FetchAndLoadParamsData();
                    LoadDataSummaryForm();
                    
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No File Selected");
            }
            FetchAndLoadParamsData();
           // FetchAndLoadHRMData();
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
                if (txtFileName.Text=="")
                {
                    MessageBox.Show("You need to choose Polar HRM File to view data");
                    btnLoadData.Focus();
                }
                else
                {
                    pnlContent.Controls.Clear(); //Clear Existing controls
                    Chart chart = new Chart();
                    chart.fileName = fileName;
                    chart.TopLevel = false;
                    pnlContent.Controls.Add(chart);
                    chart.FormBorderStyle = FormBorderStyle.None;
                    chart.Dock = DockStyle.Fill;
                    chart.Show();

                }
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

                if (txtFileName.Text=="")
                {
                    MessageBox.Show("You need to choose Polar HRM File to view data");
                    btnLoadData.Focus();
                }
                else
                {
                    LoadDataSummaryForm();
                    //ShowOrHidePowerBySMode();
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataSummaryForm()
        {
            pnlContent.Controls.Clear();
            DataSummary summary = new DataSummary();
            summary.TopLevel = false;
            pnlContent.Controls.Add(summary);
            summary.FormBorderStyle = FormBorderStyle.None;
            summary.fileName = fileName;
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
        /// <summary>
        /// Method to load Parameter (Params) of hrm file to InitialParams variables
        /// </summary>
      /*  public void LoadParametersToInitialParams()
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
        */
        private void FetchAndLoadParamsData()
        {
            try
            {
                if (txtFileName.Text!="")
                {
                    StreamReader reader = new StreamReader(txtFileName.Text, Encoding.Default);
                    string textOfHRMFile = reader.ReadToEnd();

                    //find 'Version=' in hrm file  and load its data to version variable
                    int indexOfVersion = textOfHRMFile.IndexOf("Version=");//load the 'Version=' from hrm file
                    version = textOfHRMFile.Substring(indexOfVersion + 8, 3); //Retrive string of last 3 letter after 8 letter of this index i.e. indexOfVersion
                    pc.Version = version;//load the fetch value of Version in the Version Function

                    //find 'Monitor=' and Load its data to monitor
                    int indexOfMonitor = textOfHRMFile.IndexOf("Monitor=");
                    monitor = textOfHRMFile.Substring(indexOfMonitor + 8, 2);
                    pc.Monitor = monitor;

                    //find 'SMode=' and load its date to sMode
                    int indexOfSMode = textOfHRMFile.IndexOf("SMode=");
                    sMode = textOfHRMFile.Substring(indexOfSMode + 6, 9);
                    pc.SMode = sMode;

                    //finding 'Date=' and load its data to date
                    int indexOfDate = textOfHRMFile.IndexOf("Date=");
                    date = textOfHRMFile.Substring(indexOfDate + 5, 8);
                    date = date.Insert(4, "-");//Added Dash after 4th letter i.e.YYYYMMDD to YYYY-MMDD
                    date = date.Insert(7, "-");//Added Dash after 7th letter i.e YYYY-MMDD to YYYY-MM-DD
                    pc.Date = date;

                    //finding 'StartTime=' and load its data to startTime
                    int indexOfStartTime = textOfHRMFile.IndexOf("StartTime=");
                    startTime = textOfHRMFile.Substring(indexOfStartTime + 10, 10);
                    pc.StartTime = startTime;

                    //finding 'Length=' and load its data to length
                    int indexOfLength = textOfHRMFile.IndexOf("Length=");
                    length = textOfHRMFile.Substring(indexOfLength + 7, 10);
                    pc.Length = length;

                    //finding 'Interval=' and load its data to interval
                    int indexOfInterval = textOfHRMFile.IndexOf("Interval=");
                    interval = textOfHRMFile.Substring(indexOfInterval + 9, 1);
                    pc.Interval = interval;

                    //finding 'Upper1=' and load its data to upper1 and finally to Upper1
                    int indexOfUpper1 = textOfHRMFile.IndexOf("Upper1=");
                    upper1 = textOfHRMFile.Substring(indexOfUpper1 + 7, 1);
                    pc.Upper1 = upper1;

                    //finding 'Upper2=' and load its data to upper2 and finally to Upper2
                    int indexOfUpper2 = textOfHRMFile.IndexOf("Upper2=");
                    upper2 = textOfHRMFile.Substring(indexOfUpper2 + 7, 1);
                    pc.Upper2 = upper2;

                    //finding 'Upper3=' and load its data to upper3 and finally to Upper3
                    int indexOfUpper3 = textOfHRMFile.IndexOf("Upper3=");
                    upper3 = textOfHRMFile.Substring(indexOfUpper3 + 7, 1);
                    pc.Upper3 = upper3;

                    //finding 'Lower1=' and load its data to lower1 and finally to Lower1
                    int indexOfLower1 = textOfHRMFile.IndexOf("Lower1=");
                    lower1 = textOfHRMFile.Substring(indexOfLower1 + 7, 1);
                    pc.Lower1 = lower1;

                    //finding 'Lower2=' and load its data to lower2 and finally to Lower2
                    int indexOfLower2 = textOfHRMFile.IndexOf("Lower2=");
                    lower2 = textOfHRMFile.Substring(indexOfLower2 + 7, 1);
                    pc.Lower2 = lower2;

                    //finding 'Lower3=' and load its data to lower3 and finally to Lower3
                    int indexOfLower3 = textOfHRMFile.IndexOf("Lower3=");
                    lower3 = textOfHRMFile.Substring(indexOfLower3 + 7, 1);
                    pc.Lower3 = lower3;

                    //finding 'Timer1=' and load its data to timer1 and finally to Timer1
                    int indexOfTimer1 = textOfHRMFile.IndexOf("Timer1=");
                    timer1 = textOfHRMFile.Substring(indexOfTimer1 + 7, 10);
                    pc.Timer1 = timer1;

                    //finding 'Timer2=' and load its data to timer2 and finally to Timer2
                    int indexOfTimer2 = textOfHRMFile.IndexOf("Timer2=");
                    timer2 = textOfHRMFile.Substring(indexOfTimer2 + 7, 10);
                    pc.Timer2 = timer2;

                    //finding 'Timer3=' and load its data to timer3 and finally to Timer3
                    int indexOfTimer3 = textOfHRMFile.IndexOf("Timer3=");
                    timer3 = textOfHRMFile.Substring(indexOfTimer1 + 7, 10);
                    pc.Timer3 = timer3;

                    //finding 'ActiveLimit=' and load its data to activeLimit and then pass it to ActiveLimit
                    int indexOfActiveLimit = textOfHRMFile.IndexOf("ActiveLimit=");
                    activeLimit = textOfHRMFile.Substring(indexOfActiveLimit + 12, 1);
                    pc.ActiveLimit = activeLimit;

                    //finding 'MaxHR' and load its data to maxHR and finally to MaxHR
                    int indexOfMaxHR = textOfHRMFile.IndexOf("MaxHR=");
                    maxHR = textOfHRMFile.Substring(indexOfMaxHR + 6, 3);
                    pc.MaxHR = maxHR;

                    //finding 'RestHR' and load its data to restHR and finally to RestHR
                    int indexOfRestHR = textOfHRMFile.IndexOf("RestHR=");
                    restHR = textOfHRMFile.Substring(indexOfRestHR + 7, 2);
                    pc.RestHR = restHR;

                    //finding 'StartDelay=' and load its data to startDelay and finally to StartDelay
                    int indexOfStartDelay = textOfHRMFile.IndexOf("StartDelay=");
                    startDelay = textOfHRMFile.Substring(indexOfStartDelay + 11, 3);
                    pc.StartDelay = startDelay;

                    //finding 'VO2max=' and load its data to vo2Max and finally to VO2max
                    int indexOfVO2max = textOfHRMFile.IndexOf("VO2max=");
                    vo2Max = textOfHRMFile.Substring(indexOfVO2max + 7, 2);
                    pc.VO2max = vo2Max;

                    //finding 'Weight=' and load its data to weight and finally to Weight
                    int indexOfWeight = textOfHRMFile.IndexOf("Weight=");
                    weight = textOfHRMFile.Substring(indexOfWeight + 7, 3);
                    pc.Weight = weight;
                }
            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show("No hrm data was found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("D:\\College Projects\\DataAnalysisSoftware\\DataAnalysisSoftware\\DataAnalysisSoftware\\Polar HRM Data Analysis System.docx");
            }
            catch (Exception ex)
            {

                MessageBox.Show("we can't find the documentation file");
            }
        }

        private void btnFileComparison_Click(object sender, EventArgs e)
        {
            try
            {
                pnlContent.Controls.Clear(); //Clear Existing controls

                SelectDataToCompare frm = new SelectDataToCompare();
                frm.TopLevel = false;
                pnlContent.Controls.Add(frm);
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnIntervalDetection_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text == "")
                {
                    MessageBox.Show("You need to choose Polar HRM File to view data");
                    btnLoadData.Focus();
                }
                else
                {
                    pnlContent.Controls.Clear(); //Clear Existing controls
                    IntervalDetection frm = new IntervalDetection();
                    frm.TopLevel = false;
                    pnlContent.Controls.Add(frm);
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Interval Detection
        /// </summary>
        public void IntervalDetection()
        {
            double ThresholdPower = Math.Round((105 * ftpGlobal) / 100, 2);
            int powerDown = 1;
            int powerUp = 1;
            double intervalValue = 0;
            try
            {
                foreach (double powerDataValue in powerData)
                {
                    if (ThresholdPower >= powerDataValue)
                    {
                        powerDown = 1;
                    }
                    if (powerDown == 1)
                    {
                        if (ThresholdPower<=powerDataValue)
                        {
                            powerUp = 1;
                        }
                    }
                    if (powerUp==1)
                    {
                        intervalValue++;
                        powerUp = 0;
                        powerDown = 0;
                    }
                    intervalDetectionData.Add(intervalValue);
                    powerInterval.Add(powerDataValue);
                    threholdValueGlobal = ThresholdPower;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void intervalDetectionSlt()
        {
            double thresholdPower = Math.Round((105 * ftpGlobal) / 100, 2);
            int powerDown = 1;
            int powerUp = 1;
            double intervalValue = 0;
            try
            {
                foreach(double powerDataV in powerData)
                {
                    if (thresholdPower>=powerDataV)
                    {
                        powerDown = 1;
                    }
                    if (powerDown==1)
                    {
                        if (thresholdPower <= powerDataV)
                            powerUp = 1;
                    }
                    if (powerUp == 1)
                    {
                        intervalValue++;
                        powerUp = 0;
                        powerDown = 0;
                    }
                    intervalDetectionData.Add(intervalValue);
                    powerInterval.Add(powerDataV);
                    threholdValueGlobal = thresholdPower;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
       
            
    }
}
