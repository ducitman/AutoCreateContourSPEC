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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            alertControl1.AppearanceCaption.BorderColor = Color.Black;
            alertControl1.AppearanceCaption.ForeColor = Color.SpringGreen;
            alertControl1.AppearanceText.BackColor = Color.WhiteSmoke;
            alertControl1.Show(this, "Thành Công", Environment.NewLine + "Tạo file Spec thành công!!!" + Environment.NewLine + " ");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            alertControl1.AppearanceCaption.BorderColor = Color.Red;
            alertControl1.AppearanceCaption.ForeColor = Color.Red;
            alertControl1.AppearanceText.BackColor = Color.WhiteSmoke;
            alertControl1.Show(this, "Thất Bại", Environment.NewLine + "Tạo file Spec thất bại!!!" + Environment.NewLine + " " );
        }
    }
}
