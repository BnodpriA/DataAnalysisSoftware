using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisSoftware
{/// <summary>
/// Class to fetch [HRData] as per HRM versions
/// </summary>
    public class HRDataClass
    {
        //Data for HRM version 1.06 
        public int HeartRate { get; set; }
        public double Speed { get; set; }
        public int Cadence { get; set; }
        public int Altitude { get; set; }
        public double Power { get; set; }
        public int PowerBalanceAndPedallingIndex { get; set; }

        //Addition data add in HRM version 1.07
        public int AirPressure { get; set; }
    }
}
