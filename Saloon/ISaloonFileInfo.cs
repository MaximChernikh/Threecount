using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Saloon
{
    public class SaloonFileInfo
    {
        public string CalculationName { get; set; }
        public DateOnly CreationData { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }

        public SaloonFileInfo()
        {
            CalculationName = "";
            CreationData = DateOnly.FromDateTime(DateTime.Now);
            FilePath = Directory.GetCurrentDirectory();
            FileName = "";
        }
    }
}
