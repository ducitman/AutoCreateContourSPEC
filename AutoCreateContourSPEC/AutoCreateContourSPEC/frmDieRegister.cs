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
using System.Threading;
using System.Reflection;

namespace AutoCreateContourSPEC
{
    public partial class frmDieRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmDieRegister()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            gridViewApprovedDieNo.OptionsBehavior.ReadOnly = true;
        }
        private DataTable _dieDatatbl = new DataTable();
        private void frmDieRegister_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            _dieDatatbl = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_ContourDieNoDB");
            gridApprovedDieNo.DataSource = _dieDatatbl;
        }
        private void RefreshData()
        {
            splashScreenManager1.ShowWaitForm();
            BindData();
            Thread.Sleep(2000);
            splashScreenManager1.CloseWaitForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDieEdit_Click(object sender, EventArgs e)
        {
            DieData data = new DieData();
            object RowCellData = gridViewApprovedDieNo.GetFocusedRow();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(RowCellData);

            foreach(PropertyDescriptor prop in properties)
            {
                PropertyInfo property = data.GetType().GetProperty(prop.Name);
                if (property != null && prop.GetValue(RowCellData) != null)
                {
                    property.SetValue(data, prop.GetValue(RowCellData), null);
                }
            }
            frmAdd_EditDieNo frm = new frmAdd_EditDieNo(data);
            frm.Text = "Sửa thông tin Die";
            frm.ShowDialog();
        }

        private void btnDieRegister_Click(object sender, EventArgs e)
        {
            frmAdd_EditDieNo frm = new frmAdd_EditDieNo(true);
            frm.Text = "Đăng ký Die";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}