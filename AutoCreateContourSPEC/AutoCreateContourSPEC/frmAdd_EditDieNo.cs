using DevExpress.XtraEditors;
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

namespace AutoCreateContourSPEC
{
    public partial class frmAdd_EditDieNo : DevExpress.XtraEditors.XtraForm
    {
        private bool _statusForm = false;
        private DieData _dieData = new DieData();
        private DataTable _registedDieNo = new DataTable();
        private DataTable _emailDataTable = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_SimulationEmailList");
        private string _emailList = "";

        public frmAdd_EditDieNo(bool status)
        {
            if (status)
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterParent;
                simpleButton1.Text = "Đăng ký thông tin";
                simpleButton1.Appearance.BackColor = Color.FromArgb(128, 255, 128);
                simpleButton1.Appearance.Options.UseBackColor = true;
                _statusForm = true;
                foreach(DataRow row in _emailDataTable.Rows)
                {
                    _emailList += row["Email"] + ";";
                }
                if(_emailDataTable.Rows.Count <= 0)
                {
                    _emailList = "Clear";
                }
            }
        }
        public frmAdd_EditDieNo(DieData data)
        {
            _dieData = data;
            if(data != null)
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterParent;
                simpleButton1.Text = "Sửa thông tin";
                simpleButton1.Appearance.BackColor = Color.FromArgb(255, 255, 128);
                simpleButton1.Appearance.Options.UseBackColor = true;
                _statusForm = false;
            }            
        }

        private void frmAdd_EditDieNo_Load(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!_statusForm)
            {
                string query = @"Update BTMVLocalApps.dbo.MTRL_ContourDieNoDB set DieNo = '" + _dieData.DieNo+"', SizeName = '"+_dieData.SizeName+
                    "',DesignType = '"+_dieData.DesignType+"',Register_Date = '"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+
                    "', Register_By = '"+Properties.Settings.Default.Account+"',RegisterMC = '"+Environment.MachineName+"', DieStatus = '"+_dieData.DieStatus
                    +"',EmailStatus = '"+_dieData.EmailStatus+"', EmailList = '"+ _emailList + "', UsingMachine = '"+_dieData.UsingMachine+"' where ID = '"+_dieData.ID+"'";
                DialogResult rs = MessageBox.Show("Bạn có thực sự muốn sửa mã Die: " + _dieData.DieNo + "sử dụng cho mã Size: " + _dieData.SizeName + " không?", 
                    "Thông Báo", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);
                if(rs == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnect_10_118_11_111.ExecuteQuery(query);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }                
            }
            else
            {
                _dieData.DieNo = txtDieNo.Text.Trim();
                _dieData.SizeName = txtSizeName.Text.Trim();
                _dieData.RegisterMC = Environment.MachineName;
                _dieData.Register_By = Properties.Settings.Default.Account;
                _dieData.Register_Date = DateTime.Now;
                if(cbTiretype.SelectedItem.ToString() == "REP")
                {
                    _dieData.DesignType = "0";
                }
                else
                {
                    _dieData.DesignType = "1";
                }
                if(cBDieStatus.SelectedItem.ToString() == "Active")
                {
                    _dieData.DieStatus = 1;
                }
                else
                {
                    _dieData.DieStatus = 0;
                }
                //_dieData.DesignType = cbTiretype.SelectedItem.ToString();
                _dieData.EmailStatus = 0;
                _dieData.UsingMachine = cbUsingMachine.SelectedItem.ToString();
                DialogResult rs = new DialogResult();
                string searchQuery = @"Select * from BTMVLocalApps.dbo.MTRL_ContourDieNoDB where DieNo = '" + txtDieNo.Text.Trim() + "' and SizeName = '" + txtSizeName.Text.Trim() + "'";
                string query = "";
                _registedDieNo = SqlConnect_10_118_11_111.GetData(searchQuery);
                if(_registedDieNo.Rows.Count > 0)
                {
                    rs = MessageBox.Show("Đã tồn tại một đăng ký cho Die: " + _dieData.DieNo + " sử dụng cho mã Size: " + _dieData.SizeName + " ! \nBạn có muốn cập nhật cho Die trên không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if(rs == DialogResult.Yes)
                    {
                        query = @"UPDATE BTMVLocalApps.dbo.MTRL_ContourDieNoDB SET DieNo = '" + _dieData.DieNo + "', SizeName = '" + _dieData.SizeName + "',DesignType = '"+ _dieData.DesignType + "'," +
                            " Register_Date ='"+ _dieData.Register_Date.ToString("yyyy-MM-dd HH:mm:ss") + "',Register_By = '"+ _dieData.Register_By + "',RegisterMC = '"+ _dieData.RegisterMC + "'," +
                            " DieStatus = '" + _dieData.DieStatus + "',EmailStatus = '" + _dieData.EmailStatus + "',EmailList = '" + _dieData.EmailList + "',UsingMachine = '" + _dieData.UsingMachine + "' WHERE ID = '"+ _registedDieNo.Rows[0]["ID"]+ "'";
                    }
                }
                else
                {
                    query = @"INSERT INTO BTMVLocalApps.dbo.MTRL_ContourDieNoDB (DieNo,SizeName,DesignType,Register_Date,Register_By,RegisterMC,DieStatus,EmailStatus,EmailList,UsingMachine)
                                VALUES ('" + _dieData.DieNo + "','" + _dieData.SizeName + "','" + _dieData.DesignType + "','" + _dieData.Register_Date.ToString("yyyy-MM-dd HH:mm:ss") + "','" + _dieData.Register_By + "'" +
                                ",'" + _dieData.RegisterMC + "','" + _dieData.DieStatus + "','" + _dieData.EmailStatus + "','" + _dieData.EmailList + "','" + _dieData.UsingMachine + "')";
                    rs = MessageBox.Show("Bạn có thực sự muốn đăng ký mã Die: " + _dieData.DieNo + " sử dụng cho mã Size: " + _dieData.SizeName + " không?",
                    "Thông Báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                }               
                
                if (rs == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnect_10_118_11_111.ExecuteQuery(query);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}