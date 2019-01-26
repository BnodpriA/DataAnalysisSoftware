using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysisSoftware
{
    /// <summary>
    /// Delegates are type safe function pointer
    /// Called when the theread finishes loading contents from MasterClass
    /// </summary>
    public class Delegates
    {
        public delegate void ReadContentsCallBack(List<string[]> results);
        public delegate void ConfigurationLoadedCallBack(Dictionary<string, string> data);
    }
}
