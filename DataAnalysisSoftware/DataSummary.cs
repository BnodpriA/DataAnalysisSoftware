using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace DataAnalysisSoftware
{
    public partial class DataSummary : Form
    {
        public DataSummary()
        {
            InitializeComponent();
        }
        public string fileName;
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

        ParameterClass pc = new ParameterClass();
        MasterClass mc = new MasterClass();
        private void DataSummary_Load(object sender, EventArgs e)
        {
          
            cmbSpeedUnit.SelectedIndex = 0; //Set the initial unit of the speed
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
    }
}
