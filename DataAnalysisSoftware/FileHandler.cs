using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static DataAnalysisSoftware.Delegates;

namespace DataAnalysisSoftware
{
    class FileHandler
    {
        private string fileName;
        private ReadContentsCallBack callBack;
        private ConfigurationLoadedCallBack confCallBack;

        public FileHandler(string fileName, ReadContentsCallBack callBack)
        {
            this.fileName = fileName;
            this.callBack = callBack;
        }

        public FileHandler(string fileName,ConfigurationLoadedCallBack confCallBack)
        {
            this.fileName = fileName;
            this.confCallBack = confCallBack;
        }
        public void FetchParameters()
        {
            var config = new Dictionary<string, string>();
            bool fileExist = File.Exists(@fileName);
            if (!fileExist)
            {
                //file doesn't exist, no point in continuing
                confCallBack(config);
            }
            
        }
    }
}
