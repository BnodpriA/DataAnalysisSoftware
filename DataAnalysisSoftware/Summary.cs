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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }
        string filePath = @"E:\test.text";
        /// <summary>
        /// Create File Dialog to choose the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                    if (File.Exists(filePath))
                        ProcessFile(filePath);
                    else
                        MessageBox.Show("Error, no file selected");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        //StreamReader files = new StreamReader("test.text");
        //  string[] columnNames = File.ReadLines
        public void LoadData()
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvDataInfo.Rows)
            {

            }
        }
        /// <summary>
        /// This method process the data in the file
        /// </summary>
        /// <param name="filePath"></param>
        public void ProcessFile(String filePath)
        {
            string oneLine;
            try
            {
                string fileContent = File.ReadAllText(filePath); //open a text file, read all the lines of the file and then closes the file from the selected path
                string[] fileLines = File.ReadAllLines(filePath);
                foreach (string line in fileLines)
                    dgvDataInfo.Rows.Add();
                StreamReader myFileReader = new StreamReader(filePath);
                while ((oneLine = myFileReader.ReadLine()) != null)
                {
                    string[] words = oneLine.Split(' ');
                    foreach (DataGridViewRow row in dgvDataInfo.Rows)
                    {
                        double Speed = 0, Cadence = 0, Altitude = 0, HeartRate = 0, Power = 0;
                        for (int i = 0; i < words.Length; i++)
                        {
                            row.Cells["Speed"].Value = words[0];
                            row.Cells["Cadence"].Value = words[1];
                            row.Cells["Altitude"].Value = words[2];
                            row.Cells["HeartRate"].Value = words[3];
                            row.Cells["Power"].Value = words[4];
                        }
                    }
                }
                
                myFileReader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        // System.IO.StreamReader file = new System.IO.StreamReader("yourfile.txt");
        // string[] columnnames = File.ReadAllLines(File)
        //// string[] columnnames = file.ReadLine().Split(' ');
        //void DataDisplay()
        //{
        //    DataTable dt = new DataTable();
        //    foreach (string c in columnnames)
        //    {
        //        dt.Columns.Add(c);
        //    }
        //    string newline;
        //    while ((newline = file.ReadLine()) != null)
        //    {
        //        DataRow dr = dt.NewRow();
        //        string[] values = newline.Split(' ');
        //        for (int i = 0; i < values.Length; i++)
        //        {
        //            dr[i] = values[i];
        //        }
        //        dt.Rows.Add(dr);
        //    }
        //    file.Close();
        //    dgvDataInfo.DataSource = dt;
        //}

    }
}
