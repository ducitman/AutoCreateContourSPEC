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
using System.Net;
using System.IO;

namespace AutoCreateContourSPEC
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Remember)
            {
                txtAccount.Text = Properties.Settings.Default.Account;
                txtPassword.Text = Properties.Settings.Default.Password;
                chkboxRememberAccount.Checked = true;
            }
            else
            {
                txtAccount.Focus();
            }            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(txtAccount.Text.ToString() == "")
                {
                    MessageBox.Show("Vui Lòng Nhập Tài Khoản!", "Cảnh Báo");
                }
                else
                {
                    if (txtPassword.Text.ToString() == "")
                    {
                        MessageBox.Show("Vui Lòng Nhập Mật Khẩu!", "Cảnh Báo");
                    }
                    else
                    {
                        DataTable tbl = SqlConnect_10_118_11_111.GetData("SELECT A.SectionID, B.SectionName, A.Username, A.FullName, A.Dect, A.Email, A.Password, A.Process, A.ChucVu, B.UseBarcode, B.SendEmail, B.SendEmailCompleted, A.TrangThai FROM MTRL_BlueMemo.dbo.Users A " +
                            "Join MTRL_BlueMemo.dbo.Section B " +
                            "On A.SectionID = B.SectionSort  WHERE B.Type LIKE '%AutoCreateContour%' AND A.Username = N'" + txtAccount.Text.Trim() + "'");
                        if (tbl.Rows.Count == 0)
                        {
                            MessageBox.Show("Tài Khoản Không Tồn Tại!", "Cảnh Báo");
                            txtAccount.Focus();
                            return;
                        }
                        else
                        {
                            if(txtPassword.Text.Trim() != tbl.Rows[0]["Password"].ToString())
                            {
                                MessageBox.Show("Bạn đã nhập sai mật khẩu. Vui Lòng Nhập Lại Mật Khẩu!", "Cảnh Báo");
                            }
                            else
                            {
                                if (chkboxRememberAccount.Checked)
                                {
                                    Properties.Settings.Default.Account = txtAccount.Text.Trim();
                                    Properties.Settings.Default.Password = txtPassword.Text.Trim();
                                    Properties.Settings.Default.Remember = true;
                                    Properties.Settings.Default.Save();
                                }
                                string chucvu = tbl.Rows[0]["ChucVu"].ToString();
                                Properties.Settings.Default.ChucVu = chucvu;
                                Properties.Settings.Default.Save();
                                frmMenu frm = new frmMenu();
                                frm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KeyEventArgs keyEvent = new KeyEventArgs(Keys.Enter);
            txtPassword_KeyDown(sender, keyEvent);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}