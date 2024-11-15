using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public class SideDataSimulation:IData
    {
        public string SizeName { get; set; }
        public string DieNo { get; set; }
        public string UpdatedTime { get; set; }
        public double width { get; set; }
        public double sideEdgeGauge { get; set; }
        public double sideGauge { get; set; }
        public double gchGauge { get; set; }
        public double bucGauge { get; set; }
        public double bfGauge { get; set; }
        public double gchEdgeGauge { get; set; }
        public double bucEdgeGauge { get; set; }
        public double junctionA { get; set; }
        public double junctionB { get; set; }
        public double junctionC { get; set; }
        public double junctionD { get; set; }
    }
}
