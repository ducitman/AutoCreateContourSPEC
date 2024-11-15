using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCreateContourSPEC.Model;
using System.Reflection;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.Pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using System.IO;
using System.Configuration;
using System.Net;

namespace AutoCreateContourSPEC
{    
    public partial class frmMessageBox : Form
    {
        private BFData _bfSimulationData;
        private BSideData _bsideSimulationData;
        private TopData _topSimulationData;
        private TopData _oppTopSimulationData;

        private TopDataSimulation _topSavedData = new TopDataSimulation();
        private SideDataSimulation _sideSavedData = new SideDataSimulation();
        private BFDataSimulation _bfSavedData = new BFDataSimulation();

        //private DataTable _topSimulationDieNo = new DataTable();
        //private DataTable _sideSimulationDieNo = new DataTable();
        //private DataTable _bfSimulationDieNo = new DataTable();
        private DataTable _dataDieNoRegister = new DataTable();
        private int _materialType = 0;
        private int _startExtendPlotSeriesTop = 0;
        private int _startExtendPlotSeriesBF = 0;
        private int _startExtendPlotSeriesSide = 0;

        private int _topSpecSideType = 0;
        private double _slitPos = 0;

        private double _junctionA = 0;
        private double _junctionB = 0;
        private double _junctionC = 0;
        private double _junctionD = 0;

        private List<PlotPoint> mainLinePlot = new List<PlotPoint>();
        private List<PlotPoint> series1Plot = new List<PlotPoint>();
        private List<PlotPoint> series2Plot = new List<PlotPoint>();
        private List<PlotPoint> series3Plot = new List<PlotPoint>();
        private List<PlotPoint> series4Plot = new List<PlotPoint>();
        private List<PlotPoint> series5Plot = new List<PlotPoint>();
        private List<PlotPoint> series6Plot = new List<PlotPoint>();

        //private string OKNotification = "bfdb2f74-6383-4ebb-99dc-32d0737e43f6";
        //private string NGNotification = "f9e6fa4f-6331-4d69-84bd-0afc32865f60";
        //private string Notification = "c51af9f1-7ad9-45dd-bf01-15511c7a7e18";
        class SimulationDataSync
        {
            public string Item { get; set; }
            public double Value { get; set; }
        }
        public frmMessageBox()
        {
            InitializeComponent();
            _startExtendPlotSeriesTop = plotChartTop.Series.Count;
            _startExtendPlotSeriesBF = plotChartBF.Series.Count;
            _startExtendPlotSeriesSide = plotChartSide.Series.Count;
            
        }
        public frmMessageBox(BFData bfData)
        {
            InitializeComponent();
            _bfSimulationData = bfData;
            _materialType = 1;
            TabControl1.TabPages[1].PageVisible = false;
            TabControl1.TabPages[2].PageVisible = false;
            _dataDieNoRegister = GetDieNoRegisterData(bfData.ContNo, bfData.KoContNo);
            label1.Text += " cho size: " + bfData.ContNo + " && DieNo: " + bfData.KoContNo;
        }
        public frmMessageBox(BSideData bsideData)
        {
            InitializeComponent();
            _bsideSimulationData = bsideData;
            _materialType = 2;
            TabControl1.TabPages[2].PageVisible = false;
            TabControl1.TabPages[0].PageVisible = false;
            _dataDieNoRegister = GetDieNoRegisterData(bsideData.ContNo, bsideData.KoContNo);
            label1.Text += " cho size: " + bsideData.ContNo + " && DieNo: " + bsideData.KoContNo;
        }
        public frmMessageBox(TopData topData)
        {
            InitializeComponent();
            _topSimulationData = topData;
            _materialType = 3;
            TabControl1.TabPages[1].PageVisible = false;
            TabControl1.TabPages[0].PageVisible = false;
            _dataDieNoRegister = GetDieNoRegisterData(topData.ContNo, topData.KoContNo);
            label1.Text += " cho size: " + topData.ContNo + " && DieNo: " + topData.KoContNo;            
        }
        public frmMessageBox(TopData topData, TopData oppTopData)
        {
            InitializeComponent();
            _topSimulationData = topData;
            _oppTopSimulationData = oppTopData;
            _materialType = 4;
            TabControl1.TabPages[1].PageVisible = false;
            TabControl1.TabPages[0].PageVisible = false;
            _dataDieNoRegister = GetDieNoRegisterData(topData.ContNo, topData.KoContNo);
            label1.Text += " cho size: " + topData.ContNo + " && DieNo: " + topData.KoContNo;
        }

        private DataTable GetDieNoRegisterData(string sizeName, string dieNo)
        {
            DataTable tbl = new DataTable();
            try
            {
                 tbl = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_ContourDieNoDB where DieNo = '" + dieNo + "' and SizeName = '" + sizeName + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", ex.Message);
            }            
            return tbl;
        }
        public class PlotPoint
        {
            public string ArguementPlot { get; set; }
            public string ValuePlot { get; set; }
        }

        private SeriesPointCollection AddSpecialPoints(SeriesPointCollection seriesPoint)
        {
            SeriesPointCollection newSeriesPoint = new SeriesPointCollection();

            for(int i = 0; i < seriesPoint.Count; i++)
            {
                int currentArgument = Convert.ToInt32(seriesPoint[i].Argument);
                int currentValue = Convert.ToInt32(seriesPoint[i].Values);

            }

            return newSeriesPoint;
        }
        // Tính toán làm tròn data
        private void BindDataToPlotList(List<string> outputListPos, List<string> outputListValue, List<double> inputListPos, List<double> inputputListValue)
        {
            int startArgument = 0;
            for (int i = 0; i < inputListPos.Count - 1; i++)
            {
                double currentPoint = inputListPos[i];
                double nextPoint = inputListPos[i + 1];
                double currentValue = inputputListValue[i];
                double nextValue = inputputListValue[i + 1];

                outputListPos.Add(inputListPos[i].ToString());
                outputListValue.Add(inputputListValue[i].ToString());
                //int startArgument = ((int)currentPoint / 5 + 1) * 5;
                if(currentPoint != nextPoint)
                {
                    if (currentPoint % 5 != 0 && currentPoint < 0)
                    {
                        startArgument = (int)(currentPoint - (currentPoint % 5));
                    }
                    else if (currentPoint % 5 != 0 && currentPoint > 0)
                    {
                        startArgument = (int)(currentPoint + (5 - currentPoint % 5));
                    }
                    else
                    {
                        startArgument = ((int)currentPoint / 5 + 1) * 5;
                    }

                    for (double index = startArgument; index < nextPoint; index += 5)
                    {
                        if (index >= nextPoint) break;                        
                        double valueDifference = nextValue - currentValue;
                        double argumentDifference = nextPoint - currentPoint;

                        double ratio = ((double)index - currentPoint) / argumentDifference;
                        double newValue = currentValue + valueDifference * ratio;

                        outputListPos.Add(index.ToString());
                        outputListValue.Add(Math.Round(newValue, 1,MidpointRounding.AwayFromZero).ToString());                        
                    }
                }
            }
            outputListPos.Add(inputListPos.Last().ToString());
            outputListValue.Add(inputputListValue.Last().ToString());
            int count = 0;
            foreach(string item in outputListPos)
            {
                Console.WriteLine(item.ToString() + " : " + outputListValue[count]);
                count++;
            }
        }
        private void InsertDataToPlotList(List<double> inputPlotPos, List<double> inputPlotValue)
        {
            for (int i = 0; i < inputPlotPos.Count; i++)
            {
                if (i == inputPlotPos.Count - 1 && Convert.ToDouble(inputPlotValue[inputPlotPos.Count - 1]) > 0)
                {
                    double pos = inputPlotPos[i];
                    inputPlotPos.Add(pos);
                    inputPlotValue.Add(0);
                }
                if (i == 0 && Convert.ToDouble(inputPlotValue[0]) > 0)
                {
                    double pos = inputPlotPos[i];
                    inputPlotPos.Insert(0, pos);
                    inputPlotValue.Insert(0, 0);
                }
            }
        }
        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;            
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //List<PlotPoint> extendPlotSeries = new List<PlotPoint>();
            int Div1Num = 0;
            int Div2Num = 0;
            int Div3Num = 0;
            int Div4Num = 0;
            int Div5Num = 0;
            int Div1NumOpp = 0;
            int Div2NumOpp = 0;
            int Div3NumOpp = 0;
            int Div4NumOpp = 0;
            int Div5NumOpp = 0;
            int countPlotseries = 0;
            int countOppPlotSeries = 0;
            int countExtendPlot = 0;
            List<double> plotDoublePos = new List<double>(100);
            List<double> plotDoubleValue = new List<double>(100);
            List<string> plotPos = new List<string>(100);
            List<string> plotValue = new List<string>(100);
            List<string> extendPlotpos = new List<string>();
            List<string> extendPlotValue = new List<string>();
            double startpoint = 0;
            double endpoint = 0;
            double positionD = 0;
            double valueD = 0;
            switch (_materialType)
            {
                #region BF
                case 1:                    
                    countPlotseries = Convert.ToInt32(_bfSimulationData.GaugeNum.ToString());
                    //plotExtendSeries = new string[countPlotseries, 2];
                    for (int i = countPlotseries - 1; i >= 0; i--)
                    {
                        if(i == countPlotseries - 1 && Convert.ToDouble(_bfSimulationData.Gauge.Substring(i * 4, 4)) > 0)
                        {
                            positionD = Convert.ToDouble(_bfSimulationData.GaugePos.Substring(i * 3, 3)) * (-1);
                            valueD = 0;
                            plotDoublePos.Add(positionD);
                            plotDoubleValue.Add(valueD);
                            positionD = Convert.ToDouble(_bfSimulationData.GaugePos.Substring(i * 3, 3)) * (-1);
                            valueD = Convert.ToDouble(_bfSimulationData.Gauge.Substring(i * 4, 4));
                            plotDoublePos.Add(positionD);
                            plotDoubleValue.Add(valueD);
                        }
                        else
                        {
                            plotDoublePos.Add((Convert.ToDouble(_bfSimulationData.GaugePos.Substring(i * 3, 3)) * (-1)));
                            plotDoubleValue.Add(Convert.ToDouble(_bfSimulationData.Gauge.Substring(i * 4, 4)));
                        }
                    }
                    for (int i = 0; i < countPlotseries; i++) 
                    {
                        if (i == countPlotseries - 1 && Convert.ToDouble(_bfSimulationData.Gauge.Substring(i * 4, 4)) > 0)
                        {
                            positionD = Convert.ToDouble(_bfSimulationData.GaugePos.Substring(i * 3, 3));
                            valueD = Convert.ToDouble(_bfSimulationData.Gauge.Substring(i * 4, 4));
                            plotDoublePos.Add(positionD);
                            plotDoubleValue.Add(valueD);
                            positionD = Convert.ToDouble(_bfSimulationData.GaugePos.Substring(i * 3, 3));
                            valueD = 0;
                            plotDoublePos.Add(positionD);
                            plotDoubleValue.Add(valueD);
                        }
                        else
                        {
                            plotDoublePos.Add(Convert.ToDouble(_bfSimulationData.GaugePos.Substring(i * 3, 3)));
                            plotDoubleValue.Add(Convert.ToDouble(_bfSimulationData.Gauge.Substring(i * 4, 4)));
                        }
                    }
                    BindDataToPlotList(plotPos, plotValue, plotDoublePos, plotDoubleValue);
                    for (int i = 0; i < plotPos.Count; i++)
                    {
                        string position = plotPos[i].ToString();
                        string valuation = plotValue[i].ToString();
                        plotChartBF.Series[0].Points.Add(new SeriesPoint(position, valuation));
                        AddingPlotData(mainLinePlot, position, valuation);
                    }
                    plotChartBF.Series[0].Name = "Main Line";
                    BindSimualtionSavedData(_materialType);
                    // Làm các series mặt cắt dựa trên extendPlotPos và extendPlotValue
                    break;
#endregion
                #region Side
                case 2:
                    double maxGauge = 0;
                    double maxPos = 0;
                    bool isContained = false;
                    int indexOfInsertPosition = -1;
                    double maxOfSmallThan = 0;
                    List<double> listMaxPos = new List<double>();
                    List<double> listMaxValue = new List<double>();

                    FindJunction(_materialType);
                    //double startpoint = 0;
                    //double endpoint = 0;
                    countPlotseries = Convert.ToInt32(_bsideSimulationData.GaugeNum.ToString());
                    //plotExtendSeries = new string[countPlotseries, 2];

                    //Fix Me : Add special inside point
                    for (int i = 0; i < countPlotseries; i++)
                    {
                        positionD = Convert.ToDouble(_bsideSimulationData.GaugePos.Substring(i * 3, 3));
                        valueD = Convert.ToDouble(_bsideSimulationData.Gauge.Substring(i * 4, 4));
                        plotDoublePos.Add(positionD);
                        plotDoubleValue.Add(valueD);
                    }
                    InsertDataToPlotList(plotDoublePos, plotDoubleValue);

                    BindDataToPlotList(plotPos, plotValue, plotDoublePos, plotDoubleValue);

                    for (int i = 0; i < plotPos.Count; i++)
                    {
                        string position = plotPos[i].ToString();
                        string valuation = plotValue[i].ToString();
                        plotChartSide.Series[0].Points.Add(new SeriesPoint(position, valuation));
                        AddingPlotData(mainLinePlot, position, valuation);
                    }

                    //if(mainLinePlot[0].ValuePlot != "0")
                    //{
                    //    PlotPoint newPoint = new PlotPoint();
                    //    newPoint.ArguementPlot = "0";
                    //    newPoint.ValuePlot = "0";
                    //    mainLinePlot.Insert(0, newPoint);
                    //    plotChartSide.Series[0].Points.Insert(0,new SeriesPoint(newPoint.ArguementPlot, newPoint.ValuePlot));
                    //}
                    //if (mainLinePlot[mainLinePlot.Count - 1].ValuePlot != "0")
                    //{
                    //    PlotPoint newPoint = new PlotPoint();
                    //    newPoint.ArguementPlot = mainLinePlot[mainLinePlot.Count - 1].ArguementPlot;
                    //    newPoint.ValuePlot = "0";
                    //    mainLinePlot.Add(newPoint);
                    //    plotChartSide.Series[0].Points.Add(new SeriesPoint(newPoint.ArguementPlot, newPoint.ValuePlot));
                    //}

                    plotChartSide.Series[0].Name = "Main Line";                    

                    if (_bsideSimulationData.Div1Num.ToString() != "0")
                    {
                        Div1Num = Convert.ToInt32(_bsideSimulationData.Div1Num);
                        for (int i = 0; i < Div1Num; i++)
                        {
                            double pos = Convert.ToDouble(_bsideSimulationData.Div1X.Substring(i * 3, 3));
                            double val = Convert.ToDouble(_bsideSimulationData.Div1Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            extendPlotValue.Add(val.ToString());
                            if (maxGauge <= val)
                            {
                                maxGauge = val;
                                maxPos = pos;
                            }
                        }
                        listMaxPos.Add(maxPos);
                        listMaxValue.Add(maxGauge);

                        //isContained = (extendPlotpos.Contains(maxPos.ToString())) ? true : false;
                        //if(!isContained)
                        //{
                        //    for(int i = 0; i < plotPos.Count; i++)
                        //    {
                        //        if(Convert.ToDouble(plotPos[i]) < maxPos && Convert.ToDouble(plotPos[i]) > maxOfSmallThan)
                        //        {
                        //            indexOfInsertPosition = i;
                        //        }
                        //    }
                        //}
                        //plotChartSide.Series[0].Points.Insert(indexOfInsertPosition + 1, new SeriesPoint(maxPos.ToString(), maxGauge.ToString()));
                        //AddingPlotDataIndex(mainLinePlot, indexOfInsertPosition + 1, maxPos.ToString(), maxGauge.ToString());
                        for (int i= 0; i < Div1Num; i++)
                        {
                            string position = extendPlotpos[i].ToString();
                            string valuation = extendPlotValue[i].ToString();
                            plotChartSide.Series[1].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series1Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_bsideSimulationData.Div2Num.ToString() != "0")
                    {
                        Div2Num = Convert.ToInt32(_bsideSimulationData.Div2Num);
                        for (int i = 0; i < Div2Num; i++)
                        {
                            double pos = Convert.ToDouble(_bsideSimulationData.Div2X.Substring(i * 3, 3));
                            double val = Convert.ToDouble(_bsideSimulationData.Div2Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            extendPlotValue.Add(val.ToString());
                            if (maxGauge <= val)
                            {
                                maxGauge = val;
                                maxPos = pos;
                            }
                        }
                        listMaxPos.Add(maxPos);
                        listMaxValue.Add(maxGauge);
                        //isContained = (extendPlotpos.Contains(maxPos.ToString())) ? true : false;
                        //if (!isContained)
                        //{
                        //    for (int i = 0; i < plotPos.Count; i++)
                        //    {
                        //        if (Convert.ToDouble(plotPos[i]) < maxPos && Convert.ToDouble(plotPos[i]) > maxOfSmallThan)
                        //        {
                        //            indexOfInsertPosition = i;
                        //        }
                        //    }
                        //}
                        //plotChartSide.Series[0].Points.Insert(indexOfInsertPosition + 1, new SeriesPoint(maxPos.ToString(), maxGauge.ToString()));
                        //AddingPlotDataIndex(mainLinePlot, indexOfInsertPosition + 1, maxPos.ToString(), maxGauge.ToString());
                        for (int i = 0; i < Div2Num; i++)
                        {
                            string position = extendPlotpos[i].ToString();
                            string valuation = extendPlotValue[i].ToString();
                            plotChartSide.Series[2].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series2Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_bsideSimulationData.Div3Num.ToString() != "0")
                    {

                        Div3Num = Convert.ToInt32(_bsideSimulationData.Div3Num);
                        for (int i = 0; i < Div3Num; i++)
                        {
                            double pos = Convert.ToDouble(_bsideSimulationData.Div3X.Substring(i * 3, 3));
                            double val = Convert.ToDouble(_bsideSimulationData.Div3Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            extendPlotValue.Add(val.ToString());
                            if (maxGauge <= val)
                            {
                                maxGauge = val;
                                maxPos = pos;
                            }
                        }
                        listMaxPos.Add(maxPos);
                        listMaxValue.Add(maxGauge);
                        //isContained = (extendPlotpos.Contains(maxPos.ToString())) ? true : false;
                        //if (!isContained)
                        //{
                        //    for (int i = 0; i < plotPos.Count; i++)
                        //    {
                        //        if (Convert.ToDouble(plotPos[i]) < maxPos && Convert.ToDouble(plotPos[i]) > maxOfSmallThan)
                        //        {
                        //            indexOfInsertPosition = i;
                        //        }
                        //    }
                        //}
                        //plotChartSide.Series[0].Points.Insert(indexOfInsertPosition + 1, new SeriesPoint(maxPos.ToString(), maxGauge.ToString()));
                        //AddingPlotDataIndex(mainLinePlot, indexOfInsertPosition + 1, maxPos.ToString(), maxGauge.ToString());
                        for (int i = 0; i < Div3Num; i++)
                        {
                            string position = extendPlotpos[i].ToString();
                            string valuation = extendPlotValue[i].ToString();
                            plotChartSide.Series[3].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series3Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_bsideSimulationData.Div4Num.ToString() != "0")
                    {
                        Div4Num = Convert.ToInt32(_bsideSimulationData.Div4Num);
                        for (int i = 0; i < Div4Num; i++)
                        {
                            double pos = Convert.ToDouble(_bsideSimulationData.Div4X.Substring(i * 3, 3));
                            double val = Convert.ToDouble(_bsideSimulationData.Div4Y.Substring(i * 4, 4));
                            if(i == 0 && val != 0)
                            {
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Insert(0,"0");
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(val.ToString());
                            }
                            else if(i == Div4Num - 1 && val != 0)
                            {
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(val.ToString());
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add("0");
                            }
                            else
                            {
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(val.ToString());
                            }

                            if (maxGauge <= val)
                            {
                                maxGauge = val;
                                maxPos = pos;
                            }
                        }
                        listMaxPos.Add(maxPos);
                        listMaxValue.Add(maxGauge);
                        //isContained = (extendPlotpos.Contains(maxPos.ToString())) ? true : false;
                        //if (!isContained)
                        //{
                        //    for (int i = 0; i < plotPos.Count; i++)
                        //    {
                        //        if (Convert.ToDouble(plotPos[i]) < maxPos && Convert.ToDouble(plotPos[i]) > maxOfSmallThan)
                        //        {
                        //            indexOfInsertPosition = i;
                        //        }
                        //    }
                        //}
                        //plotChartSide.Series[0].Points.Insert(indexOfInsertPosition + 1, new SeriesPoint(maxPos.ToString(), maxGauge.ToString()));
                        //AddingPlotDataIndex(mainLinePlot, indexOfInsertPosition + 1, maxPos.ToString(), maxGauge.ToString());
                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            string position = extendPlotpos[i].ToString();
                            string valuation = extendPlotValue[i].ToString();
                            plotChartSide.Series[4].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series4Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_bsideSimulationData.Div5Num.ToString() != "0")
                    {
                        Div5Num = Convert.ToInt32(_bsideSimulationData.Div5Num);
                        for (int i = 0; i < Div5Num; i++)
                        {
                            double pos = Convert.ToDouble(_bsideSimulationData.Div5X.Substring(i * 3, 3));
                            double val = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            extendPlotValue.Add(val.ToString());
                            if (maxGauge <= val)
                            {
                                maxGauge = val;
                                maxPos = pos;
                            }
                        }
                        listMaxPos.Add(maxPos);
                        listMaxValue.Add(maxGauge);
                        //isContained = (extendPlotpos.Contains(maxPos.ToString())) ? true : false;
                        //if (!isContained)
                        //{
                        //    for (int i = 0; i < plotPos.Count; i++)
                        //    {
                        //        if (Convert.ToDouble(plotPos[i]) < maxPos && Convert.ToDouble(plotPos[i]) > maxOfSmallThan)
                        //        {
                        //            indexOfInsertPosition = i;
                        //        }
                        //    }
                        //}
                        //plotChartSide.Series[0].Points.Insert(indexOfInsertPosition + 1, new SeriesPoint(maxPos.ToString(), maxGauge.ToString()));
                        //AddingPlotDataIndex(mainLinePlot, indexOfInsertPosition + 1, maxPos.ToString(), maxGauge.ToString());
                        for (int i = 0; i < Div5Num; i++)
                        {
                            string position = extendPlotpos[i].ToString();
                            string valuation = extendPlotValue[i].ToString();
                            plotChartSide.Series[5].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series5Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }

                    int maxDataIndex = listMaxValue.IndexOf(listMaxValue.Max());
                    int plotDataIndex = 0;

                    if (Div1Num != 0 && Div5Num != 0 || Div5Num != 0 && Div4Num != 0 || Div5Num != 0)
                    {
                        for (int i = 0; i < plotChartSide.Series[0].Points.Count - 2; i++)
                        {
                            if (Convert.ToDouble(plotChartSide.Series[0].Points[i].Argument) <= listMaxPos[maxDataIndex] && listMaxPos[maxDataIndex] <= Convert.ToDouble(plotChartSide.Series[0].Points[i + 1].Argument))
                            {
                                plotDataIndex = i + 1;
                            }
                        }
                        plotChartSide.Series[0].Points.Insert(plotDataIndex, new SeriesPoint(listMaxPos[maxDataIndex].ToString(), listMaxValue[maxDataIndex].ToString()));
                        AddingPlotDataIndex(mainLinePlot, plotDataIndex, listMaxPos[maxDataIndex].ToString(), listMaxValue[maxDataIndex].ToString());
                    }
                    //Fix
                    if(Div5Num != 0 && Div2Num != 0)
                    {
                        List<int> indexOfMaxData = new List<int>();
                        for(int j = 0; j < listMaxPos.Count; j++)
                        {
                            for (int i = 0; i < plotChartSide.Series[0].Points.Count - 2; i++)
                            {
                                if (Convert.ToDouble(plotChartSide.Series[0].Points[i].Argument) <= listMaxPos[j] && listMaxPos[j] < Convert.ToDouble(plotChartSide.Series[0].Points[i + 1].Argument))
                                {
                                    plotDataIndex = i + 1;
                                    indexOfMaxData.Add(plotDataIndex);
                                }
                            }
                        }                        

                        for (int i = 0; i < listMaxPos.Count; i++)
                        {
                            plotChartSide.Series[0].Points.Insert(indexOfMaxData[i], new SeriesPoint(listMaxPos[i].ToString(), listMaxValue[i].ToString()));
                            AddingPlotDataIndex(mainLinePlot, indexOfMaxData[i], listMaxPos[i].ToString(), listMaxValue[i].ToString());
                        }
                    }
                    
                    //Fix Me
                    
                    // Làm các series mặt cắt dựa trên extendPlotPos và extendPlotValue
                    BindSimualtionSavedData(_materialType);
                    break;
                #endregion 
                #region Đối xứng không antena, có antena
                case 3:
                    
                    // Xử lý oposite side, stamp antena và serial side
                    FindJunction(_materialType);
                    countPlotseries = Convert.ToInt32(_topSimulationData.GaugeNum.ToString());
                    plotChartTop.Series[0].Name = "Main Line";
                    startpoint = Convert.ToDouble(_topSimulationData.Div1X.Substring(0, 3));
                    endpoint = Convert.ToDouble(_topSimulationData.Div1X.Substring(3, 3));
                    //plotExtendSeries = new string[countPlotseries, 2];
                    if(_topSimulationData.SlitWid != 0)
                    {                        
                        for (int i = countPlotseries - 1; i >= 0 ;  i--)
                        {
                            positionD = Convert.ToDouble(_topSimulationData.GaugePos.Substring(i*3, 3));
                            valueD = Convert.ToDouble(_topSimulationData.Gauge.Substring(i*4, 4));
                            plotDoublePos.Add(positionD * (-1));
                            plotDoubleValue.Add(valueD);
                            
                        }
                        for (int i = 0; i < countPlotseries; i++)
                        {
                            positionD = Convert.ToDouble(_topSimulationData.GaugePos.Substring(i * 3, 3));
                            valueD = Convert.ToDouble(_topSimulationData.Gauge.Substring(i * 4, 4));
                            plotDoublePos.Add(positionD);
                            plotDoubleValue.Add(valueD);
                            
                        }
                        InsertDataToPlotList(plotDoublePos, plotDoubleValue);
                        
                        BindDataToPlotList(plotPos, plotValue, plotDoublePos, plotDoubleValue);

                        // +0.25
                        for (int i = 0; i < plotPos.Count; i++)
                        {
                            positionD = Convert.ToDouble(plotPos[i]);
                            valueD = Convert.ToDouble(plotValue[i]);
                            if(positionD < 0)
                            {
                                if(endpoint*(-1) <= positionD && positionD <= startpoint * (-1))
                                {
                                    plotValue[i] = Convert.ToString(valueD + 0.25);
                                }                                
                            }
                            else
                            {
                                if (endpoint >= positionD && positionD >= startpoint)
                                {
                                    plotValue[i] = Convert.ToString(valueD + 0.25);
                                }
                            }
                        }

                    }
                    else
                    {                        
                        for (int i = 0; i < countPlotseries; i++)
                        {
                            positionD = Convert.ToDouble(_topSimulationData.GaugePos.Substring(i * 3, 3));
                            valueD = Convert.ToDouble(_topSimulationData.Gauge.Substring(i * 4, 4));
                            plotDoublePos.Add(positionD);
                            plotDoubleValue.Add(valueD);
                        }
                        Console.WriteLine("Done");

                        InsertDataToPlotList(plotDoublePos, plotDoubleValue);

                        BindDataToPlotList(plotPos, plotValue, plotDoublePos, plotDoubleValue);

                        for (int i = 0; i < plotPos.Count; i++)
                        {
                            positionD = Convert.ToDouble(plotPos[i]);
                            valueD = Convert.ToDouble(plotValue[i]);
                            if (positionD < 0)
                            {
                                if (endpoint * (-1) <= positionD && positionD <= startpoint * (-1))
                                {
                                    plotValue[i] = Convert.ToString(valueD + 0.25);
                                }
                            }
                            else
                            {
                                if (endpoint >= positionD && positionD >= startpoint)
                                {
                                    plotValue[i] = Convert.ToString(valueD + 0.25);
                                }
                            }
                        }
                    }
                    
                    for (int i = 0; i < plotPos.Count; i++)
                    {
                        string position = plotPos[i];
                        string valuation = plotValue[i];
                        plotChartTop.Series[0].Points.Add(new SeriesPoint(position, valuation));
                        Console.WriteLine(position + " : " + valuation);
                        AddingPlotData(mainLinePlot, position, valuation);
                    }
                    
                    if (_topSimulationData.Div1Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div1Num = Convert.ToInt32(_topSimulationData.Div1Num);
                        plotChartTop.Series[1].Name = "TUC";
                        if(_topSimulationData.SlitWid != 0)
                        {
                            PlotPoint point = new PlotPoint();
                            for (int i = Div1Num - 1; i > 0; i--)
                            {
                                double pos = Convert.ToDouble(_topSimulationData.Div1X.Substring(i * 3, 3));
                                double value = Convert.ToDouble(_topSimulationData.Div1Y.Substring(i * 4, 4));
                                extendPlotpos.Add((pos*(-1)).ToString());
                                extendPlotValue.Add(value.ToString());
                            }
                            for (int i = 0; i < Div1Num; i++)
                            {
                                double pos = Convert.ToDouble(_topSimulationData.Div1X.Substring(i * 3, 3));
                                double value = Convert.ToDouble(_topSimulationData.Div1Y.Substring(i * 4, 4));
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(value.ToString());
                            }                              
                            for (int i = 0; i < extendPlotpos.Count; i++)
                            {
                                string position = extendPlotpos[i];
                                string valuation = extendPlotValue[i];
                                plotChartTop.Series[1].Points.Add(new SeriesPoint(position, valuation));
                                AddingPlotData(series1Plot, position, valuation);
                            }
                        }
                        else
                        {
                            PlotPoint point = new PlotPoint();
                            for (int i = 0; i < Div1Num; i++)
                            {
                                double pos = Convert.ToDouble(_topSimulationData.Div1X.Substring(i * 3, 3));
                                double value = Convert.ToDouble(_topSimulationData.Div1Y.Substring(i * 4, 4));
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(value.ToString());
                            }
                            for (int i = 0; i < extendPlotpos.Count; i++)
                            {
                                string position = extendPlotpos[i];
                                string valuation = extendPlotValue[i];
                                plotChartTop.Series[1].Points.Add(new SeriesPoint(position,valuation));
                                AddingPlotData(series1Plot, position, valuation);
                            }
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div2Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div2Num = Convert.ToInt32(_topSimulationData.Div2Num);
                        plotChartTop.Series[2].Name = "BASE";
                        if (_topSimulationData.SlitWid != 0)
                        {
                            PlotPoint point = new PlotPoint();
                            for (int i = Div2Num -1; i > 0; i--)
                            {
                                double pos = Convert.ToDouble(_topSimulationData.Div2X.Substring(i * 3, 3));
                                double value = Convert.ToDouble(_topSimulationData.Div2Y.Substring(i * 4, 4));
                                extendPlotpos.Add((pos*(-1)).ToString());
                                extendPlotValue.Add(value.ToString());
                            }
                            for (int i = 0; i < Div2Num; i++)
                            {
                                double pos = Convert.ToDouble(_topSimulationData.Div2X.Substring(i * 3, 3));
                                double value = Convert.ToDouble(_topSimulationData.Div2Y.Substring(i * 4, 4));
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(value.ToString());
                            }
                        }
                        else
                        {
                            PlotPoint point = new PlotPoint();
                            for (int i = 0; i < Div2Num; i++)
                            {
                                double pos = Convert.ToDouble(_topSimulationData.Div2X.Substring(i * 3, 3));
                                double value = Convert.ToDouble(_topSimulationData.Div2Y.Substring(i * 4, 4));
                                extendPlotpos.Add(pos.ToString());
                                extendPlotValue.Add(value.ToString());
                            }
                        }
                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            string position = extendPlotpos[i];
                            string valuation = extendPlotValue[i];
                            if(i <= extendPlotpos.Count - 2)
                            {
                                if(Convert.ToDouble(extendPlotpos[i]) <= _topSimulationData.HumpWid && _topSimulationData.HumpWid <= Convert.ToDouble(extendPlotpos[i + 1]))
                                {
                                    _topSavedData.baseHumpGaugeLeft = Convert.ToDouble(extendPlotValue[i + 1]);//Sửa với bất đối xứng
                                    _topSavedData.baseHumpGaugeRight = Convert.ToDouble(extendPlotValue[i + 1]);
                                }
                            }
                            plotChartTop.Series[2].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series2Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div3Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        PlotPoint point = new PlotPoint();
                        Div3Num = Convert.ToInt32(_topSimulationData.Div3Num);
                        double bigPoint = 0;
                        if (_dataDieNoRegister.Rows.Count > 0)
                        {
                            switch (_dataDieNoRegister.Rows[0]["UsingMachine"].ToString())
                            {
                                case "K1S":
                                    for (int i = 0; i < Div3Num; i++)
                                    {
                                        double pos = Convert.ToDouble(_topSimulationData.Div3X.Substring(i * 3, 3)) * (-1);
                                        double value = Convert.ToDouble(_topSimulationData.Div3Y.Substring(i * 4, 4));
                                        if(value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotpos.Add(pos.ToString());
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint *(-1) >= pos && pos >= endpoint*(-1) && i == 0)
                                        //{                                            
                                        //    extendPlotValue.Add(Convert.ToString(value + 0.25));
                                        //}
                                        //else
                                        //{
                                        //    extendPlotValue.Add(value.ToString());
                                        //}
                                    }
                                    break;
                                case "MAT":
                                    for (int i = 0; i < Div3Num; i++)
                                    {
                                        double pos = Convert.ToDouble(_topSimulationData.Div3X.Substring(i * 3, 3));
                                        double value = Convert.ToDouble(_topSimulationData.Div3Y.Substring(i * 4, 4));
                                        if (value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotpos.Add(pos.ToString());
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint <= pos && pos <= endpoint)
                                        //{
                                        //    extendPlotValue.Add(Convert.ToString(value + 0.25));
                                        //}
                                        //else
                                        //{
                                        //    extendPlotValue.Add(value.ToString());
                                        //}
                                    }
                                    break;
                            }
                        }                        
                        plotChartTop.Series[3].Name = "SLIT";//Sửa K1S và MAT

                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            string position = extendPlotpos[i];
                            string valuation = extendPlotValue[i];
                            plotChartTop.Series[3].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series3Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div4Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div4Num = Convert.ToInt32(_topSimulationData.Div4Num);
                        double bigPoint = 0;
                        if (_dataDieNoRegister.Rows.Count > 0)
                        {                            
                            switch (_dataDieNoRegister.Rows[0]["UsingMachine"].ToString())
                            {
                                case "K1S":                                    
                                    for (int i = 0; i < _topSimulationData.Div4X.Length; i += 3)
                                    {
                                        extendPlotpos.Add((Convert.ToDouble(_topSimulationData.Div4X.Substring(i, 3))*(-1)).ToString());
                                    }
                                    for (int i = 0; i < extendPlotpos.Count; i++)
                                    {
                                        double value =Convert.ToDouble(_topSimulationData.Div4Y.Substring(i * 4, 4));
                                        if (value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint*(-1) >= Convert.ToDouble(extendPlotpos[i]) && Convert.ToDouble(extendPlotpos[i]) >= endpoint*(-1) && i == 0)
                                        //{
                                        //    string value = Convert.ToString(Convert.ToDouble(_topSimulationData.Div4Y.Substring(i * 4, 4)) + 0.25);
                                        //    extendPlotValue.Add(value);
                                        //}
                                        //else
                                        //{
                                        //    string value = _topSimulationData.Div4Y.Substring(i * 4, 4);
                                        //    extendPlotValue.Add(value);
                                        //}
                                    }
                                    break;
                                case "MAT":                                    
                                    for (int i = 0; i < _topSimulationData.Div4X.Length; i += 3)
                                    {
                                        extendPlotpos.Add(_topSimulationData.Div4X.Substring(i, 3));
                                    }
                                    for (int i = 0; i < extendPlotpos.Count; i++)
                                    {
                                        double value = Convert.ToDouble(_topSimulationData.Div4Y.Substring(i * 4, 4));
                                        if (value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint <= Convert.ToDouble(extendPlotpos[i]) && Convert.ToDouble(extendPlotpos[i]) <= endpoint)
                                        //{                                            
                                        //    extendPlotValue.Add((value + 0.25).ToString());
                                        //}
                                        //else
                                        //{
                                        //    extendPlotValue.Add(value.ToString());
                                        //}
                                    }
                                    break;
                            }                            
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show("Cảnh Báo", "Mã DIE chưa được đăng ký! Vui lòng đăng ký DieNo trước khi phê duyệt Spec này!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if(rs == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        
                        plotChartTop.Series[4].Name = "CAP";

                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            double position = Convert.ToDouble( extendPlotpos[i]);
                            double valuation = Convert.ToDouble( extendPlotValue[i]);
                            plotChartTop.Series[4].Points.Add(new SeriesPoint(position.ToString(),valuation.ToString()));
                            AddingPlotData(series4Plot, position.ToString(), valuation.ToString());
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div5Num.ToString() != "0")
                    {
                        double pos = 0, val = 0;
                        
                        Div5Num = Convert.ToInt32(_topSimulationData.Div5Num);
                        for (int i = 0; i < Div5Num; i++)
                        {
                            pos = Convert.ToDouble(_topSimulationData.Div5X.Substring(i * 3, 3));
                            val = Convert.ToDouble(_topSimulationData.Div5Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            //if(i < Div5Num - 1)
                            //{
                            //    if (startpoint <= pos && pos <= endpoint)
                            //    {
                            //        extendPlotValue.Add(Convert.ToString(val + 0.25));
                            //    }
                            //    else
                            //    {
                            //        extendPlotValue.Add(val.ToString());
                            //    }
                            //}
                            if (i == 0)
                            {
                                extendPlotValue.Add(Convert.ToString(val + 0.25));
                            }
                            else
                            {
                                extendPlotValue.Add(val.ToString());
                            }
                        }
                        plotChartTop.Series[5].Name = "MINI";
                        plotChartTop.Series[5].View.Color = Color.Blue;
                        plotChartTop.Series[6].Name = "MINI";
                        plotChartTop.Series[6].View.Color = Color.Blue;
                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            pos = Convert.ToDouble(extendPlotpos[i]);
                            val = Convert.ToDouble(extendPlotValue[i]);
                            if (_topSimulationData.SlitWid != 0)
                            {
                                plotChartTop.Series[5].Points.Add(new SeriesPoint(pos.ToString(), val.ToString()));
                                AddingPlotData(series5Plot, pos.ToString(), val.ToString());

                                plotChartTop.Series[6].Points.Add(new SeriesPoint((pos * (-1)).ToString(), val.ToString()));
                                AddingPlotData(series6Plot, (pos * (-1)).ToString(), val.ToString());
                            }
                            else
                            {
                                plotChartTop.Series[5].Points.Add(new SeriesPoint(extendPlotpos[i], extendPlotValue[i]));
                                AddingPlotData(series5Plot, pos.ToString(), val.ToString());
                            }                            
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    
                    BindSimualtionSavedData(_materialType);                    
                    break;
                #endregion
                #region Top Bất đối xứng
                case 4:
                    // Xử lý oposite side, stamp antena và serial side
                    FindJunction(_materialType);
                    countPlotseries = Convert.ToInt32(_topSimulationData.GaugeNum.ToString());
                    countOppPlotSeries = Convert.ToInt32(_oppTopSimulationData.GaugeNum.ToString());
                    plotChartTop.Series[0].Name = "Main Line";
                    startpoint = Convert.ToDouble(_topSimulationData.Div1X.Substring(0, 3));
                    endpoint = Convert.ToDouble(_topSimulationData.Div1X.Substring(3, 3));
                    
                    for (int i = countOppPlotSeries - 1; i >= 0; i--)
                    {                        
                        positionD = Convert.ToDouble(_oppTopSimulationData.GaugePos.Substring(i * 3, 3));
                        valueD = Convert.ToDouble(_oppTopSimulationData.Gauge.Substring(i * 4, 4));
                        plotDoublePos.Add(positionD * (-1));
                        plotDoubleValue.Add(valueD);
                    }
                    Console.WriteLine("Done");
                    for (int i = 0; i < countPlotseries; i++)
                    {
                        positionD = Convert.ToDouble(_topSimulationData.GaugePos.Substring(i * 3, 3));
                        valueD = Convert.ToDouble(_topSimulationData.Gauge.Substring(i * 4, 4));
                        plotDoublePos.Add(positionD);
                        plotDoubleValue.Add(valueD);
                    }
                    Console.WriteLine("Done");
                    InsertDataToPlotList(plotDoublePos, plotDoubleValue);
                    BindDataToPlotList(plotPos, plotValue, plotDoublePos, plotDoubleValue);
                    Console.WriteLine("-------------------------------------------------------------------------");
                    Console.WriteLine("plotDoublePos Count: " + plotDoublePos.Count);
                    Console.WriteLine("-------------------------------------------------------------------------");
                    // +0.25
                    for (int i = 0; i < plotPos.Count; i++)
                    {
                        positionD = Convert.ToDouble(plotPos[i]);
                        valueD = Convert.ToDouble(plotValue[i]);
                        if (positionD < 0)
                        {
                            if (endpoint * (-1) <= positionD && positionD <= startpoint * (-1))
                            {
                                plotValue[i] = Convert.ToString(valueD + 0.25);
                            }
                        }
                        else
                        {
                            if (endpoint >= positionD && positionD >= startpoint)
                            {
                                plotValue[i] = Convert.ToString(valueD + 0.25);
                            }
                        }
                    }

                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("plotPos Count: " + plotPos.Count);
                    Console.WriteLine("-------------------------------------------------------------");

                    for (int i = 0; i < plotPos.Count; i++)
                    {                        
                        string position = plotPos[i];
                        string valuation = plotValue[i];
                        plotChartTop.Series[0].Points.Add(new SeriesPoint(position, valuation));
                        Console.WriteLine(position + " : " + valuation);
                        AddingPlotData(mainLinePlot, position, valuation);
                    }

                    if (_topSimulationData.Div1Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div1Num = Convert.ToInt32(_topSimulationData.Div1Num);
                        Div1NumOpp = Convert.ToInt32(_oppTopSimulationData.Div1Num);
                        plotChartTop.Series[1].Name = "TUC";
                        PlotPoint point = new PlotPoint();
                        for (int i = Div1NumOpp - 1; i > 0; i--)
                        {
                            double pos = Convert.ToDouble(_oppTopSimulationData.Div1X.Substring(i * 3, 3));
                            double value = Convert.ToDouble(_oppTopSimulationData.Div1Y.Substring(i * 4, 4));
                            extendPlotpos.Add((pos * (-1)).ToString());
                            extendPlotValue.Add(value.ToString());
                        }
                        for (int i = 0; i < Div1Num; i++)
                        {
                            double pos = Convert.ToDouble(_topSimulationData.Div1X.Substring(i * 3, 3));
                            double value = Convert.ToDouble(_topSimulationData.Div1Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            extendPlotValue.Add(value.ToString());
                        }
                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            string position = extendPlotpos[i];
                            string valuation = extendPlotValue[i];
                            plotChartTop.Series[1].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series1Plot, position, valuation);
                        }
                        
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div2Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div2Num = Convert.ToInt32(_topSimulationData.Div2Num);
                        Div2NumOpp = Convert.ToInt32(_oppTopSimulationData.Div2Num);
                        plotChartTop.Series[2].Name = "BASE";

                        PlotPoint point = new PlotPoint();
                        for (int i = Div2NumOpp - 1; i > 0; i--)
                        {
                            double pos = Convert.ToDouble(_oppTopSimulationData.Div2X.Substring(i * 3, 3));
                            double value = Convert.ToDouble(_oppTopSimulationData.Div2Y.Substring(i * 4, 4));
                            extendPlotpos.Add((pos * (-1)).ToString());
                            extendPlotValue.Add(value.ToString());
                        }
                        for (int i = 0; i < Div2Num; i++)
                        {
                            double pos = Convert.ToDouble(_topSimulationData.Div2X.Substring(i * 3, 3));
                            double value = Convert.ToDouble(_topSimulationData.Div2Y.Substring(i * 4, 4));
                            extendPlotpos.Add(pos.ToString());
                            extendPlotValue.Add(value.ToString());
                        }

                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            string position = extendPlotpos[i];
                            string valuation = extendPlotValue[i];                            
                            if (i <= extendPlotpos.Count - 2)
                            {
                                double currentPos = Convert.ToDouble(extendPlotpos[i]);
                                double nextPos = Convert.ToDouble(extendPlotpos[i + 1]);
                                if (currentPos <= _topSimulationData.HumpWid && _topSimulationData.HumpWid <= nextPos)
                                {                                    
                                    _topSavedData.baseHumpGaugeRight = Convert.ToDouble(extendPlotValue[i + 1]);
                                }
                                if(currentPos <= _topSimulationData.HumpWid *(-1) && _topSimulationData.HumpWid*(-1) <= nextPos)
                                {
                                    _topSavedData.baseHumpGaugeLeft = Convert.ToDouble(extendPlotValue[i + 1]);
                                }
                            }
                            plotChartTop.Series[2].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series2Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div3Num.ToString() != "0")
                    {
                        double bigPoint = 0;
                        countExtendPlot += 1;
                        PlotPoint point = new PlotPoint();
                        Div3Num = Convert.ToInt32(_topSimulationData.Div3Num);
                        if (_dataDieNoRegister.Rows.Count > 0)
                        {
                            switch (_dataDieNoRegister.Rows[0]["UsingMachine"].ToString())
                            {
                                case "K1S":
                                    for (int i = 0; i < Div3Num; i++)
                                    {
                                        double pos = Convert.ToDouble(_topSimulationData.Div3X.Substring(i * 3, 3)) * (-1);
                                        double value = Convert.ToDouble(_topSimulationData.Div3Y.Substring(i * 4, 4));
                                        if(value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotpos.Add(pos.ToString());
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint * (-1) >= pos && pos >= endpoint * (-1) && i == 0)
                                        //{
                                        //    extendPlotValue.Add(Convert.ToString(value + 0.25));
                                        //}
                                        //else
                                        //{
                                        //    extendPlotValue.Add(value.ToString());
                                        //}
                                    }
                                    break;
                                case "MAT":
                                    for (int i = 0; i < Div3Num; i++)
                                    {
                                        double pos = Convert.ToDouble(_topSimulationData.Div3X.Substring(i * 3, 3));
                                        double value = Convert.ToDouble(_topSimulationData.Div3Y.Substring(i * 4, 4));
                                        if (value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotpos.Add(pos.ToString());
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint <= pos && pos <= endpoint)
                                        //{
                                        //    extendPlotValue.Add(Convert.ToString(value + 0.25));
                                        //}
                                        //else
                                        //{
                                        //    extendPlotValue.Add(value.ToString());
                                        //}
                                    }
                                    break;
                            }
                        }


                        plotChartTop.Series[3].Name = "SLIT";//Sửa K1S và MAT

                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            string position = extendPlotpos[i];
                            string valuation = extendPlotValue[i];
                            plotChartTop.Series[3].Points.Add(new SeriesPoint(position, valuation));
                            AddingPlotData(series3Plot, position, valuation);
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div4Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div4Num = Convert.ToInt32(_topSimulationData.Div4Num);
                        double bigPoint = 0;
                        if (_dataDieNoRegister.Rows.Count > 0)
                        {
                            switch (_dataDieNoRegister.Rows[0]["UsingMachine"].ToString())
                            {
                                case "K1S":
                                    for (int i = 0; i < _topSimulationData.Div4X.Length; i += 3)
                                    {
                                        extendPlotpos.Add((Convert.ToDouble(_topSimulationData.Div4X.Substring(i, 3)) * (-1)).ToString());
                                    }
                                    for (int i = 0; i < extendPlotpos.Count; i++)
                                    {
                                        double value = Convert.ToDouble( _topSimulationData.Div4Y.Substring(i * 4, 4));
                                        if (value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint * (-1) >= Convert.ToDouble(extendPlotpos[i]) && Convert.ToDouble(extendPlotpos[i]) >= endpoint * (-1) && i == 0)
                                        //{
                                        //    string value = Convert.ToString(Convert.ToDouble(_topSimulationData.Div4Y.Substring(i * 4, 4)) + 0.25);
                                        //    extendPlotValue.Add(value);
                                        //}
                                        //else
                                        //{
                                        //    string value = _topSimulationData.Div4Y.Substring(i * 4, 4);
                                        //    extendPlotValue.Add(value);
                                        //}
                                    }
                                    break;
                                case "MAT":
                                    for (int i = 0; i < _topSimulationData.Div4X.Length; i += 3)
                                    {
                                        extendPlotpos.Add(_topSimulationData.Div4X.Substring(i, 3));
                                    }
                                    for (int i = 0; i < extendPlotpos.Count; i++)
                                    {
                                        double value = Convert.ToDouble(_topSimulationData.Div4Y.Substring(i * 4, 4));
                                        if (value > bigPoint)
                                        {
                                            value += 0.25;
                                        }
                                        extendPlotValue.Add(value.ToString());
                                        //if (startpoint <= Convert.ToDouble(extendPlotpos[i]) && Convert.ToDouble(extendPlotpos[i]) <= endpoint)
                                        //{
                                        //    extendPlotValue.Add((value + 0.25).ToString());
                                        //}
                                        //else
                                        //{
                                        //    extendPlotValue.Add(value.ToString());
                                        //}
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show("Cảnh Báo", "Mã DIE chưa được đăng ký! Vui lòng đăng ký DieNo trước khi phê duyệt Spec này!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (rs == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }

                        plotChartTop.Series[4].Name = "CAP";

                        for (int i = 0; i < extendPlotpos.Count; i++)
                        {
                            double position = Convert.ToDouble(extendPlotpos[i]);
                            double valuation = Convert.ToDouble(extendPlotValue[i]);
                            plotChartTop.Series[4].Points.Add(new SeriesPoint(position.ToString(), valuation.ToString()));
                            AddingPlotData(series4Plot, position.ToString(), valuation.ToString());
                        }
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    if (_topSimulationData.Div5Num.ToString() != "0")
                    {
                        countExtendPlot += 1;
                        Div5Num = Convert.ToInt32(_topSimulationData.Div5Num);
                        Div5NumOpp = Convert.ToInt32(_oppTopSimulationData.Div5Num);

                        double pos = 0, oppPos = 0, val = 0, oppVal = 0;

                        for (int i = 0; i < Div5Num; i++)
                        {
                            pos = Convert.ToDouble(_topSimulationData.Div5X.Substring(i * 3, 3));                            
                            val = Convert.ToDouble(_topSimulationData.Div5Y.Substring(i * 4, 4));

                            //if (startpoint <= pos && pos <= endpoint && i < Div5Num - 1)
                            if (i == 0)
                            {
                                val = val + 0.25;
                            }
                            plotChartTop.Series[5].Points.Add(new SeriesPoint(pos.ToString(), val.ToString()));
                            
                            AddingPlotData(series5Plot, pos.ToString(), val.ToString());
                        }

                        for (int i = 0; i < Div5NumOpp; i++)
                        {
                            oppPos = Convert.ToDouble(_oppTopSimulationData.Div5X.Substring(i * 3, 3));
                            oppVal = Convert.ToDouble(_oppTopSimulationData.Div5Y.Substring(i * 4, 4));
                            //if (startpoint <= oppPos && oppPos <= endpoint && i < Div5NumOpp - 1)
                            if(i == 0)
                            {
                                oppVal = oppVal + 0.25;
                            }                            
                            plotChartTop.Series[6].Points.Add(new SeriesPoint((oppPos * (-1)).ToString(), oppVal.ToString()));

                            AddingPlotData(series6Plot, (oppPos *(-1)).ToString(), oppVal.ToString());
                        }

                        plotChartTop.Series[5].Name = "MINI";
                        plotChartTop.Series[5].View.Color = Color.Blue;
                        plotChartTop.Series[6].Name = "MINI";
                        plotChartTop.Series[6].View.Color = Color.Blue;
                        
                        extendPlotpos.Clear();
                        extendPlotValue.Clear();
                    }
                    
                    BindSimualtionSavedData(_materialType);
                    break;
                    #endregion
            }
            
        }
        private void AddingPlotData(List<PlotPoint> points,string pos, string value)
        {
            PlotPoint point = new PlotPoint();
            point.ArguementPlot = pos;
            point.ValuePlot = value;
            points.Add(point);
        }
        private void AddingPlotDataIndex(List<PlotPoint> points, int index, string pos, string value)
        {
            PlotPoint point = new PlotPoint();
            point.ArguementPlot = pos;
            point.ValuePlot = value;
            points.Insert(index,point);
        }
        private string PlotStringBuilder(List<PlotPoint> plotPoints, int status)
        {
            // status = 1: arguement
            // status = 2: value
            string stringBuilder = "";
            switch (status)
            {
                case 1:
                    foreach(PlotPoint point in plotPoints)
                    {
                        stringBuilder += point.ArguementPlot + ";";
                    }
                    break;
                case 2:
                    foreach (PlotPoint point in plotPoints)
                    {
                        stringBuilder += point.ValuePlot + ";" ;                        
                    }
                    break;
            }
            return stringBuilder;
        }
        
        private void BindSimualtionSavedData(int materialType)
        {
            List<TopDataSimulation> listTopDataSimulation = new List<TopDataSimulation>();
            List<SideDataSimulation> listSideDataSimulation = new List<SideDataSimulation>();
            List<BFDataSimulation> listBFDataSimulation = new List<BFDataSimulation>();
            double value = 0;
            double startSide, endSide;
            switch (materialType)
            {
                #region BF
                case 1:
                    endSide = Convert.ToDouble(_bfSimulationData.GaugePos.Substring((Convert.ToInt32(_bfSimulationData.GaugeNum) - 1) * 3, 3));
                    _bfSavedData.SizeName = _bfSimulationData.ContNo;
                    _bfSavedData.DieNo = _bfSimulationData.KoContNo;

                    _bfSavedData.width = _bfSimulationData.Wid;
                    value = mainLinePlot
                                                    .Where(point => double.Parse(point.ArguementPlot) >= 0 && double.Parse(point.ArguementPlot) <= endSide)
                                                    .Max(point => double.Parse(point.ValuePlot));
                    _bfSavedData.topGauge = value;
                    _bfSavedData.edgeGauge = Convert.ToDouble(_bfSimulationData.Gauge.Substring(0, 4));

                    listBFDataSimulation.Add(_bfSavedData);
                    gridControl3.DataSource = listBFDataSimulation;
                    break;
                #endregion
                #region SIDE
                case 2:                    
                    _sideSavedData.SizeName = _bsideSimulationData.ContNo;
                    _sideSavedData.DieNo = _bsideSimulationData.KoContNo;

                    _sideSavedData.width = _bsideSimulationData.Wid;

                    _sideSavedData.junctionA = _junctionA;
                    _sideSavedData.junctionB = _junctionB;
                    _sideSavedData.junctionC = _junctionC;
                    _sideSavedData.junctionD = _junctionD;

                    _sideSavedData.sideEdgeGauge = 0.5;
                    if (_bsideSimulationData.Area2 != 0)
                    {
                        if(_junctionC < _junctionD)
                        {
                            startSide = _junctionC;
                        }
                        else
                        {
                            startSide = _junctionD;
                        }

                        if (_junctionA < _junctionB)
                        {
                            endSide = _bsideSimulationData.Wid - _junctionA;
                        }
                        else
                        {
                            endSide = _bsideSimulationData.Wid - _junctionB;
                        }
                        _sideSavedData.bucEdgeGauge = Convert.ToDouble(_bsideSimulationData.Div2Y.Substring(4,4));
                        _sideSavedData.bucGauge = Convert.ToDouble(_bsideSimulationData.Div2Y.Substring(0, 4));

                        _sideSavedData.gchEdgeGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(0, 4));
                        _sideSavedData.gchGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(4, 4));

                        value = mainLinePlot
                                                    .Where(point => double.Parse(point.ArguementPlot) >= startSide && double.Parse(point.ArguementPlot) <= endSide)
                                                    .Max(point => double.Parse(point.ValuePlot));
                        _sideSavedData.sideGauge = value;
                        _sideSavedData.bfGauge = 0;
                    }
                    if(_bsideSimulationData.Area4 != 0)
                    {
                        startSide = 0;
                        if(_junctionA < _junctionD)
                        {
                            endSide = _bsideSimulationData.Wid - _junctionA;
                        }
                        else
                        {
                            endSide = _bsideSimulationData.Wid - _junctionD;
                        }
                        _sideSavedData.sideGauge = mainLinePlot
                                                    .Where(point => double.Parse(point.ArguementPlot) >= startSide && double.Parse(point.ArguementPlot) <= endSide)
                                                    .Max(point => double.Parse(point.ValuePlot));
                        _sideSavedData.bfGauge = Convert.ToDouble(_bsideSimulationData.Div4Y.Substring(0, 4));
                        _sideSavedData.gchEdgeGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(0, 4));
                        _sideSavedData.gchGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(4, 4));
                        _sideSavedData.bucEdgeGauge = 0;
                        _sideSavedData.bucGauge = 0;
                    }
                    if(_bsideSimulationData.Area1 != 0)
                    {
                        startSide = 0;
                        if (_junctionA < _junctionC)
                        {
                            endSide = _bsideSimulationData.Wid - _junctionA;
                        }
                        else
                        {
                            endSide = _bsideSimulationData.Wid - _junctionC;
                        }
                        _sideSavedData.bucEdgeGauge = 0;
                        _sideSavedData.bucGauge = 0;
                        _sideSavedData.sideGauge = mainLinePlot
                                                    .Where(point => double.Parse(point.ArguementPlot) >= startSide && double.Parse(point.ArguementPlot) <= endSide)
                                                    .Max(point => double.Parse(point.ValuePlot));
                        _sideSavedData.gchEdgeGauge = 0;
                        _sideSavedData.gchGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(4, 4));
                        _sideSavedData.bfGauge = 0;
                    }
                    if(_bsideSimulationData.Area1 == 0 && _bsideSimulationData.Area2 == 0 && _bsideSimulationData.Area4 == 0)
                    {
                        startSide = 0;
                        if(_junctionA < _junctionB)
                        {
                            endSide = _bsideSimulationData.Wid - _junctionA;
                        }
                        else
                        {
                            endSide = _bsideSimulationData.Wid - _junctionB;
                        }
                        _sideSavedData.bucEdgeGauge = 0;
                        _sideSavedData.bucGauge = 0;
                        _sideSavedData.gchEdgeGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(0, 4));
                        _sideSavedData.gchGauge = Convert.ToDouble(_bsideSimulationData.Div5Y.Substring(4,4 ));
                        _sideSavedData.sideGauge = mainLinePlot
                                                    .Where(point => double.Parse(point.ArguementPlot) >= startSide && double.Parse(point.ArguementPlot) <= endSide)
                                                    .Max(point => double.Parse(point.ValuePlot));
                        _sideSavedData.bfGauge = 0;
                    }                    

                    listSideDataSimulation.Add(_sideSavedData);
                    gridControl2.DataSource = listSideDataSimulation;
                    break;
                #endregion
                #region TOP đối xứng
                case 3:
                    _topSavedData.SizeName = _topSimulationData.ContNo;
                    _topSavedData.DieNo = _topSimulationData.KoContNo;
                    
                    //Width
                    _topSavedData.totalWidth = _topSimulationData.Wid * 2;
                    //HumpWidth
                    _topSavedData.humpWidth = _topSimulationData.HumpWid;
                    //CenterGauge
                    _topSavedData.centerGauge = _topSimulationData.CenterGauge + 0.25;
                    //HumpGauge
                    _topSavedData.humpGaugeLeft = _topSimulationData.HumpGauge + 0.25;
                    _topSavedData.humpGaugeRight = _topSimulationData.HumpGauge + 0.25;
                    //TUC Gauge
                    _topSavedData.tucGauge = Convert.ToDouble(_topSimulationData.Div1Y.Substring(0, 4));
                    //Mini Edge Gauge
                    _topSavedData.miniSideEdgeGaugeLeft = 0.5;
                    _topSavedData.miniSideEdgeGaugeRight = 0.5;
                    //Base Center Gauge
                    _topSavedData.baseCenterGauge = Convert.ToDouble(_topSimulationData.Div2Y.Substring(0, 4));
                    //Antenna width
                    _topSavedData.antennaSlitWidth = _topSimulationData.SlitWid;
                    //Junction
                    _topSavedData.junctionA = _junctionA;
                    _topSavedData.junctionB = _junctionB;
                    _topSavedData.junctionC = _junctionC;
                    _topSavedData.junctionD = _junctionD;                    
                    
                    listTopDataSimulation.Add(_topSavedData);
                    gridControl1.DataSource = listTopDataSimulation;
                    break;
                #endregion
                #region TOP bất đối xứng
                case 4:
                    _topSavedData.SizeName = _topSimulationData.ContNo;
                    _topSavedData.DieNo = _topSimulationData.KoContNo;

                    //Width
                    _topSavedData.totalWidth = _topSimulationData.Wid * 2;
                    //HumpWidth
                    _topSavedData.humpWidth = _topSimulationData.HumpWid;
                    //CenterGauge
                    _topSavedData.centerGauge = _topSimulationData.CenterGauge + 0.25;
                    //HumpGauge
                    _topSavedData.humpGaugeLeft = _oppTopSimulationData.HumpGauge + 0.25;
                    _topSavedData.humpGaugeRight = _topSimulationData.HumpGauge + 0.25;
                    //TUC Gauge
                    _topSavedData.tucGauge = Convert.ToDouble(_topSimulationData.Div1Y.Substring(0, 4));
                    //Mini Edge Gauge
                    _topSavedData.miniSideEdgeGaugeLeft = 0.5;
                    _topSavedData.miniSideEdgeGaugeRight = 0.5;
                    //Base Center Gauge
                    _topSavedData.baseCenterGauge = Convert.ToDouble(_topSimulationData.Div2Y.Substring(0, 4));
                    //Antenna width
                    _topSavedData.antennaSlitWidth = _topSimulationData.SlitWid;
                    //Junction
                    _topSavedData.junctionA = _junctionA;
                    _topSavedData.junctionB = _junctionB;
                    _topSavedData.junctionC = _junctionC;
                    _topSavedData.junctionD = _junctionD;                    

                    listTopDataSimulation.Add(_topSavedData);
                    gridControl1.DataSource = listTopDataSimulation;
                    break;
                    #endregion
            }
        }
        //private double ReturnValue(string key)
        //{
        //    double value = 0;
            
        //    return value;
        //}
        private void SaveContourData(int materialType)
        {
            string approveBy = Environment.MachineName.ToString() + "\\" + Properties.Settings.Default.Account;
            
            DataTable emailList = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_SimulationEmailList");
            //string notifyEmailList = "";
            string query = "";
            string queryLog = "";
            List<string> queries = new List<string>();
            PropertyInfo[] properties;
            DataTable approvedContourResultData = new DataTable();
            DataTable getTransferLogData = new DataTable();
            
            switch (materialType)
            {
                case 1:
                    properties = typeof(BFDataSimulation).GetProperties();
                    approvedContourResultData = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation where SizeName = '" + _bfSavedData.SizeName + "' AND DieNo = '" + _bfSavedData.DieNo + "'");
                    getTransferLogData = SqlConnect_10_118_11_111.GetData(@"Select * from MTRL_SimulationTransferLogs where ContNo = '" + _bfSimulationData.ContNo + "' AND " +
                        "KoContNo = '" + _bfSimulationData.KoContNo + "'");
                    if (approvedContourResultData.Rows.Count > 0)
                    {
                        queries.Add(@"Delete from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation where SizeName = '" + _bfSavedData.SizeName + "' AND DieNo = '" + _bfSavedData.DieNo + "'");
                    }
                    foreach (PropertyInfo property in properties)
                    {
                        string dataItem = property.Name.ToString();
                        var propertyValue = property.GetValue(_bfSavedData);
                        switch (dataItem)
                        {
                            case "SizeName":
                            case "DieNo":
                            case "UpdatedTime":
                                break;
                            default:
                                query = @"INSERT INTO BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation(SizeName, DieNo, UpdatedTime, Parameter, Spec, MachineType) VALUES"
                                                + " ('" + _bfSavedData.SizeName + "', '" + _bfSavedData.DieNo + "', GETDATE()," +
                                                " '" + dataItem + "', '" + propertyValue + "','Bead Filler')";
                                queries.Add(query);
                                break;
                        }
                    }
                    //Query save log
                    queryLog = @"INSERT INTO MTRL_SimulationTransferLogs(ContNo, KoContNo, OiNo,BSSize,DepName,Reson,Width,MatName,DepDate,GaugeNum,GaugePos,Gauge,Notes,Approved_By,Approved_Date,EmailStatus,ApproveStatus,
                                        MainSeriesPlotPos, MainSeriesPlotVal, SeriesPlot1Pos, SeriesPlot1Val, SeriesPlot2Pos, SeriesPlot2Val, SeriesPlot3Pos, SeriesPlot3Val, SeriesPlot4Pos, SeriesPlot4Val,
                                        SeriesPlot5Pos, SeriesPlot5Val, SeriesPlot6Pos, SeriesPlot6Val) VALUES " +
                                        " ('" + _bfSimulationData.ContNo + "','" + _bfSimulationData.KoContNo + "','" + _bfSimulationData.OiNo + "','" + _bfSimulationData.BSSize + "','" + _bfSimulationData.DepName + "','" + _bfSimulationData.Reason + "'," +
                                        "'" + _bfSimulationData.Wid + "','" + _bfSimulationData.MatName + "','" + _bfSimulationData.DepDate + "','" + _bfSimulationData.GaugeNum + "','" + _bfSimulationData.GaugePos + "','" + _bfSimulationData.Gauge + "'," +
                                        "'" + _bfSimulationData.Notes + "','" + approveBy + "',GETDATE(),'0','1','" + PlotStringBuilder(mainLinePlot, 1) + "','" + PlotStringBuilder(mainLinePlot, 2) + "'," +
                                        "'" + PlotStringBuilder(series1Plot, 1) + "','" + PlotStringBuilder(series1Plot, 2) + "','" + PlotStringBuilder(series2Plot, 1) + "','" + PlotStringBuilder(series2Plot, 2) + "','" + PlotStringBuilder(series3Plot, 1) + "','" + PlotStringBuilder(series3Plot, 2) + "'," +
                                        "'" + PlotStringBuilder(series4Plot, 1) + "','" + PlotStringBuilder(series4Plot, 2) + "','" + PlotStringBuilder(series5Plot, 1) + "','" + PlotStringBuilder(series5Plot, 2) + "','" + PlotStringBuilder(series6Plot, 1) + "','" + PlotStringBuilder(series6Plot, 2) + "')";
                    if (getTransferLogData.Rows.Count > 0)
                    {
                        queries.Add(@"DELETE FROM MTRL_SimulationTransferLogs WHERE ContNo = '" + _bfSimulationData.ContNo + "' AND KoContNo = '" + _bfSimulationData.KoContNo + "' AND OiNo = '" + _bfSimulationData.OiNo + "'");
                        queries.Add(queryLog);
                    }
                    else
                    {
                        queries.Add(queryLog);
                    }

                    SqlConnect_10_118_11_111.ExecuteQueryUsingTran(queries);
                    break;
                case 2:
                    properties = typeof(SideDataSimulation).GetProperties();
                    approvedContourResultData = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation where SizeName = '" + _sideSavedData.SizeName + "' AND DieNo = '" + _sideSavedData.DieNo + "'");
                    getTransferLogData = SqlConnect_10_118_11_111.GetData(@"Select * from MTRL_SimulationTransferLogs where ContNo = '" + _bsideSimulationData.ContNo + "' AND " +
                        "KoContNo = '" + _bsideSimulationData.KoContNo + "'");
                    if (approvedContourResultData.Rows.Count > 0)
                    {
                        queries.Add(@"Delete from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation where SizeName = '" + _sideSavedData.SizeName + "' AND DieNo = '" + _sideSavedData.DieNo + "'");
                    }
                    foreach (PropertyInfo property in properties)
                    {
                        string dataItem = property.Name.ToString();
                        var propertyValue = property.GetValue(_sideSavedData);
                        switch (dataItem)
                        {
                            case "SizeName":
                            case "DieNo":
                            case "UpdatedTime":
                                break;
                            default:
                                query = @"INSERT INTO BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation(SizeName, DieNo, UpdatedTime, Parameter, Spec, MachineType) VALUES"
                                                + " ('" + _sideSavedData.SizeName + "', '" + _sideSavedData.DieNo + "', GETDATE()," +
                                                " '" + dataItem + "', '" + propertyValue + "','Side')";
                                queries.Add(query);
                                break;
                        }
                    }
                    //Query save log
                    queryLog = @"INSERT INTO MTRL_SimulationTransferLogs(ContNo, KoContNo, OiNo,BSSize,DepName,Reson,Width,MatName,DepDate,GaugeNum,GaugePos,Gauge,Notes,Approved_By,Approved_Date,EmailStatus,ApproveStatus,
                                        MainSeriesPlotPos, MainSeriesPlotVal, SeriesPlot1Pos, SeriesPlot1Val, SeriesPlot2Pos, SeriesPlot2Val, SeriesPlot3Pos, SeriesPlot3Val, SeriesPlot4Pos, SeriesPlot4Val,
                                        SeriesPlot5Pos, SeriesPlot5Val, SeriesPlot6Pos, SeriesPlot6Val) VALUES " +
                                        " ('" + _bsideSimulationData.ContNo + "','" + _bsideSimulationData.KoContNo + "','" + _bsideSimulationData.OiNo + "','" + _bsideSimulationData.BSSize + "','" + _bsideSimulationData.DepName + "','" + _bsideSimulationData.Reason + "'," +
                                        "'" + _bsideSimulationData.Wid + "','" + _bsideSimulationData.MatName + "','" + _bsideSimulationData.DepDate + "','" + _bsideSimulationData.GaugeNum + "','" + _bsideSimulationData.GaugePos + "','" + _bsideSimulationData.Gauge + "'," +
                                        "'" + _bsideSimulationData.Notes + "','" + approveBy + "',GETDATE(),'0','1','" + PlotStringBuilder(mainLinePlot, 1) + "','" + PlotStringBuilder(mainLinePlot, 2) + "'," +
                                        "'" + PlotStringBuilder(series1Plot, 1) + "','" + PlotStringBuilder(series1Plot, 2) + "','" + PlotStringBuilder(series2Plot, 1) + "','" + PlotStringBuilder(series2Plot, 2) + "','" + PlotStringBuilder(series3Plot, 1) + "','" + PlotStringBuilder(series3Plot, 2) + "'," +
                                        "'" + PlotStringBuilder(series4Plot, 1) + "','" + PlotStringBuilder(series4Plot, 2) + "','" + PlotStringBuilder(series5Plot, 1) + "','" + PlotStringBuilder(series5Plot, 2) + "','" + PlotStringBuilder(series6Plot, 1) + "','" + PlotStringBuilder(series6Plot, 2) + "')";
                    if (getTransferLogData.Rows.Count > 0)
                    {
                        queries.Add(@"DELETE FROM MTRL_SimulationTransferLogs WHERE ContNo = '" + _bsideSimulationData.ContNo + "' AND KoContNo = '" + _bsideSimulationData.KoContNo + "' AND OiNo = '" + _bsideSimulationData.OiNo + "'");
                        queries.Add(queryLog);
                    }
                    else
                    {
                        queries.Add(queryLog);
                    }

                    SqlConnect_10_118_11_111.ExecuteQueryUsingTran(queries);
                    break;
                case 3:
                case 4:                    
                    //List<string> queries2 = new List<string>();
                    properties = typeof(TopDataSimulation).GetProperties();
                    approvedContourResultData = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation where SizeName = '" + _topSavedData.SizeName + "' AND DieNo = '" + _topSavedData.DieNo + "'");
                    getTransferLogData = SqlConnect_10_118_11_111.GetData(@"Select * from MTRL_SimulationTransferLogs where ContNo = '" + _topSimulationData.ContNo + "' AND " +
                        "KoContNo = '" + _topSimulationData.KoContNo + "'");
                    if (approvedContourResultData.Rows.Count > 0)
                    {
                        queries.Add(@"Delete from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation where SizeName = '" + _topSavedData.SizeName + "' AND DieNo = '" + _topSavedData.DieNo + "'");
                    }
                    foreach (PropertyInfo property in properties)
                    {
                        string dataItem = property.Name.ToString();
                        var propertyValue = property.GetValue(_topSavedData);                          
                        switch(dataItem)
                        {
                            case "SizeName":
                            case "DieNo":
                            case "UpdatedTime":
                                break;
                            default:                            
                                query = @"INSERT INTO BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation(SizeName, DieNo, UpdatedTime, Parameter, Spec, MachineType) VALUES"
                                                + " ('" + _topSavedData.SizeName + "', '" + _topSavedData.DieNo + "', GETDATE()," +
                                                " '" + dataItem + "', '" + propertyValue + "','Top')";
                                queries.Add(query);
                                break;
                        }                
                    }
                    //Query save log
                    queryLog = @"INSERT INTO MTRL_SimulationTransferLogs(ContNo, KoContNo, OiNo,BSSize,DepName,Reson,Width,MatName,DepDate,GaugeNum,GaugePos,Gauge,Notes,Approved_By,Approved_Date,EmailStatus,ApproveStatus,
                                        MainSeriesPlotPos, MainSeriesPlotVal, SeriesPlot1Pos, SeriesPlot1Val, SeriesPlot2Pos, SeriesPlot2Val, SeriesPlot3Pos, SeriesPlot3Val, SeriesPlot4Pos, SeriesPlot4Val,
                                        SeriesPlot5Pos, SeriesPlot5Val, SeriesPlot6Pos, SeriesPlot6Val) VALUES " +
                                        " ('" + _topSimulationData.ContNo + "','" + _topSimulationData.KoContNo + "','" + _topSimulationData.OiNo + "','" + _topSimulationData.BSSize + "','" + _topSimulationData.DepName + "','" + _topSimulationData.Reason + "'," +
                                        "'" + _topSimulationData.Wid + "','" + _topSimulationData.MatName + "','" + _topSimulationData.DepDate + "','" + _topSimulationData.GaugeNum + "','" + _topSimulationData.GaugePos + "','" + _topSimulationData.Gauge + "'," +
                                        "'" + _topSimulationData.Notes + "','" + approveBy + "',GETDATE(),'0','1','" + PlotStringBuilder(mainLinePlot, 1) + "','" + PlotStringBuilder(mainLinePlot, 2) + "'," +
                                        "'" + PlotStringBuilder(series1Plot, 1) + "','" + PlotStringBuilder(series1Plot, 2) + "','" + PlotStringBuilder(series2Plot, 1) + "','" + PlotStringBuilder(series2Plot, 2) + "','" + PlotStringBuilder(series3Plot, 1) + "','" + PlotStringBuilder(series3Plot, 2) + "'," +
                                        "'" + PlotStringBuilder(series4Plot, 1) + "','" + PlotStringBuilder(series4Plot, 2) + "','" + PlotStringBuilder(series5Plot, 1) + "','" + PlotStringBuilder(series5Plot, 2) + "','" + PlotStringBuilder(series6Plot, 1) + "','" + PlotStringBuilder(series6Plot, 2) + "')";
                    if (getTransferLogData.Rows.Count > 0)
                    {
                        queries.Add(@"DELETE FROM MTRL_SimulationTransferLogs WHERE ContNo = '" + _topSimulationData.ContNo + "' AND KoContNo = '" + _topSimulationData.KoContNo + "' AND OiNo = '"+_topSimulationData.OiNo+"'");
                        queries.Add(queryLog);
                    }
                    else
                    {
                        queries.Add(queryLog);
                    }

                    SqlConnect_10_118_11_111.ExecuteQueryUsingTran(queries);
                    break;
            }
        }
        private void CreateSPECFile(int materialType)
        {
            string specDetails = DataUtilities.STARTFORMAT;
            string folderPending = ConfigurationManager.AppSettings["folderPending"];
            
            string fileName = "";
            string firstDieNo = "";
            double middleDieNo = 0;
            string extenddieNo = "";
            string filePath = "";
            switch (materialType)
            {
                case 1://BF
                    specDetails = DataUtilities.SIDEANDBFFORMAT;
                    specDetails += "\n" + mainLinePlot.Count.ToString() + "\n" + "0" + "\n" + "0" + "\n" + "0";
                    for (int i = 0; i < mainLinePlot.Count; i++)
                    {
                        specDetails += "\n" + mainLinePlot[i].ArguementPlot.ToString();
                    }
                    for (int i = 0; i < mainLinePlot.Count; i++)
                    {
                        specDetails += "\n" + mainLinePlot[i].ValuePlot.ToString();
                    }
                    firstDieNo = _bfSimulationData.KoContNo;
                    fileName = firstDieNo + ".B_S";

                    // Create File
                    try
                    {
                        if (!Directory.Exists(folderPending))
                        {
                            Directory.CreateDirectory(folderPending);
                        }
                        else
                        {
                            filePath = Path.Combine(folderPending + fileName);
                            try
                            {
                                using (StreamWriter stream = new StreamWriter(filePath))
                                {
                                    stream.Write(specDetails);
                                }
                                MessageBox.Show("Đã tạo file Spec cho Contour thành công", "Thông Báo");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    ConvertToCRLF(filePath);
                    break;
                case 2://SIDE
                    specDetails = DataUtilities.SIDEANDBFFORMAT;
                    specDetails += "\n" + mainLinePlot.Count.ToString();
                    if(_bsideSimulationData.Area1 != 0)
                    {
                        List<string> listJoinPoint = new List<string>();
                        List<string> listJoinValue = new List<string>();
                        for(int i = 0; i < _bsideSimulationData.Div1Num; i++)
                        {
                            listJoinPoint.Add(_bsideSimulationData.Div1X.Substring(i * 3, 3));
                            listJoinValue.Add(_bsideSimulationData.Div1Y.Substring(i * 4, 4));
                        }
                        for (int i = 0; i < Convert.ToInt32(_bsideSimulationData.Div5Num); i++)
                        {
                            if(!listJoinPoint.Contains(_bsideSimulationData.Div5X.Substring(i * 3, 3)))
                            {
                                listJoinPoint.Add(_bsideSimulationData.Div5X.Substring(i * 3, 3));
                                listJoinValue.Add(_bsideSimulationData.Div5Y.Substring(i * 4, 4));
                            }
                        }
                        specDetails += "\n" + "3" +"\n"+"0"+"\n"+"0";
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ArguementPlot.ToString();
                        }
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ValuePlot.ToString();
                        }
                        for(int i = 0; i < listJoinPoint.Count ; i++)
                        {
                            specDetails += "\n" + listJoinPoint[i];
                        }
                        for(int i = 0; i < listJoinPoint.Count ; i++)
                        {
                            specDetails += "\n" + listJoinValue[i];
                        }
                    }
                    if(_bsideSimulationData.Area2 != 0)
                    {
                        specDetails += "\n" + _bsideSimulationData.Div5Num + "\n" + _bsideSimulationData.Div2Num + "\n" + "0" ;
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ArguementPlot.ToString();
                        }
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ValuePlot.ToString();
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ArguementPlot;
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ValuePlot;
                        }
                        for (int i = 0; i < series2Plot.Count; i++)
                        {
                            specDetails += "\n" + series2Plot[i].ArguementPlot;
                        }
                        for (int i = 0; i < series2Plot.Count; i++)
                        {
                            specDetails += "\n" + series2Plot[i].ValuePlot;
                        }
                    }
                    if (_bsideSimulationData.Area4 != 0)
                    {
                        specDetails += "\n" + _bsideSimulationData.Div5Num + "\n" + "0";
                        specDetails += "\n" + _bsideSimulationData.Div4Num;
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ArguementPlot.ToString();
                        }
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ValuePlot.ToString();
                        }
                        for(int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ArguementPlot;
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ValuePlot;
                        }
                        for (int i = 0; i < series4Plot.Count; i++)
                        {
                            specDetails += "\n" + series4Plot[i].ArguementPlot;
                        }
                        for (int i = 0; i < series4Plot.Count; i++)
                        {
                            specDetails += "\n" + series4Plot[i].ValuePlot;
                        }
                    }
                    if(_bsideSimulationData.Area1 == 0 && _bsideSimulationData.Area2 == 0 && _bsideSimulationData.Area4 == 0)
                    {
                        specDetails += "\n" + _bsideSimulationData.Div5Num + "\n" + "0" + "\n" + "0";
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ArguementPlot.ToString();
                        }
                        for (int i = 0; i < mainLinePlot.Count; i++)
                        {
                            specDetails += "\n" + mainLinePlot[i].ValuePlot.ToString();
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ArguementPlot;
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ValuePlot;
                        }
                    }
                    firstDieNo = _bsideSimulationData.KoContNo;                    
                    fileName = firstDieNo + ".S_S";
                    // Create File
                    try
                    {
                        if (!Directory.Exists(folderPending))
                        {
                            Directory.CreateDirectory(folderPending);
                        }
                        else
                        {
                            filePath = Path.Combine(folderPending + fileName);
                            try
                            {
                                using (StreamWriter stream = new StreamWriter(filePath))
                                {
                                    stream.Write(specDetails);
                                }
                                MessageBox.Show("Đã tạo file Spec cho Contour thành công", "Thông Báo");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    ConvertToCRLF(filePath);
                    break;
                case 3://TOP
                case 4:
                    if(_dataDieNoRegister.Rows[0]["UsingMachine"].ToString() == "MAT")
                    {
                        specDetails += "\n" + _dataDieNoRegister.Rows[0]["DesignType"].ToString() + "\n" + _topSimulationData.HumpWid.ToString() + "\n" + _topSimulationData.SlitPos.ToString();
                    }
                    else
                    {
                        specDetails += "\n" + _dataDieNoRegister.Rows[0]["DesignType"].ToString() + "\n" + _topSimulationData.HumpWid.ToString() + "\n" + (_topSimulationData.SlitPos * (-1)).ToString() ;
                    }
                    // slit width + slit height 
                    if (_topSimulationData.Div3Num != 0 && _topSimulationData.Div1Num != 0)
                    {
                        specDetails += "\n" + _topSimulationData.SlitWid.ToString() + "\n" + (Convert.ToDouble(_topSimulationData.Div3Y.Substring(0, 4)) + Convert.ToDouble(_topSimulationData.Div1Y.Substring(0, 4))).ToString() + "\n" + DataUtilities.MIDDLEFORMAT;
                    }
                    else
                    {
                        specDetails += "\n" + _topSimulationData.SlitWid.ToString() + "\n" + (Convert.ToDouble("0") + Convert.ToDouble("0")).ToString() + "\n" + DataUtilities.MIDDLEFORMAT;
                    }
                    
                    // Number plot of main line
                    specDetails += "\n" + mainLinePlot.Count.ToString();
                    //BASE DIV2                    
                    //MINI DIV5
                    //TUC DIV1
                    specDetails += "\n" + series2Plot.Count.ToString();
                    if(series6Plot.Count > 0)
                    {
                        specDetails += "\n" + (series5Plot.Count + series6Plot.Count).ToString();
                    }
                    else
                    {
                        specDetails += "\n" + series5Plot.Count .ToString();
                    }
                    specDetails += "\n" + series1Plot.Count.ToString();
                    //Main
                    for(int i = 0; i < mainLinePlot.Count; i++)
                    {
                        specDetails += "\n" + mainLinePlot[i].ArguementPlot.ToString();
                    }
                    for (int i = 0; i < mainLinePlot.Count; i++)
                    {
                        specDetails += "\n" + mainLinePlot[i].ValuePlot.ToString();
                    }
                    //BASE
                    for(int i = 0; i < series2Plot.Count; i++)
                    {
                        specDetails += "\n" + series2Plot[i].ArguementPlot.ToString();
                    }
                    for (int i = 0; i < series2Plot.Count; i++)
                    {
                        specDetails += "\n" + series2Plot[i].ValuePlot.ToString();
                    }
                    //MINI 
                    if (series6Plot.Count > 0)
                    {
                        for (int i = series6Plot.Count - 1; i >= 0; i--)
                        {
                            specDetails += "\n" + series6Plot[i].ArguementPlot.ToString();
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ArguementPlot.ToString();
                        }
                        for (int i = series6Plot.Count - 1; i >= 0; i--)
                        {
                            specDetails += "\n" + series6Plot[i].ValuePlot.ToString();
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ValuePlot.ToString();
                        }
                    }

                    if (series5Plot.Count > 0 && _topSimulationData.SlitWid == 0)
                    {
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ArguementPlot.ToString();
                        }
                        for (int i = 0; i < series5Plot.Count; i++)
                        {
                            specDetails += "\n" + series5Plot[i].ValuePlot.ToString();
                        }
                    }

                    //TUC
                    for (int i = 0; i < series1Plot.Count; i++)
                    {
                        specDetails += "\n" + series1Plot[i].ArguementPlot.ToString();
                    }
                    for (int i = 0; i < series1Plot.Count; i++)
                    {
                        specDetails += "\n" + series1Plot[i].ValuePlot.ToString();
                    }

                    //Slit
                    //if(_topSimulationData.Div3Num != 0)
                    //{
                    //    for (int i = 0; i < series3Plot.Count; i++)
                    //    {
                    //        specDetails += "\n" + series3Plot[i].ArguementPlot.ToString();
                    //    }
                    //    for (int i = 0; i < series3Plot.Count; i++)
                    //    {
                    //        specDetails += "\n" + series3Plot[i].ValuePlot.ToString();
                    //    }
                    //}

                    //if (_topSimulationData.Div4Num != 0)
                    //{
                    //    for (int i = 0; i < series4Plot.Count; i++)
                    //    {
                    //        specDetails += "\n" + series4Plot[i].ArguementPlot.ToString();
                    //    }
                    //    for (int i = 0; i < series4Plot.Count; i++)
                    //    {
                    //        specDetails += "\n" + series4Plot[i].ValuePlot.ToString();
                    //    }
                    //}

                    firstDieNo = _topSimulationData.KoContNo.Substring(0, 2);
                    middleDieNo =Convert.ToDouble( _topSimulationData.KoContNo.Substring(3, 3));
                    extenddieNo = _topSimulationData.KoContNo.Substring(6);
                    fileName = firstDieNo + middleDieNo.ToString() + extenddieNo + ".T_S";
                    
                    // Create File
                    try
                    {
                        if (!Directory.Exists(folderPending))
                        {
                            Directory.CreateDirectory(folderPending);
                        }
                        else
                        {
                            CreateFileByFtp(fileName, specDetails);
                            filePath = Path.Combine(folderPending + fileName);
                            //try
                            //{
                            //    using (StreamWriter stream = new StreamWriter(filePath))
                            //    {
                            //        stream.Write(specDetails);
                            //    }
                            //    MessageBox.Show("Đã tạo file Spec cho Contour thành công", "Thông Báo");
                            //}
                            //catch(Exception ex)
                            //{
                            //    MessageBox.Show(ex.Message);
                            //}
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    ConvertToCRLF(filePath);
                    break;
            }            
        }
        private void CreateFileByFtp(string fileName,string fileContent)
        {
            try
            {
                string completeFtpUrl = $"{Properties.Settings.Default.ftpUrl}/{@"PendingSpec"}/{fileName}";
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(completeFtpUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(Properties.Settings.Default.ftpUsername, Properties.Settings.Default.ftpPassword);

                string contentWithCrLf = fileContent.Replace("\n", "\r\n");

                byte[] fileContents = Encoding.UTF8.GetBytes(fileContent);
                request.ContentLength = fileContent.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
                    alertControl1.AppearanceCaption.BorderColor = Color.Black;
                    alertControl1.AppearanceCaption.BackColor = Color.SpringGreen;
                    alertControl1.AppearanceCaption.ForeColor = Color.SpringGreen;
                    alertControl1.AppearanceText.BackColor = Color.WhiteSmoke;
                    alertControl1.Show(this, "Thành Công", Environment.NewLine + "Tạo file Spec thành công!!!" + Environment.NewLine + " ");
                    //toastNotificationsManager1.ShowNotification(OKNotification);
                }
            }
            catch(Exception ex)
            {
                alertControl1.AppearanceCaption.BorderColor = Color.Black;
                alertControl1.AppearanceCaption.Options.UseBorderColor = true;
                alertControl1.AppearanceCaption.BackColor = Color.Pink;
                alertControl1.AppearanceCaption.ForeColor = Color.Red;
                alertControl1.AppearanceText.BackColor = Color.WhiteSmoke;
                alertControl1.Show(this, "Thất Bại", Environment.NewLine + "Tạo file Spec thất bại!!!" + Environment.NewLine + " " + ex.Message + Environment.NewLine);
                //toastNotificationsManager1.ShowNotification(NGNotification);
                //MessageBox.Show(ex.Message, "Lỗi Tạo File");
            }            
        }
        private void CoppyFileOnFtpServer(string fileName)
        {

        }
        private void ConvertToCRLF(string fileName)
        {
            try
            {
                string content = File.ReadAllText(fileName);
                string formattedContent = content.Replace("\r\n", "\n").Replace("\n", "\r\n");
                File.WriteAllText(fileName, formattedContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chuyen doi thanh CRLF that bai, "+ ex.Message, "Canh Bao");
            }
        }
        private void FindJunction(int materialType)
        {
            switch (materialType)
            {
                case 2:
                    if(_bsideSimulationData.Area1 == 0 && _bsideSimulationData.Area2 == 0 && _bsideSimulationData.Area4 == 0)
                    {
                        _junctionA = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div5X.Substring(3,3));
                        _junctionB = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div5X.Substring(0,3));
                        _junctionC = 0;
                        _junctionD = 0;
                    }
                    if (_bsideSimulationData.Area4 != 0)
                    {
                        int div4Num = Convert.ToInt32(_bsideSimulationData.Div4Num) - 1;
                        _junctionC = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div4X.Substring(0, 3));
                        _junctionD = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div4X.Substring(div4Num*3, 3));
                        _junctionB = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div5X.Substring(0, 3));
                        _junctionA = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div5X.Substring(3, 3));
                    }
                    if(_bsideSimulationData.Area2 != 0)
                    {
                        _junctionC = Convert.ToDouble(_bsideSimulationData.Div2X.Substring(0,3));
                        _junctionD = Convert.ToDouble(_bsideSimulationData.Div2X.Substring(3, 3));
                        _junctionB = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div5X.Substring(0, 3));
                        _junctionA = _bsideSimulationData.Wid - Convert.ToDouble(_bsideSimulationData.Div5X.Substring(3, 3));
                    }
                    if(_bsideSimulationData.Area1 != 0)
                    {
                        _junctionB = Convert.ToDouble(_bsideSimulationData.Div1X.Substring(0, 3));
                        _junctionC = Convert.ToDouble(_bsideSimulationData.Div1X.Substring(3, 3));
                        _junctionA = Convert.ToDouble(_bsideSimulationData.Div5X.Substring(3, 3));
                        _junctionD = 0;
                    }
                    break;
                case 3:
                case 4:
                    _junctionA = _topSimulationData.SplitPos;
                    _junctionD = Convert.ToDouble(_topSimulationData.Div1X.Substring(_topSimulationData.Div1X.Length - 3));
                    string div2X = _topSimulationData.Div2X;
                    string div5X = _topSimulationData.Div5X;
                    string junctionTemp1 = "", junctionTemp2 = "", junctionTemp3 = "", junctionTemp4 = "";
                    if(_topSimulationData.Div2Num != 0)
                    {
                        junctionTemp1 = div2X.Substring(div2X.Length - 6, 3);
                        junctionTemp2 = div2X.Substring(div2X.Length - 3);
                    }
                    else
                    {
                        junctionTemp1 = "0";
                        junctionTemp2 = "0";
                    }
                    if(_topSimulationData.Div5Num != 0)
                    {
                        junctionTemp3 = div5X.Substring(div5X.Length - 3);
                        junctionTemp4 = div5X.Substring(div5X.Length - 6, 3);
                    }
                    else
                    {
                        junctionTemp3 = "0";
                        junctionTemp4 = "0";
                    }
                    if (junctionTemp1 == junctionTemp3)
                    {
                        _junctionB = Convert.ToDouble(junctionTemp1);
                        _junctionC = Convert.ToDouble(junctionTemp2);
                    }
                    if(junctionTemp2 == junctionTemp4)
                    {
                        _junctionB = Convert.ToDouble(junctionTemp2);
                        _junctionC = Convert.ToDouble(junctionTemp3);
                    }
                    if(junctionTemp1 == junctionTemp4 && junctionTemp2 == junctionTemp3)
                    {
                        _junctionB = Convert.ToDouble(junctionTemp1);
                        _junctionC = Convert.ToDouble(junctionTemp3);
                    }
                    break;
            }
        }
        private bool isClosingRequested = false;
        private void PromptAndCloseForm()
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đóng giao diện phê duyệt?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();                
            }            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {             
            PromptAndCloseForm();
            isClosingRequested = false; 
        }

        private void btnAprove_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn phê duyệt dư liệu Contour này không?", "Thông Báo Quan Trọng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                SaveContourData(_materialType);
                CreateSPECFile(_materialType);
            }            
        }

        private void flyoutPanelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosingRequested)
            {
                DialogResult result = MessageBox.Show("Bạn có thực sự muốn đóng giao diện phê duyệt?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    isClosingRequested = true;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void frmMessageBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
