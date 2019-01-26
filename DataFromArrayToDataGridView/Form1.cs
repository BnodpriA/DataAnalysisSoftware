using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFromArrayToDataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] rows = new string[,]
            {
                //1   2     3   4
                {"1","AA","BB","12" },
                {"2","BB","CC","13" },
                {"3","CC","DD","14" },
                {"4","DD","EE","15" },
                {"5","EE","FF","16" },
                {"6","FF","GG","17" }
            };
            //rows.GetLength(0) return the length of first D
            for (int i = 0; i < rows.GetLength(0); i++) //arrary rows
            {
                string[] row = new string[rows.GetLength(1)];
                for (int j = 0; j < rows.GetLength(1); j++)
                {
                    row[j] = rows[i, j];
                    
                }
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
