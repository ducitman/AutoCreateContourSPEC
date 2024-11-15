using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public class DieData
    {
        public int ID { get; set; }
        public string DieNo { get; set; }
        public string SizeName { get; set; }
        public string DesignType { get; set; }
        public string Register_By { get; set; }
        public DateTime Register_Date { get; set; }
        public string RegisterMC { get; set; }
        public int DieStatus { get; set; }
        public int EmailStatus { get; set; }
        public string EmailList { get; set; }
        public string UsingMachine { get; set; }
    }
}
