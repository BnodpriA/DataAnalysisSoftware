using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataAnalysisSoftware
{
    public partial class FileComparison : Form
    {
        string dateFinal;
        double ftpGlobal;
        double ifGlobal;
        double tssGlobal;
        double avgPowerGlobal;
        double normalizationPowerGlobal;
        List<double> powerData = new List<double>();
        double averagePower;
        //int timeArrCount = 0;
        //public static List<TimeSpan> totalTime = new List<TimeSpan>();
        TimeSpan startTime, endTime;
        string lengthValue;
        double totalDistance;
        double averageSpeed;
        IDictionary<string, string> param = new Dictionary<string, string>();
        public static double maxSpeed { get; set; }
        public static double averageSpeedMiles { get; set; }
        public static double maxSpeedMiles { get; set; }
        public static double averageHeartRate { get; set; }
        public static double maxHeartRate { get; set; }
        public static double minHeartRate { get; set; }
        public static double maxPower { get; set; }
        public static double averageAltitude { get; set; }
        public static double maxAltitude { get; set; }
        public static double averageAltitudeMile { get; set; }
        public static double maxAltitudeMile { get; set; }
        public static double totalDistanceMiles { get; set; }
        List<double> powerDataSlt = new List<double>();


        /// <summary>
        /// variable declarations for the calculaton of movn power
        /// </summary>
        List<double> movAvgPow4 = new List<double>();
        List<double> movAvg = new List<double>();
        List<double> movAvgPow4Slt = new List<double>();
        List<double> movAvgSlt = new List<double>();

        double movAvgCount;

        List<string> files = new List<string>();
        public FileComparison(List<string> file)
        {
            InitializeComponent();
            this.files = file;
                
        }




        private void FileComparison_Load(object sender, EventArgs e)
        {
            int i = 1;
            try
            {
                //fetch data from file and fill the TAbles according to the values 
                //in the given fies 
                foreach (string file in files)
                {
                    if (i == 1)
                    {
                        //fileReader(i, file, dgvHRMDataOfFirstFile);
                        //mainSummary(i, dgvHRMDataOfSecondFile);
                    }
                    else if (i == 2)
                    {
                        //fileReader(i, file, dgvHRMDataOfSecondFile);
                        mainSummary(i, dgvHRMDataOfSecondFile
);
                    }

                    i++;

                }

                // If the two gridview have the same number of column and row :

                for (int k = 0; k < dgvHRMDataOfFirstFile.Rows.Count; k++)
                {
                    var row1 = dgvHRMDataOfFirstFile.Rows[k].Cells.Count;
                    //int d1 = dataGridViewfile1.Rows[k].Cells[j].Value;
                    // var row2 = src2.Rows[k].ItemArray;

                    for (int j = 1; j <= 6; j++)
                    {
                        string d1 = dgvHRMDataOfFirstFile.Rows[k].Cells[j].Value.ToString();
                        int g1 = Convert.ToInt32(d1);
                        string d2 = dgvHRMDataOfSecondFile.Rows[k].Cells[j].Value.ToString();
                        int g2 = Convert.ToInt32(d2);
                        if (g1 > g2)
                        {
                            dgvHRMDataOfFirstFile.Rows[k].Cells[j].Style.BackColor = Color.Green;
                            dgvHRMDataOfSecondFile.Rows[k].Cells[j].Style.BackColor = Color.Red;
                        }
                        else if (g1 < g2)
                        {
                            dgvHRMDataOfSecondFile.Rows[k].Cells[j].Style.BackColor = Color.Green;
                            dgvHRMDataOfFirstFile.Rows[k].Cells[j].Style.BackColor = Color.Red;

                        }
                        else if (g1 == g2)
                        {
                            dgvHRMDataOfFirstFile.Rows[k].Cells[j].Style.BackColor = Color.Yellow;
                            dgvHRMDataOfSecondFile.Rows[k].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        string fileData;
        string startTimeValue, intervalValue;
        int count = 0;
        int timeArrCount = 0;
        public static List<TimeSpan> totalTime = new List<TimeSpan>();
        public static string smode { get; set; }
        private void mainSummary(int fileNumber, DataGridView dataGridViewfile1)
        {

            try
            {
                int grdCount = dataGridViewfile1.Rows.Count;
                double[] hr = new double[grdCount];
                double[] sp = new double[grdCount];
                double[] cd = new double[grdCount];
                double[] al = new double[grdCount];
                double[] po = new double[grdCount];


                int i = 0;
                foreach (DataGridViewRow row in dataGridViewfile1.Rows)
                {
                    hr[i] = Convert.ToDouble(row.Cells[1].Value);
                    sp[i] = Convert.ToDouble(row.Cells[2].Value);
                    cd[i] = Convert.ToDouble(row.Cells[3].Value);
                    al[i] = Convert.ToDouble(row.Cells[4].Value);
                    po[i] = Convert.ToDouble(row.Cells[5].Value);


                    i++;
                }
                // chunkDataSummary();
                calculate(fileNumber, hr, sp, cd, al, po);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void calculate(int fileno, double[] hr, double[] sp, double[] cd, double[] al, double[] po)
        {
            int count = hr.Length;
            double maxhr = hr.Max();
            double avgHR = hr.Average();
            double minHR = hr.Min();
            double maxsp = sp.Max();
            double avgsp = sp.Average();
            double maxal = al.Max();
            double avgal = al.Average();
            double maxpo = po.Max();
            double avgpo = po.Average();


            try
            {
                if (fileno == 1)
                {
                    avgHeartRatef1.Text = avgHR.ToString();
                    maxHeartRate1.Text = maxhr.ToString();
                    minHRf1.Text = minHR.ToString();
                    f1sp.Text = avgsp.ToString();
                    maxspf1.Text = maxsp.ToString();

                    apf1.Text = avgpo.ToString();
                    avgaf1.Text = avgal.ToString();
                    maxaf1.Text = maxal.ToString();
                    maxpf1.Text = maxpo.ToString();
                }
                else if (fileno == 2)
                {
                    avgHeartRatef2.Text = avgHR.ToString();
                    maxhrf2.Text = maxhr.ToString();
                    minHRf2.Text = minHR.ToString();
                    f2sp.Text = avgsp.ToString();
                    maxspf2.Text = maxsp.ToString();

                    apf2.Text = avgpo.ToString();
                    avgaf2.Text = avgal.ToString();
                    maxaf2.Text = maxal.ToString();
                    maxpf2.Text = maxpo.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ////plusMinus();
        }
        private void LoadSerialNumber()
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvHRMDataOfFirstFile.Rows)
            {
                row.Cells["SNo"].Value = i;
                i++;
                i.ToString();
            }
        }

        private void dgvHRMDataOfFirstFile_MouseUp(object sender, MouseEventArgs e)
        {
            NoOfChunks frm = new NoOfChunks();
            frm.ShowDialog();
        }

        private void dgvHRMDataOfSecondFile_MouseUp(object sender, MouseEventArgs e)
        {
            NoOfChunks frm = new NoOfChunks();
            frm.ShowDialog();
        }

        public static string[] SplitParm(string line)
        {
            return line.Split('=');
        }
        public static string[] SplitData(string line)
        {
            return Regex.Split(line, @"\W+");
        }
    }
}
