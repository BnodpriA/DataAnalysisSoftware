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
    public partial class SelectDataToCompare : Form
    {
        public SelectDataToCompare()
        {
            InitializeComponent();
        }
        string fn1, fn2;
        List<string> filenames = new List<string>();

        private void btnUploadSecondFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "hrm|*.hrm|All|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fn2 = "File Two = " + open.FileName; // name of the browsed file 

            }
            if (fn2.Equals(fn1))
            {
                MessageBox.Show("Cannot insert two files of same name try again.");
            }
            else
            {
                filenames.Add(fn2);
                lblFileTwo.Text = Path.GetFileName(fn2);
                lblFileTwo.Visible = true;
                btnCompare.Enabled = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            FileComparison frm = new FileComparison(filenames);
            frm.ShowDialog();
        }

        private void btnFileOne_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "hrm|*.hrm|All|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fn1 = "File One = " + open.FileName; // name of the browsed file 

            }
            filenames.Add(fn1);
            lblFileOne.Text = Path.GetFileName(fn1);
            lblFileOne.Visible = true;
        }

        
    }
}
