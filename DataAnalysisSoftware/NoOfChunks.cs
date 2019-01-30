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
    public partial class NoOfChunks : Form
    {
        public NoOfChunks()
        {
            InitializeComponent();
        }
        int chunkNo;
        public int chunkGet { get; set; }
        string i;
        private void btnOK_Click(object sender, EventArgs e)
        {
            //ChunkOfData frm = new ChunkOfData();
            ////.Hide();
            //frm.Show();
            this.chunkGet = Convert.ToInt32(cmbNoOfChunks.Text);
            this.Hide();

        }

        private void NoOfChunks_Load(object sender, EventArgs e)
        {
            btnOK.DialogResult = DialogResult.OK;
        }

        private void cmbNoOfChunks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                i = cmbNoOfChunks.SelectedValue.ToString();
                chunkNo = Convert.ToInt32(i);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
