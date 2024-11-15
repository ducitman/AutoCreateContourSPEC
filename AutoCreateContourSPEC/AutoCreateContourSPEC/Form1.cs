using AutoCreateContourSPEC.DataAccessDBTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DevExpress.XtraTab;
using System.IO;
using AutoCreateContourSPEC.Model;
using System.Reflection;

namespace AutoCreateContourSPEC
{
    public partial class Form1 : Form
    {
        int _indexTabPage = 1;
        string _destinationPath = DataUtilities.DESTINATIONPATH;
        string _startFormat = DataUtilities.STARTFORMAT;
        string _middleFormat = DataUtilities.MIDDLEFORMAT;
        string _materialName = "";
        string _extenalBF = "B_S";
        string _externalSIDE = "S_S";
        string _externalTOP = "T_S";

        private BFData _bfSimulationData = new BFData();
        private BSideData _bsideSimulationData = new BSideData();
        private TopData _topSimulationData = new TopData();
        private TopData _oppTopSimulationData = new TopData();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dateFrom.EditValue = DateTime.Now.AddMonths(-6);
            dateTo.EditValue = DateTime.Now;

            this.psrbfTableAdapter1.Fill(this.dataAccessDB1.PSRBF);
            this.psrbsideTableAdapter1.Fill(this.dataAccessDB1.PSRBSIDE);
            this.psrtopTableAdapter1.Fill(this.dataAccessDB1.PSRTOP);
            this.WindowState = FormWindowState.Maximized;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            XtraTabControl tabControl = (XtraTabControl)sender;
            XtraTabPage selectedPage = e.Page;
            if (selectedPage.Name == "xTabBF")
            {
                _indexTabPage = 1;
                _materialName = "Bead Filler";
                //this.psrbfTableAdapter1.Fill(this.dataAccessDB1.PSRBF);
            }
            if (selectedPage.Name == "xTabSide")
            {
                _indexTabPage = 2;
                _materialName = "Black Side";
                //this.psrbsideTableAdapter1.Fill(this.dataAccessDB1.PSRBSIDE);
            }
            if (selectedPage.Name == "xTabTop")
            {
                _indexTabPage = 3;
                _materialName = "Top";
                //this.psrtopTableAdapter1.Fill(this.dataAccessDB1.PSRTOP);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string data = "";
            string sqlGetDieInfor = "";
            DataRowView rowview ;
            switch (_indexTabPage)
            {
                case 1:
                    object rowDataBf = gridViewBF.GetFocusedRow();
                    rowview = rowDataBf as DataRowView;
                    string sqlBF = @"Select * from BTMVLocalApps.dbo.MTRL_SimulationItems where  MachineType = 'Bead Filler' and ParamStatus = 'True'";
                    sqlGetDieInfor = @"Select * from BTMVLocalApps.dbo.MTRL_ContourDieNoDB where DieNo = '" + rowview["KoContNo"] + "' AND SizeName = '" + rowview["ContNo"] + "' AND DieStatus = '1'";
                    DataTable itemDataBf = SqlConnect_10_118_11_111.GetData(sqlBF);
                    DataTable dieNoDataBF = SqlConnect_10_118_11_111.GetData(sqlGetDieInfor);
                    if (rowDataBf != null)
                    {
                        if (rowDataBf is DataRowView rowView)
                        {
                            foreach(DataRow row in itemDataBf.Rows)
                            {
                                PropertyInfo[] properties = typeof(BFData).GetProperties();
                                string paramName = row["Parameter"].ToString();
                                foreach(PropertyInfo property in properties)
                                {
                                    if(property.Name.ToString() == paramName)
                                    {
                                        object value = rowView[paramName].ToString();

                                        if (property.PropertyType.Name.ToString() == "Double")
                                        {
                                            typeof(BFData).GetProperty(paramName).SetValue(_bfSimulationData, Convert.ToDouble(value));
                                        }
                                        else
                                        {
                                            typeof(BFData).GetProperty(paramName).SetValue(_bfSimulationData, value);
                                        }
                                    }                                    
                                }                                
                            }
                        }
                    }
                    if(dieNoDataBF.Rows.Count < 0)
                    {
                        DialogResult rs = MessageBox.Show(this, "DieNo " + rowview["KoContNo"] + " chưa được đăng ký! Vui lòng đăng ký trước khi phê duyệt Tạo Contour! \n Bạn có muốn đăng ký Die không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (rs == DialogResult.OK)
                        {
                            frmDieRegister frm = new frmDieRegister();
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox formMessage = new frmMessageBox(_bfSimulationData);
                        formMessage.ShowDialog();
                    }                    
                     break;
                case 2:
                    object rowDataSide = gridViewSide.GetFocusedRow();
                    rowview = rowDataSide as DataRowView;
                    string sqlSide = @"Select * from BTMVLocalApps.dbo.MTRL_SimulationItems where  MachineType = 'Black Side' and ParamStatus = 'True'";
                    sqlGetDieInfor = @"Select * from BTMVLocalApps.dbo.MTRL_ContourDieNoDB where DieNo = '" + rowview["KoContNo"] + "' AND SizeName = '" + rowview["ContNo"] + "' AND DieStatus = '1'";
                    DataTable itemDataSide = SqlConnect_10_118_11_111.GetData(sqlSide);
                    DataTable dieNoDataSide = SqlConnect_10_118_11_111.GetData(sqlGetDieInfor);
                    if (rowDataSide != null)
                    {
                        if (rowDataSide is DataRowView rowView)
                        {
                            foreach (DataRow row in itemDataSide.Rows)
                            {
                                //BSideData side = new BSideData();
                                PropertyInfo[] properties = typeof(BSideData).GetProperties();
                                string paramName = row["Parameter"].ToString();
                                foreach (PropertyInfo property in properties)
                                {
                                    if (property.Name.ToString() == paramName)
                                    {
                                        object value = rowView[paramName].ToString();

                                        if (property.PropertyType.Name.ToString() == "Double")
                                        {
                                            typeof(BSideData).GetProperty(paramName).SetValue(_bsideSimulationData, Convert.ToDouble(value));
                                        }
                                        else
                                        {
                                            typeof(BSideData).GetProperty(paramName).SetValue(_bsideSimulationData, value);
                                        }
                                    }                                    
                                }
                            }
                        }
                    }
                    if(dieNoDataSide.Rows.Count < 0)
                    {
                        DialogResult rs = MessageBox.Show(this, "DieNo " + rowview["KoContNo"] + " chưa được đăng ký! Vui lòng đăng ký trước khi phê duyệt Tạo Contour! \n Bạn có muốn đăng ký Die không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (rs == DialogResult.OK)
                        {
                            frmDieRegister frm = new frmDieRegister();
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        frmMessageBox formMessageSide = new frmMessageBox(_bsideSimulationData);
                        formMessageSide.ShowDialog();
                    }                    
                    break;
                case 3:
                    BindingSource bindingSource = this.gridViewTop.DataSource as BindingSource;
                    var filterRows = new List<DataRowView>();

                    object rowDataTop = gridViewTop.GetFocusedRow();
                    rowview = rowDataTop as DataRowView;

                    string sqlTop = @"Select * from BTMVLocalApps.dbo.MTRL_SimulationItems where  MachineType = 'Top' and ParamStatus = 'True'";
                    sqlGetDieInfor  = @"Select * from BTMVLocalApps.dbo.MTRL_ContourDieNoDB where DieNo = '" + rowview["KoContNo"] + "' AND SizeName = '" + rowview["ContNo"] + "' AND DieStatus = '1'";

                    DataTable itemDataTop = SqlConnect_10_118_11_111.GetData(sqlTop);
                    DataTable dieNoDataTop = SqlConnect_10_118_11_111.GetData(sqlGetDieInfor);

                    if (rowview["Type"].ToString() == "1")
                    {
                        BindDataToClass(rowDataTop, itemDataTop, _topSimulationData);
                        foreach (DataRowView row in bindingSource)
                        {
                            if (row["KoContNo"].ToString() == _topSimulationData.KoContNo
                                    && row["OiNo"].ToString() == _topSimulationData.OiNo
                                    && row["Type"].ToString() == "2" ||
                                    row["KoContNo"].ToString() == _topSimulationData.KoContNo
                                    && row["Type"].ToString() == "2"
                                    && row["ContNo"].ToString().Contains("*") == false
                                    )
                            {
                                filterRows.Add(row);
                            }
                            
                        }
                        if (filterRows != null)
                        {
                            int row = bindingSource.IndexOf(filterRows[0]);
                            DataRowView rowView = (DataRowView)bindingSource[row];
                            
                            BindDataToClass(rowView, itemDataTop, _oppTopSimulationData);
                        }
                        if(dieNoDataTop.Rows.Count > 0)
                        {
                            frmMessageBox formMessageTop = new frmMessageBox(_topSimulationData, _oppTopSimulationData);
                            formMessageTop.ShowDialog();
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show(this,"DieNo " + rowview["KoContNo"] + " chưa được đăng ký! Vui lòng đăng ký trước khi phê duyệt Tạo Contour! \n Bạn có muốn đăng ký Die không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if(rs == DialogResult.OK)
                            {
                                frmDieRegister frm = new frmDieRegister();
                                frm.ShowDialog();
                            }                            
                        }
                    }

                    if (rowview["Type"].ToString() == "2")
                    {
                        BindDataToClass(rowDataTop, itemDataTop, _oppTopSimulationData);
                        
                        foreach (DataRowView row in bindingSource)
                        {
                            if (row["KoContNo"].ToString() == _oppTopSimulationData.KoContNo
                                    && row["OiNo"].ToString() == _oppTopSimulationData.OiNo
                                    && row["Type"].ToString() == "1" ||
                                    row["KoContNo"].ToString() == _oppTopSimulationData.KoContNo
                                    && row["Type"].ToString() == "1"
                                    && row["ContNo"].ToString().Contains("*") == false
                                    )
                            {
                                filterRows.Add(row);
                            }
                        }
                        if (filterRows != null)
                        {
                            int row = bindingSource.IndexOf(filterRows[0]);
                            DataRowView rowView = (DataRowView)bindingSource[row];

                            BindDataToClass(rowView, itemDataTop, _topSimulationData);
                        }

                        if (dieNoDataTop.Rows.Count > 0)
                        {
                            frmMessageBox formMessageTop = new frmMessageBox(_topSimulationData, _oppTopSimulationData);
                            formMessageTop.ShowDialog();
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show(this,"DieNo " + rowview["KoContNo"] + " chưa được đăng ký! Vui lòng đăng ký trước khi phê duyệt Tạo Contour! \n Bạn có muốn đăng ký Die không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (rs == DialogResult.OK)
                            {
                                frmDieRegister frm = new frmDieRegister();
                                frm.ShowDialog();
                            }
                        }
                    }
                    if (rowview["Type"].ToString() == "0")
                    {
                        BindDataToClass(rowDataTop, itemDataTop, _topSimulationData);
                        if (dieNoDataTop.Rows.Count > 0)
                        {
                            frmMessageBox formMessageTop = new frmMessageBox(_topSimulationData);
                            formMessageTop.ShowDialog();
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show(this, "DieNo " + rowview["KoContNo"] + " chưa được đăng ký! Vui lòng đăng ký trước khi phê duyệt Tạo Contour! \n Bạn có muốn đăng ký Die không?", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (rs == DialogResult.OK)
                            {
                                frmDieRegister frm = new frmDieRegister();
                                frm.ShowDialog();
                            }
                        }
                    }                    
                    break;
            }
        }
        private void BindDataToClass(object rowDataTop, DataTable itemDataTop, TopData topData)
        {
            if (rowDataTop != null)
            {
                if (rowDataTop is DataRowView rowView)
                {
                    foreach (DataRow row in itemDataTop.Rows)
                    {
                        //TopData top = new TopData();
                        PropertyInfo[] properties = typeof(TopData).GetProperties();
                        string paramName = row["Parameter"].ToString();
                        foreach (PropertyInfo property in properties)
                        {
                            if (property.Name.ToString() == paramName)
                            {
                                object value = rowView[paramName].ToString();

                                if (property.PropertyType.Name.ToString() == "Double")
                                {
                                    if (value.ToString() != "")
                                    {
                                        typeof(TopData).GetProperty(paramName).SetValue(topData, Convert.ToDouble(value));
                                    }
                                    else
                                    {
                                        typeof(TopData).GetProperty(paramName).SetValue(topData, 0);
                                    }
                                }
                                else
                                {
                                    typeof(TopData).GetProperty(paramName).SetValue(topData, value);
                                }
                            }
                        }
                    }
                    

                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            switch (_indexTabPage)
            {
                case 1:
                    this.psrbfTableAdapter1.Fill(this.dataAccessDB1.PSRBF);
                    break;
                case 2:
                    this.psrbsideTableAdapter1.Fill(this.dataAccessDB1.PSRBSIDE);
                    break;
                case 3:
                    this.psrtopTableAdapter1.Fill(this.dataAccessDB1.PSRTOP);
                    break;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(dateFrom.Text.Trim() != dateTo.Text.Trim())
            {
                switch (_indexTabPage)
                {
                    case 1:
                        psrbfTableAdapter1.FillByDateBetween(dataAccessDB1.PSRBF, DateTime.Parse(dateFrom.Text).ToString("yyyy/MM/dd"), DateTime.Parse(dateTo.Text).ToString("yyyy/MM/dd"));
                        break;
                    case 2:
                        psrbsideTableAdapter1.FillByDateBetween(dataAccessDB1.PSRBSIDE, DateTime.Parse(dateFrom.Text).ToString("yyyy/MM/dd"), DateTime.Parse(dateTo.Text).ToString("yyyy/MM/dd"));
                        break;
                    case 3:
                        psrtopTableAdapter1.FillByDateBetween(dataAccessDB1.PSRTOP, DateTime.Parse(dateFrom.Text).ToString("yyyy/MM/dd"), DateTime.Parse(dateTo.Text).ToString("yyyy/MM/dd"));
                        break;
                }
            }
            else
            {
                switch (_indexTabPage)
                {
                    case 1:
                        psrbfTableAdapter1.FillByDateInput(dataAccessDB1.PSRBF, DateTime.Parse(dateTo.Text).ToString("yyyy/MM/dd"));
                        break;
                    case 2:
                        psrbsideTableAdapter1.FillByDateInput(dataAccessDB1.PSRBSIDE, DateTime.Parse(dateTo.Text).ToString("yyyy/MM/dd"));
                        break;
                    case 3:
                        psrtopTableAdapter1.FillByDateInput(dataAccessDB1.PSRTOP, DateTime.Parse(dateTo.Text).ToString("yyyy/MM/dd"));
                        break;
                }
            }
        }
    }
}
