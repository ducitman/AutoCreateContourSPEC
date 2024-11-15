using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCreateContourSPEC
{
    public class TopData
    {
        #region Comment
        //***** Important Comment - DO NO DELETE
        //GumNo1 is TUC 
        //GumNo2 is BASE
        //GumNo3 is SLIT
        //GumNo5 is CAP
        //GumNo6 is MINI
        //Area Value need to *2
        //WT value need to * 2
        #endregion

        public string ContNo { get; set; }
        public string KoContNo { get; set; }
        public string OiNo { get; set; }
        public string Reason { get; set; }
        public string BSSize { get; set; }
        public string DepName { get; set; }
        public string MatName { get; set; }
        public double Type { get; set; }
        public double Wid { get; set; }
        public double HumpWid { get; set; }
        public double HumpGauge { get; set; }
        public double SplitPos { get; set; }
        public double SplitGauge { get; set; }
        public double BMPos { get; set; }
        public double BMGauge { get; set; }
        public double SlitPos { get; set; }
        public double SlitWid { get; set; }
        public double SlitFlug { get; set; }
        public string DepDate { get; set; }
        public double Area1 { get; set; }
        public double Area2 { get; set; }
        public double Area3 { get; set; }
        public double Area4 { get; set; }
        public double Area5 { get; set; }
        public double Area6 { get; set; }
        public string GumNo1 { get; set; }
        public string GumNo2 { get; set; }
        public string GumNo3 { get; set; }
        public string GumNo4 { get; set; }
        public string GumNo5 { get; set; }
        public string GumNo6 { get; set; }
        public double Sg1 { get; set; }
        public double Sg2 { get; set; }
        public double Sg3 { get; set; }
        public double Sg4 { get; set; }
        public double Sg5 { get; set; }
        public double Sg6 { get; set; }
        public double Porous1 { get; set; }
        public double Porous2 { get; set; }
        public double Porous3 { get; set; }
        public double Porous4 { get; set; }
        public double Porous5 { get; set; }
        public double Porous6 { get; set; }
        public double UnitMass1 { get; set; }
        public double UnitMass2 { get; set; }
        public double UnitMass3 { get; set; }
        public double UnitMass4 { get; set; }
        public double UnitMass5 { get; set; }
        public double UnitMass6 { get; set; }
        public string COMMENT1{ get; set; }
        public string COMMENT2 { get; set; }
        public string COMMENT3 { get; set; }
        public string COMMENT4 { get; set; }
        public double GaugeNum { get; set; }
        public string GaugePos { get; set; }
        public string Gauge { get; set; }
        public double Div1Num { get; set; }
        public string Div1X { get; set; }
        public string Div1Y { get; set; }
        public double Div2Num { get; set; }
        public string Div2X { get; set; }
        public string Div2Y { get; set; }
        public double Div3Num { get; set; }
        public string Div3X { get; set; }
        public string Div3Y { get; set; }
        public double Div4Num { get; set; }
        public string Div4X { get; set; }
        public string Div4Y { get; set; }
        public double Div5Num { get; set; }
        public string Div5X { get; set; }
        public string Div5Y { get; set; }
        public double CenterGauge { get; set; }
        public double TUCWid { get; set; }
        public double TOPEnd { get; set; }
        public double CAPEnd { get; set; }
        public double RefLinePos { get; set; }
        public double RefLineAngle { get; set; }
        public double BASE_START { get; set; }
        public double BASE_END { get; set; }
        public double BASE_CENTER_GAUGE { get; set; }
        public double BASE_HUMP { get; set; }
        public double CENTER_FLAT_WID { get; set; }
        public double HUMP_FLAT_WID { get; set; }
        public string Notes { get; set; }
    }
}
