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
    public partial class Form1 : Form
    {
        public Form1()
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
                if (dr==DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
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
            int lineNo;
            try
            {
                string fileContent = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
