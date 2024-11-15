using AutoCreateContourSPEC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCreateContourSPEC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlConnect_10_118_11_111.SetConnection("10.118.11.111", "BTMVAppsLog", "ituser", "Data@1511");
            if (SqlConnect_10_118_11_111.Error)
            {
                MessageBox.Show("Không kết nối được với máy chủ SQL 10.118.11.111");
                Application.Exit();
                return;
            }
            Application.Run(new frmLogin());
        }
    }
}
