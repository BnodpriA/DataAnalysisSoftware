using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DataAnalysisSoftware
{
    public partial class ChartMode : Form
    {
        public ChartMode()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Plot Graph
        /// </summary>
        private void PlotGraph()
        {
            GraphPane graphPane = zrcHRMGraph.GraphPane;
            //Set Titles
            graphPane.Title = "HRM Data Graph";
            graphPane.XAxis.Title = "Values";
            graphPane.YAxis.Title = "Data Types" + "\r\n" + "(Speed, Cadence, Altitude, Hearth rate, Power)";

        }

        private void ChartMode_Load(object sender, EventArgs e)
        {
            PlotGraph();
        }
    }
}
