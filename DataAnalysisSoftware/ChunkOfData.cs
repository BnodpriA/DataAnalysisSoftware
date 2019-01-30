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
    public partial class ChunkOfData : Form
    {
        double[] hr, sp, cd, al, po;

        int count;
        int ChunkDivision;
        int chunkNumber = 0;

        private void ChunkOfData_Load(object sender, EventArgs e)
        {
            chunkSectionsSummary();
        }

        /// <summary>
        /// Declaring parameter in constructor
        /// </summary>
        /// <param name="chunkNumber"></param>
        /// <param name="hr"></param>
        /// <param name="sp"></param>
        /// <param name="cd"></param>
        /// <param name="al"></param>
        /// <param name="po"></param>
        public ChunkOfData(int chunkNumber, double[] hr, double[] sp, double[] cd, double[] al, double[] po)
        {
            InitializeComponent();
            this.hr = hr;
            this.sp = sp;
            this.cd = cd;
            this.al = al;
            this.po = po;
            count = hr.Length;
            this.chunkNumber = chunkNumber;
            ChunkDivision = count / chunkNumber;
        }

        public void chunkSectionsSummary()
        {
            // int chunkValue = new ChunkData().sendChunkValue();

            int chunkStart = 0;
            int countVal = 0;
            int countHR = 0;
            try
            {
                while (chunkStart < chunkNumber)
                {
                    double[] heartChunkValue = new double[ChunkDivision];
                    double[] sp1 = new double[ChunkDivision];
                    double[] cd1 = new double[ChunkDivision];
                    double[] al1 = new double[ChunkDivision];
                    double[] po1 = new double[ChunkDivision];
                    int i = 0;
                    for (int k = countVal; k < ChunkDivision + countVal; k++)
                    {
                        heartChunkValue[i] = hr[k];
                        sp1[i] = sp[k];
                        cd1[i] = cd[k];
                        al1[i] = al[k];
                        po1[i] = po[k];
                        countHR++;
                        i++;

                    }
                    countVal = countHR;
                    chunkStart++;
                    //  if(heartChunkValue.Length<ChunkDivison)
                    calculateData(chunkStart, heartChunkValue, sp1, cd1, al1, po1);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void calculateData(int chunkNo, double[] hr, double[] sp, double[] cd, double[] al, double[] po)
        {
            //put logic here for km/miles
            double maxhr = hr.Max();
            double avgHR = hr.Sum() / ChunkDivision;
            double min = hr.Min();

            double maxsp = sp.Max();
            double avgsp = sp.Sum() / ChunkDivision;

            double avgal = al.Sum() / ChunkDivision;
            double maxal = al.Max();

            double avpo = po.Sum() / ChunkDivision;
            double maxpo = po.Max();

            switch (chunkNo)
            {
                case 1:
                    {
                        avgHeartRate1.Text = avgHR.ToString();
                        maxHeartRate1.Text = maxhr.ToString();
                        minHR1.Text = min.ToString();
                        averagesp1.Text = avgsp.ToString();
                        maxsp1.Text = maxsp.ToString();
                        aa1.Text = avgal.ToString();
                        maxa1.Text = maxal.ToString();
                        ap1.Text = avpo.ToString();
                        maxp1.Text = maxpo.ToString();
                        // td1.Text=
                        break;
                    }
                case 2:
                    {
                        averagehrate2.Text = avgHR.ToString();
                        maxHR2.Text = maxhr.ToString();
                        minHR2.Text = min.ToString();


                        averagesp2.Text = avgsp.ToString();
                        maxsp2.Text = maxsp.ToString();
                        aa2.Text = avgal.ToString();
                        maxa2.Text = maxal.ToString();
                        ap2.Text = avpo.ToString();
                        maxp2.Text = maxpo.ToString();
                        break;
                    }
                case 3:
                    {
                        tbChunksOfData.TabPages[2].Visible = true;
                        averagehr3.Text = avgHR.ToString();
                        maxhr3.Text = maxhr.ToString();
                        minhr3.Text = min.ToString();

                        averagesp3.Text = avgsp.ToString();
                        maxsp3.Text = maxsp.ToString();
                        aa3.Text = avgal.ToString();
                        maxa3.Text = maxal.ToString();
                        ap3.Text = avpo.ToString();
                        maxp3.Text = maxpo.ToString();
                        break;
                    }
                case 4:
                    {
                        tbChunksOfData.TabPages[3].Visible = true;
                        averagehr4.Text = avgHR.ToString();
                        maxhr4.Text = maxhr.ToString();
                        minhr4.Text = min.ToString();

                        averagesp4.Text = avgsp.ToString();
                        maxsp4.Text = maxsp.ToString();
                        aa4.Text = avgal.ToString();
                        maxa4.Text = maxal.ToString();
                        ap4.Text = avpo.ToString();
                        maxp4.Text = maxpo.ToString();
                        break;

                    }
            }

        }
        private void cmbSpeedUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
