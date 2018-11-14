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
    public partial class DataSummary : Form
    {
        public DataSummary()
        {
            InitializeComponent();
        }

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
    }
}
