using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public class BFDataSimulation:IData
    {
        public string SizeName { get; set; }
        public string DieNo { get; set; }
        public string UpdatedTime { get; set; }
        public double width { get; set; }
        public double topGauge { get; set; }
        public double edgeGauge { get; set; }
    }
}
