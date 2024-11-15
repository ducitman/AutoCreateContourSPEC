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
    public partial class frmSpecForContourResult : DevExpress.XtraEditors.XtraForm
    {
        public frmSpecForContourResult()
        {
            InitializeComponent();
        }
        private DataTable _dataApprovedContourtbl = new DataTable();
        private void frmSpecForContourResult_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            _dataApprovedContourtbl = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_ContourDataFromSimulation");
            gridApprovedContourData.DataSource = _dataApprovedContourtbl;
            gridViewApprovedData.OptionsBehavior.ReadOnly = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}