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

namespace AutoCreateContourSPEC
{
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {
        public frmMenu()
        {            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }        

        private void btnDieRegister_Click(object sender, EventArgs e)
        {
            frmDieRegister frm = new frmDieRegister();
            frm.ShowDialog();
        }

        private void btnApproveContourSpec_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnPendingContourSpec_Click(object sender, EventArgs e)
        {
            frmPendingContourApprove frm = new frmPendingContourApprove();
            frm.ShowDialog();
        }

        private void btnContourSpecData_Click(object sender, EventArgs e)
        {
            frmSpecForContourResult frm = new frmSpecForContourResult();
            frm.ShowDialog();
        }

        private void btnEmailListData_Click(object sender, EventArgs e)
        {
            frmEmailList frm = new frmEmailList();
            frm.ShowDialog();
        }

        private void btnItemListData_Click(object sender, EventArgs e)
        {
            frmContourItemsData frm = new frmContourItemsData();
            frm.ShowDialog();
        }

        private void btnConvertDataHistory_Click(object sender, EventArgs e)
        {
            frmApprovedContourSpec frm = new frmApprovedContourSpec();
            frm.ShowDialog();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void btnDieRegister_MouseHover(object sender, EventArgs e)
        {
            btnDieRegister.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnDieRegister_MouseLeave(object sender, EventArgs e)
        {
            btnDieRegister.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnContourSpecData_MouseHover(object sender, EventArgs e)
        {
            btnContourSpecData.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnContourSpecData_MouseLeave(object sender, EventArgs e)
        {
            btnContourSpecData.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btnApproveContourSpec_MouseHover(object sender, EventArgs e)
        {
            btnApproveContourSpec.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnApproveContourSpec_MouseLeave(object sender, EventArgs e)
        {
            btnApproveContourSpec.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btnEmailListData_MouseHover(object sender, EventArgs e)
        {
            btnEmailListData.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnEmailListData_MouseLeave(object sender, EventArgs e)
        {
            btnEmailListData.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btnPendingContourSpec_MouseHover(object sender, EventArgs e)
        {
            btnPendingContourSpec.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnPendingContourSpec_MouseLeave(object sender, EventArgs e)
        {
            btnPendingContourSpec.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btnItemListData_MouseHover(object sender, EventArgs e)
        {
            btnItemListData.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnItemListData_MouseLeave(object sender, EventArgs e)
        {
            btnItemListData.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btnConvertDataHistory_MouseHover(object sender, EventArgs e)
        {
            btnConvertDataHistory.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnConvertDataHistory_MouseLeave(object sender, EventArgs e)
        {
            btnConvertDataHistory.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            btnExit.Appearance.BackColor = Color.FromArgb(255, 255, 128);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.ChucVu)
            {
                case "Admin":
                    break;
                case "Leader":
                    btnEmailListData.Enabled = false;
                    btnItemListData.Enabled = false;
                    break;
                case "Staff":
                    btnEmailListData.Enabled = false;
                    btnItemListData.Enabled = false;
                    btnAdminApprove.Enabled = false;
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdminApprove_Click(object sender, EventArgs e)
        {
            frmMacroApprovement frm = new frmMacroApprovement();
            frm.ShowDialog();
        }

        private void btnAdminApprove_MouseHover(object sender, EventArgs e)
        {
            btnAdminApprove.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnAdminApprove_MouseLeave(object sender, EventArgs e)
        {
            btnAdminApprove.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}