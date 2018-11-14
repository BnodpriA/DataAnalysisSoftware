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
    public partial class DataAnalysisSystemPanel : Form
    {
        public DataAnalysisSystemPanel()
        {
            InitializeComponent();
        }

        private void DataAnalysisSystemPanel_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// /Open Dialog to search hrm file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Title = "Open .HRM file";
            opd.Filter = "HRM files (*.hrm|*.hrm|All files (*.*)|*.*";
        }
    }
}
