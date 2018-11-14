using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisSoftware
{
    /// <summary>
    /// Class for controlling backed of the DataAnalysisSoftware
    /// </summary>
    public class MasterClass
    {
        /// <summary>
        /// GetPolarDeviceName from its monitor no for e.g. if monitor=1 then device name = "Polar Sport Tester / Vantage"
        /// </summary>
        /// <param name="monitor"></param>
        /// <returns></returns>
        private static string GetPolarDeviceName(int monitor)
        {
            string deviceName = null;
            switch (monitor)
            {
                case 1:
                    {
                        deviceName = "Polar Sport Tester/ Vantage";
                        break;
                    }
                case 2:
                    {
                        deviceName = "Polar Vantage NV (VNV)";
                        break;
                    }
                case 3:
                    {
                        deviceName = "Polar Accurex Plus";
                        break;
                    }
                case 4:
                    {
                        deviceName = "Polar XTrainer Plus";
                        break;
                    }
                case 6:
                    {
                        deviceName = "Polar S520";
                        break;
                    }
                case 7:
                    {
                        deviceName = "Polar Coach";
                        break;
                    }
                case 8:
                    {
                        deviceName = "Polar S210";
                        break;
                    }
                case 9:
                    {
                        deviceName = "Polar S410";
                        break;
                    }
                case 10:
                    {
                        deviceName = "Polar S510";
                        break;
                    }
                case 11:
                    {
                        deviceName = "Polar S610 / S610i";
                        break;
                    }
                case 12:
                    {
                        deviceName = "Polar S710 / S710i / S720i";
                        break;
                    }
                case 13:
                    {
                        deviceName = "Polar S810 / S810i";
                        break;
                    }
                case 15:
                    {
                        deviceName = "Polar E600";
                        break;
                    }
                case 20:
                    {
                        deviceName = "Polar AXN500";
                        break;
                    }
                case 21:
                    {
                        deviceName = "Polar AXN700";
                        break;
                    }
                case 22:
                    {
                        deviceName = "Polar S625X / S725X";
                        break;
                    }
                case 23:
                    {
                        deviceName = "Polar S725";
                        break;
                    }
                case 33:
                    {
                        deviceName = "Polar CS400";
                        break;
                    }
                case 34:
                    {
                        deviceName = "Polar CS600X";
                        break;
                    }
                case 35:
                    {
                        deviceName = "Polar CS600";
                        break;
                    }
                case 36:
                    {
                        deviceName = "Polar RS400";
                        break;
                    }
                case 37:
                    {
                        deviceName = "Polar RS800";
                        break;
                    }
                case 38:
                    {
                        deviceName = "Polar RS800X";
                        break;
                    }
                default:
                    break;
            }
            return deviceName;
        }
    }
}
