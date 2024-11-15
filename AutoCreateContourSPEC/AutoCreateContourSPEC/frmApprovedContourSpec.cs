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
using DevExpress.XtraEditors.Repository;

namespace AutoCreateContourSPEC
{
    public partial class frmApprovedContourSpec : DevExpress.XtraEditors.XtraForm
    {
        public frmApprovedContourSpec()
        {
            InitializeComponent();
        }
        private DataTable _dataApprovedSpecHistory = new DataTable();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            _dataApprovedSpecHistory = SqlConnect_10_118_11_111.GetData(@"Select ContNo, KoContNo, OiNo, BSSize, DepName, Reson, MatName, Approved_By, Approved_Date, Confirmed_By, Confirmed_Date from MTRL_SimulationTransferLogs where ApproveStatus = '2' order by Approved_Date desc");
            gridApprovedContourSpec.DataSource = _dataApprovedSpecHistory;
            gridViewApprovedSpec.OptionsBehavior.ReadOnly = true;            
        }

        private void frmApprovedContourSpec_Load(object sender, EventArgs e)
        {
            BindData();            
        }
    }
}