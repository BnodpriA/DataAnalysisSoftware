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

        private void btnOK_Click(object sender, EventArgs e)
        {
            ChunkOfData frm = new ChunkOfData();
            //.Hide();
            frm.Show();
        }
    }
}
