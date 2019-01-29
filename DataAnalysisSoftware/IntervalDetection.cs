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
    public partial class IntervalDetection : Form
    {
        public IntervalDetection()
        {
            InitializeComponent();
        }

        public void DetectInterval()
        {
            List<double> powerAv = new List<double>();
            foreach (DataGridViewRow row in dgvIntervalInformation.Rows)
            {
                powerAv.Add(Convert.ToDouble(row.Cells[2]));
                double intervalAvg = powerAv.Average();
                lblAveragePower.Text = intervalAvg.ToString();
            }
        }

        private void IntervalDetection_Load(object sender, EventArgs e)
        {
            int v = 0;
            try
            {
                lblThresholdPower.Text=OpenFileDialog.inte
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}