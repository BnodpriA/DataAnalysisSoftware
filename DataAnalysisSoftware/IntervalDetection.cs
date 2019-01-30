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
            try
            {
                lblThresholdPower.Text = DataAnalysisSystemPanel.threholdValueGlobal.ToString();
                for (int i = 0; i < DataAnalysisSystemPanel.intervalDetectionData.Count(); i++)
                {
                    dgvIntervalInformation.ClearSelection();
                    dgvIntervalInformation.Rows.Add();
                    dgvIntervalInformation.Rows[i].Cells[1].Value = "Interval " + DataAnalysisSystemPanel.intervalDetectionData[i];
                    dgvIntervalInformation.Rows[i].Cells[2].Value = DataAnalysisSystemPanel.powerInterval[i];
                }

                for (int j = 0; j <=DataAnalysisSystemPanel.intervalDetectionData.Last(); j++)
                {
                    lbIntervals.Items.Add("Interval " + j);
                }
                DetectInterval();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}