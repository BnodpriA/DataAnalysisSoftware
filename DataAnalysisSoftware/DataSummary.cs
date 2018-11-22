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
        private void DataSummary_Load(object sender, EventArgs e)
        {
            cmbSpeedUnit.SelectedIndex = 0; //Set the initial unit of the speed
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
            string deviceName = null;
            switch (monitor)
            {
                case 1:
                    {
                        deviceName = "Polar Sport Tester/ Vantage";
                        break;
                    }
                case 2:
                    {
                        deviceName = "Polar Vantage NV (VNV)";
                        break;
                    }
                case 3:
                    {
                        deviceName = "Polar Accurex Plus";
                        break;
                    }
                case 4:
                    {
                        deviceName = "Polar XTrainer Plus";
                        break;
                    }
                case 6:
                    {
                        deviceName = "Polar S520";
                        break;
                    }
                case 7:
                    {
                        deviceName = "Polar Coach";
                        break;
                    }
                case 8:
                    {
                        deviceName = "Polar S210";
                        break;
                    }
                case 9:
                    {
                        deviceName = "Polar S410";
                        break;
                    }
                case 10:
                    {
                        deviceName = "Polar S510";
                        break;
                    }
                case 11:
                    {
                        deviceName = "Polar S610 / S610i";
                        break;
                    }
                case 12:
                    {
                        deviceName = "Polar S710 / S710i / S720i";
                        break;
                    }
                case 13:
                    {
                        deviceName = "Polar S810 / S810i";
                        break;
                    }
                case 15:
                    {
                        deviceName = "Polar E600";
                        break;
                    }
                case 20:
                    {
                        deviceName = "Polar AXN500";
                        break;
                    }
                case 21:
                    {
                        deviceName = "Polar AXN700";
                        break;
                    }
                case 22:
                    {
                        deviceName = "Polar S625X / S725X";
                        break;
                    }
                case 23:
                    {
                        deviceName = "Polar S725";
                        break;
                    }
                case 33:
                    {
                        deviceName = "Polar CS400";
                        break;
                    }
                case 34:
                    {
                        deviceName = "Polar CS600X";
                        break;
                    }
                case 35:
                    {
                        deviceName = "Polar CS600";
                        break;
                    }
                case 36:
                    {
                        deviceName = "Polar RS400";
                        break;
                    }
                case 37:
                    {
                        deviceName = "Polar RS800";
                        break;
                    }
                case 38:
                    {
                        deviceName = "Polar RS800X";
                        break;
                    }
                default:
                    break;
            }
            return deviceName;
        }
    }
}
