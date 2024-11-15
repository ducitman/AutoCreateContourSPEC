using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public class TopDataSimulation: IData
    {
        public string SizeName { get; set; }
        public string DieNo { get; set; }
        public string UpdatedTime { get; set; }
        public double junctionA { get; set; }
        public double junctionB { get; set; }
        public double junctionC { get; set; }
        public double junctionD { get; set; }
        public double totalWidth { get; set; }
        public double humpWidth { get; set; }
        public double humpGaugeLeft { get; set; }
        public double humpGaugeRight { get; set; }
        public double centerGauge { get; set; }
        public double antennaSlitWidth { get; set; }
        public double tucGauge { get; set; }
        public double baseCenterGauge { get; set; }
        public double baseHumpGaugeLeft { get; set; } 
        public double baseHumpGaugeRight { get; set; }
        public double miniSideEdgeGaugeLeft { get; set; }
        public double miniSideEdgeGaugeRight { get; set; }
    }
}
