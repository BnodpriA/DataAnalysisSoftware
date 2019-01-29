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
using System.Text.RegularExpressions;
using System.Collections;

namespace DataAnalysisSoftware
{
    public partial class DataSummary : Form
    {
        public DataSummary()
        {
            InitializeComponent();
        }
        public string fileName;
        private string singleLine;
        private string defaultUnit = "0";


        public string deviceName;
        public string version;
        public string monitor;
        public string sMode;
        public string date;
        public string startTime;
        public string length;
        public string interval;
        public string upper1;
        public string upper2;
        public string upper3;
        public string lower1;
        public string lower2;
        public string lower3;
        public string timer1;
        public string timer2;
        public string timer3;
        public string activeLimit;
        public string maxHR;
        public string restHR;
        public string startDelay;
        public string vo2Max;
        public string weight;

        double totalSpeed;
        double totalCadence;
        double totalAltitude;
        int totalHeartRate;
        double totalPower;

        double averageSpeed;
        double averageCadence;
        double averageAltitude;
        int averageHeartRate;
        double averagePower;

        double maxSpeed;
        
        IDictionary<string, string> param = new Dictionary<string, string>();
        ArrayList hra = new ArrayList();
        ParameterClass pc = new ParameterClass();
        MasterClass mc = new MasterClass();
        HRDataClass hrdc = new HRDataClass();
        private void DataSummary_Load(object sender, EventArgs e)
        {

           // cmbSpeedUnit.SelectedIndex = -1;
            ShowOrHidePowerBySMode();
            DefaultSpeedUnitBySMode();
            
            lblMonitorType.Text = GetPolarDeviceName(Convert.ToInt32(monitor));
            lblDeviceVersion.Text = version;
            lblSMode.Text = sMode;
            lblDate.Text = date;
            lblStartTime.Text = startTime;
            lblInterval.Text = interval;
            lblLength.Text = length;
            lblMaxHR.Text = maxHR;
            lblRestHR.Text = restHR;
            lblVO2max.Text = vo2Max;
            lblWeight.Text = weight;
            
            ReadHRData();
            LoadSerialNumber();
            ReturnMaxMinHRMValues();
            CalculateAverageHeartRate();
            CalculateAverageSpeed();
            CalculateAverageCadence();
            CalculateAverageAltitude();
            CalculateAveragePower();

            

        }
        /// <summary>
        /// Load Serial Number
        /// </summary>
        private void LoadSerialNumber()
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvHRMData.Rows)
            {
                row.Cells["SNo"].Value = i;
                i++;
                i.ToString();
            }
        }
        public static string[] SplitParm(string line)
        {
            return line.Split('=');
        }
        public static string[] SplitData(string line)
        {
            return Regex.Split(line, @"\W+");
        }
        /// <summary>
        /// Display Date in Understandable formate i.e. 20130205 to 2013/02/05 (YYYY/MM/DD) Format
        /// </summary>
        private void ManageDateFormate()
        {
            
        }

        public void LoadData()
        {

        }
        /// <summary>
        /// Return Device Name or Monitor type by reading monitor number from hrm file
        /// </summary>
        /// <param name="monitor"></param>
        /// <returns></returns>
        private static string GetPolarDeviceName(int monitor)
        {
            string deviceName = "HEART RATE MONITOR TYPE";
            switch (monitor)
            {
                case 1:
                    {
                        deviceName = "POLAR SPORT TESTER/ VANTAGE";
                        break;
                    }
                case 2:
                    {
                        deviceName = "POLAR VANTAGE NV (VNV)";
                        break;
                    }
                case 3:
                    {
                        deviceName = "POLAR ACCUREX PlUS";
                        break;
                    }
                case 4:
                    {
                        deviceName = "POLAR XTRAINER PLUS";
                        break;
                    }
                case 6:
                    {
                        deviceName = "POLAR S520";
                        break;
                    }
                case 7:
                    {
                        deviceName = "POLAR COACH";
                        break;
                    }
                case 8:
                    {
                        deviceName = "POLAR S210";
                        break;
                    }
                case 9:
                    {
                        deviceName = "POLAR S410";
                        break;
                    }
                case 10:
                    {
                        deviceName = "POLAR S510";
                        break;
                    }
                case 11:
                    {
                        deviceName = "POLAR S610 / S610I";
                        break;
                    }
                case 12:
                    {
                        deviceName = "POLAR S710 / S710I / S720I";
                        break;
                    }
                case 13:
                    {
                        deviceName = "POLAR S810 / S810I";
                        break;
                    }
                case 15:
                    {
                        deviceName = "POLAR E600";
                        break;
                    }
                case 20:
                    {
                        deviceName = "POLAR AXN500";
                        break;
                    }
                case 21:
                    {
                        deviceName = "POLAR AXN700";
                        break;
                    }
                case 22:
                    {
                        deviceName = "POLAR S625X / S725X";
                        break;
                    }
                case 23:
                    {
                        deviceName = "POLAR S725";
                        break;
                    }
                case 33:
                    {
                        deviceName = "POLAR CS400";
                        break;
                    }
                case 34:
                    {
                        deviceName = "POLAR CS600X";
                        break;
                    }
                case 35:
                    {
                        deviceName = "POLAR CS600";
                        break;
                    }
                case 36:
                    {
                        deviceName = "POLAR RS400";
                        break;
                    }
                case 37:
                    {
                        deviceName = "POLAR RS800";
                        break;
                    }
                case 38:
                    {
                        deviceName = "POLAR RS800X";
                        break;
                    }
                default:
                    break;
            }
            return deviceName;
        }
        private void CalculateAverageSpeed()
        {
            try
            {
                totalSpeed = 0;
                for (int i = 0; i < dgvHRMData.Rows.Count; i++)
                {
                    totalSpeed += Convert.ToDouble(dgvHRMData.Rows[i].Cells["Speed"].Value.ToString());
                }
                averageSpeed = totalSpeed / (Convert.ToDouble(dgvHRMData.Rows.Count));
                lblAvgSpeed.Text = averageSpeed.ToString("N2");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CalculateAverageCadence()
        {
            try
            {
                totalCadence = 0;
                for (int i = 0; i < dgvHRMData.Rows.Count; i++)
                {
                    totalCadence += Convert.ToDouble(dgvHRMData.Rows[i].Cells["Cadence"].Value.ToString());
                }
                averageCadence = totalCadence / (Convert.ToDouble(dgvHRMData.Rows.Count));
                lblAvgCadence.Text = averageCadence.ToString("N2");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CalculateAverageAltitude()
        {
            try
            {
                totalAltitude = 0;
                for (int i = 0; i < dgvHRMData.Rows.Count; i++)
                {
                    totalAltitude += Convert.ToDouble(dgvHRMData.Rows[i].Cells["Altitude"].Value.ToString());
                }
                averageAltitude = totalAltitude / (Convert.ToDouble(dgvHRMData.Rows.Count));
                lblAvgAltitude.Text = averageAltitude.ToString("N2");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CalculateAverageHeartRate()
        {
            try
            {
                totalHeartRate = 0;
                for (int i = 0; i < dgvHRMData.Rows.Count; i++)
                {
                    totalHeartRate += Convert.ToInt32(dgvHRMData.Rows[i].Cells["HeartRate"].Value.ToString());
                }
                averageHeartRate = totalHeartRate / (Convert.ToInt32(dgvHRMData.Rows.Count));
                lblAvgHeartRate.Text = averageHeartRate.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CalculateAveragePower()
        {
            try
            {
                totalPower = 0;
                for (int i = 0; i < dgvHRMData.Rows.Count; i++)
                {
                    totalPower += Convert.ToDouble(dgvHRMData.Rows[i].Cells["Power"].Value.ToString());
                }
                averagePower = totalPower / (Convert.ToDouble(dgvHRMData.Rows.Count));
                lblAvgPower.Text = averagePower.ToString("N2");
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Convert Speed From KM per hours to Mile per Hour if h=0 for SMode
        /// </summary>
        /// <param name="kmph"></param>
        /// <returns></returns>
        private double ConvertSpeedKMPHToMPH( double kmph)
        {
            return 0.614 * kmph;
        }
        /// <summary>
        /// 
        /// </summary>
        private double ConvertSpeedMPHToKMPH(double mph)
        {
            return mph * 1.60934;
        }
        private void ReturnMaxMinHRMValues()
        {
            ///Finding max and min value from Speed Column of dgvHRMData DataGridView
            double[] columnSpeed = (from DataGridViewRow row in dgvHRMData.Rows
                                    where row.Cells["Speed"].FormattedValue.ToString() != string.Empty
                                    select Convert.ToDouble(row.Cells["Speed"].FormattedValue)).ToArray(); //Selected all the value from Speed Column of dgvHRMData
            lblMaxSpeed.Text = columnSpeed.Max().ToString();//retrun the max value in Speed Column to lblMaxSpeed
            lblMinSpeed.Text = columnSpeed.Min().ToString();
            maxSpeed = Convert.ToDouble(columnSpeed.Max().ToString());

            ///Finding max and min value from Cadence Column of dgvHRMData DataGridView
            int[] columnCadence = (from DataGridViewRow row in dgvHRMData.Rows
                                   where row.Cells["Cadence"].FormattedValue.ToString() != string.Empty
                                   select Convert.ToInt32(row.Cells["Cadence"].FormattedValue)).ToArray();
            lblMaxCadence.Text = columnCadence.Max().ToString();
            lblMinCadence.Text = columnCadence.Min().ToString();

            ///Finding max and min value from Altitude Column of dgvHRMData DataGridView
            int[] columnAltitude = (from DataGridViewRow row in dgvHRMData.Rows
                                    where row.Cells["Altitude"].FormattedValue.ToString() != string.Empty
                                    select Convert.ToInt32(row.Cells["Altitude"].FormattedValue)).ToArray();

            ///Finding max and min value from HeartRate Column of dgvHRMData DataGridView
            int[] columnHeartRate = (from DataGridViewRow row in dgvHRMData.Rows
                                  where row.Cells["HeartRate"].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells["HeartRate"].FormattedValue)).ToArray();
            lblMaxHeartRate.Text = columnHeartRate.Max().ToString();
            lblMinHeartRate.Text = columnHeartRate.Min().ToString();

            ///Finding max and min value from Power Column of dgvHRMData DataGridView
            int[] columnPower = (from DataGridViewRow row in dgvHRMData.Rows
                                 where row.Cells["Power"].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells["Power"].FormattedValue)).ToArray();
            lblMaxPower.Text = columnPower.Max().ToString();
            lblMinPower.Text = columnPower.Min().ToString();
            
        }

        private void ReadHRData()
        {
            //string fileContent = File.ReadAllText(data);
            //int indexOfHRData = fileContent.IndexOf("[HRData]");
            //string formatedHRData = fileContent.Substring(indexOfHRData + 10, fileContent.Length - (indexOfHRData + 10));
            //StreamReader hrmDataReader = new StreamReader(formatedHRData);
            //int row = 0;
            //while(
            try
            {
                string fileContent = File.ReadAllText(fileName);
                string toFind = "[HRData]";
                int index = fileContent.IndexOf(toFind);
                string formattedFileContent = fileContent.Substring(index + 10, fileContent.Length - (index + 10));
                StringReader stringReader = new StringReader(formattedFileContent);
                int row = 0;
                while ((singleLine = stringReader.ReadLine()) != null)
                {
                    string[] columnData = singleLine.Split('\t');
                    dgvHRMData.Rows.Add();
                    for (int i = 1; i < columnData.Length; i++)
                    {
                        dgvHRMData[i, row].Value = columnData[i];
                    }
                    row++;
                }
            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadSummartData()
        {
            List<int> heartRate = new List<int>();
            List<double> speed = new List<double>();
            List<int> cadence = new List<int>();
            List<int> altitude = new List<int>();
            List<int> power = new List<int>();
            foreach (DataGridViewRow row in dgvHRMData.Rows) 
            {
                heartRate.Add(Convert.ToInt32(row.Cells["HeartRate"].Value.ToString()));
                speed.Add(Convert.ToDouble(row.Cells["Speed"].Value.ToString()));
                cadence.Add(Convert.ToInt32(row.Cells["Cadence"].Value.ToString()));
                altitude.Add(Convert.ToInt32(row.Cells["Altitude"].Value.ToString()));
                power.Add(Convert.ToInt32(row.Cells["Power"].Value.ToString()));
            }
            hrdc.HeartRate = heartRate.ToArray();
            
        }

        private void cmbSpeedUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpeedUnit.Text== "km/h")
            {
                lblMaxSpeed.Text = maxSpeed.ToString();
            }
            else
            {
                maxSpeed = ConvertSpeedKMPHToMPH(maxSpeed);
                lblMaxSpeed.Text = maxSpeed.ToString();
            }
        }
        private void ShowOrHidePowerBySMode()
        {
            try
            {
                if (fileName != "")
                {

                    //DataSummary ds = new DataSummary();
                    StreamReader sModeReader = new StreamReader(fileName, Encoding.Default);
                    string textOfSMode = sModeReader.ReadToEnd();
                    int indexOfSMode = textOfSMode.IndexOf("SMode=");
                    string speedStatus = textOfSMode.Substring(indexOfSMode + 6, 1);
                    string cadenceStatus = textOfSMode.Substring(indexOfSMode + 7, 1);
                    string altitudeStatus = textOfSMode.Substring(indexOfSMode + 8, 1);
                    string powerStatus = textOfSMode.Substring(indexOfSMode + 9, 1);

                    if (speedStatus.ToString()=="0")
                    {
                        dgvHRMData.Columns[2].Visible = false;
                    }
                    else if (speedStatus.ToString()=="1")
                    {
                        dgvHRMData.Columns[2].Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid SMode 'a' value  for Speed, a must be 0=off or 1=on");
                        dgvHRMData.Columns[2].Visible = false;
                    }

                    //Checking SMode value for (b) or cadence
                    if (cadenceStatus.ToString() == "0")
                    {
                        dgvHRMData.Columns[3].Visible = false;//Column[3] is for Cadence
                    }
                    else if (cadenceStatus.ToString() == "1")
                    {
                        dgvHRMData.Columns[3].Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid SMode 'b' value  for Cadence, b must be 0=off or 1=on");
                        dgvHRMData.Columns[3].Visible = false;
                    }

                    //Checking SMode value for (c) or Altitude
                    if (altitudeStatus.ToString() == "0")
                    {
                        dgvHRMData.Columns[4].Visible = false;
                    }
                    else if (altitudeStatus.ToString() == "1")
                    {
                        dgvHRMData.Columns[4].Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid SMode 'c' value  for Altitude, c must be 0=off or 1=on");
                        dgvHRMData.Columns[4].Visible = false;
                    }

                    ///Show or Hide Power based on SMode if d=1 show else d=0 hide Power Column
                    if (powerStatus.ToString() == "0")
                    {
                        dgvHRMData.Columns[5].Visible = false;
                    }
                    else if(powerStatus.ToString()=="1")
                    {
                        dgvHRMData.Columns[5].Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid SMode 'd' value  for Power, d must be 0=off or 1=on");
                        dgvHRMData.Columns[5].Visible = false;
                    }
                }
            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show("No hrm data was found");
            }
        }
        private void DefaultSpeedUnitBySMode()
        {
            try
            {
                if (fileName != "")
                {
                    StreamReader sModeReader = new StreamReader(fileName, Encoding.Default);
                    string textOfSMode = sModeReader.ReadToEnd();
                    int indexOfSMode = textOfSMode.IndexOf("SMode=");
                    defaultUnit = textOfSMode.Substring(indexOfSMode + 13, 1);
                    if (defaultUnit.ToString() == "0") 
                    {
                        MessageBox.Show("default unit is km/h with values of h = " + defaultUnit);
                        cmbSpeedUnit.Text = "km/h";
                    }
                    else if (defaultUnit.ToString() == "1")
                    {
                        MessageBox.Show("default unit is mph with values of h = " + defaultUnit);
                        cmbSpeedUnit.Text= "mph";
                    }
                    else
                    {
                        MessageBox.Show("values of h = " + defaultUnit + "So Unit of Speed is Invalid");
                        cmbSpeedUnit.SelectedIndex = -1;
                    }
                   
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No hrm data was found");
            }
        }

        private void dgvHRMData_MouseUp(object sender, MouseEventArgs e)
        {
            NoOfChunks frm = new NoOfChunks();
            frm.ShowDialog();
        }
    }
}
