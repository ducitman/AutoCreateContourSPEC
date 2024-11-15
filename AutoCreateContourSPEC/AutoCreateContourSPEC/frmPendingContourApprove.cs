using AutoCreateContourSPEC.Model;
using DevExpress.XtraCharts;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
namespace AutoCreateContourSPEC
{
    public partial class frmPendingContourApprove : DevExpress.XtraEditors.XtraForm
    {
        DataTable _dataPending = new DataTable();
        DataTable _dataReturnedPending = new DataTable();
        WebMailService.EmailServiceClient Email = new WebMailService.EmailServiceClient();
        BindingSource bindingSource = new BindingSource();
        public frmPendingContourApprove()
        {
            InitializeComponent();
        }
        private void frmPendingContourApprove_Load(object sender, EventArgs e)
        {
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.SplitterDistance = this.Width / 3;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.SplitterDistance = this.Width - 380;
            this.WindowState = FormWindowState.Maximized;

            _dataPending = SqlConnect_10_118_11_111.GetData(SQLString(1));
            _dataReturnedPending = SqlConnect_10_118_11_111.GetData(SQLString(3));

            gridPendingList.DataSource = _dataPending;

            checkPending_CheckedChanged(null, null);
            checkReturnedContour_CheckedChanged(null, null);

            switch (Properties.Settings.Default.ChucVu)
            {
                case "Admin":
                case "Leader":
                    break;
                case "Staff":
                    btnApproveContour.Enabled = false;
                    break;
            }
        }
        private string SQLString(int status)
        {
            string sql = @"Select * from MTRL_SimulationTransferLogs where ApproveStatus = '" + status + "' order by Approved_Date desc";
            return sql;
        }
        private void checkPending_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPending.Checked)
            {
                if (checkReturnedContour.Checked)
                {
                    btnReturnContour.Enabled = true;
                    gridPendingList.DataSource = _dataPending;
                    checkReturnedContour.Checked = false;
                    btnApproveContour.Enabled = true;
                }
                else
                {
                    btnReturnContour.Enabled = true;
                    gridPendingList.DataSource = _dataPending;
                    btnApproveContour.Enabled = true;
                }
            }
        }
        private void checkReturnedContour_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReturnedContour.Checked)
            {
                if (checkPending.Checked)
                {
                    btnReturnContour.Enabled = false;
                    gridPendingList.DataSource = _dataReturnedPending;
                    checkPending.Checked = false;
                    btnApproveContour.Enabled = false;
                }
                else
                {
                    btnReturnContour.Enabled = false;
                    gridPendingList.DataSource = _dataReturnedPending;
                    btnApproveContour.Enabled = false;
                }
            }
        }
        private void btnReturnContour_Click(object sender, EventArgs e)
        {
            DataRowView contourData = (DataRowView)gridView1.GetFocusedRow();
            ReturnContour(contourData["ContNo"].ToString(), contourData["KoContNo"].ToString(), contourData["OiNo"].ToString(), contourData["Approved_Date"].ToString());
            RefreshData();
        }
        private void RefreshData()
        {
            _dataPending = SqlConnect_10_118_11_111.GetData(SQLString(1));
            _dataReturnedPending = SqlConnect_10_118_11_111.GetData(SQLString(3));
            if (checkPending.Checked)
            {
                gridPendingList.DataSource = _dataPending;
            }
            else
            {
                gridPendingList.DataSource = _dataReturnedPending;
            }
            gridView1.RefreshData();
        }
        private void ReturnContour(string ContNo, string KoContNo, string OiNo, string Approved_Date)
        {
            string sql = sql = "Update MTRL_SimulationTransferLogs set ApproveStatus = '3' where ContNo = '" + ContNo + "' AND KoContNo = '" + KoContNo + "' AND OiNo = '" + OiNo + "' AND Approved_Date = '" + Approved_Date + "'"; ;
            string message = "";
            string filePath = "";
            message = "Bạn đang chuẩn bị trả lại bản spec của Size: " + "'" + ContNo + "', DieNo: " + "'" + KoContNo + "' được approve vào ngày '" + Convert.ToDateTime(Approved_Date).ToString("dd-MM-yyyy HH:mm:ss") + "'";
            DialogResult rs = MessageBox.Show(message, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                try
                {
                    SqlConnect_10_118_11_111.ExecuteQuery(sql);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            RefreshData();
        }
        private void FTPCoppyToApprovedFolder(string fileName)
        {
            try
            {
                string sourceFile = $"{Properties.Settings.Default.ftpUrl}/{"PendingSpec"}/{fileName}";
                string destinationFile = $"{Properties.Settings.Default.ftpUrl}/{"ApprovedSpec"}/{fileName}";
                FtpWebRequest sourceRequest = (FtpWebRequest)WebRequest.Create(sourceFile);
                sourceRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                sourceRequest.Credentials = new NetworkCredential(Properties.Settings.Default.ftpUsername, Properties.Settings.Default.ftpPassword);

                using (FtpWebResponse sourceResponse = (FtpWebResponse)sourceRequest.GetResponse())
                using (Stream sourceStream = sourceResponse.GetResponseStream())
                {
                    FtpWebRequest destRequest = (FtpWebRequest)WebRequest.Create(destinationFile);
                    destRequest.Method = WebRequestMethods.Ftp.UploadFile;
                    destRequest.Credentials = new NetworkCredential(Properties.Settings.Default.ftpUsername, Properties.Settings.Default.ftpPassword);

                    using (Stream destStream = destRequest.GetRequestStream())
                    {
                        sourceStream.CopyTo(destStream);
                    }

                    using (FtpWebResponse destResponse = (FtpWebResponse)destRequest.GetResponse())
                    {
                        Console.WriteLine($"File '{fileName}' copied successfully.");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                alertControl1.AppearanceCaption.BorderColor = Color.Black;
                alertControl1.AppearanceCaption.Options.UseBorderColor = true;
                alertControl1.AppearanceCaption.BackColor = Color.Pink;
                alertControl1.AppearanceCaption.ForeColor = Color.Red;
                alertControl1.AppearanceText.BackColor = Color.WhiteSmoke;
                alertControl1.Show(this, "Chuyển Contour Thất Bại", Environment.NewLine + "Chuyển file Spec thất bại!!!" + Environment.NewLine + " " + ex.Message + Environment.NewLine);
            }
        }
        private void CoppyToDestinationFolder(string fileName)
        {
            string folderPending = ConfigurationManager.AppSettings["folderPending"];
            //string folderApproved = ConfigurationManager.AppSettings["folderApproved"];
            string destinationPath = ConfigurationManager.AppSettings["folderDestination"];

            folderPending = Path.Combine(folderPending + fileName);
            destinationPath = Path.Combine(destinationPath + fileName);
            //destinationPath = Path.Combine(destinationPath + "TEST_" + fileName);
            //folderApproved = Path.Combine(folderApproved + fileName);
            //destinationPath = Path.Combine(destinationPath, fileName);

            try
            {
                File.Copy(folderPending, destinationPath, true);
                FTPCoppyToApprovedFolder(fileName);
                File.Delete(folderPending);
                alertControl1.AppearanceCaption.BorderColor = Color.Black;
                alertControl1.AppearanceCaption.BackColor = Color.SpringGreen;
                alertControl1.AppearanceCaption.ForeColor = Color.SpringGreen;
                alertControl1.AppearanceText.BackColor = Color.WhiteSmoke;
                alertControl1.Show(this, "Chuyển Contour Thành Công", Environment.NewLine + "Chuyển file Spec thành công!!!" + Environment.NewLine + " ");
                //File.Copy(folderPending, folderApproved, true);
                //MessageBox.Show("Phê duyệt và chuyển file Contour SPEC thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        private void btnApproveContour_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)gridView1.GetFocusedRow();
            string fileName = "";
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thông qua spec cho Size:" + row["ContNo"].ToString() + " - DieNo: " + row["KoContNo"].ToString() + " - Version: " + row["OiNo"].ToString() + " không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.OK)
            {
                string sql = @"Update MTRL_SimulationTransferLogs SET ApproveStatus = '2', Confirmed_By = '"+Properties.Settings.Default.Account+ "', Confirmed_Date = GETDATE() where ID = '" + row["ID"].ToString() + "'";
                try
                {
                    SqlConnect_10_118_11_111.ExecuteQuery(sql);
                    switch (row["MatName"].ToString())
                    {
                        case "Top":
                            fileName = row["KoContNo"].ToString().Substring(0, 2) + row["KoContNo"].ToString().Substring(3, 3) + row["KoContNo"].ToString().Substring(6) + ".T_S";
                            CoppyToDestinationFolder(fileName);
                            break;
                        case "Black Side":
                            fileName = row["KoContNo"].ToString().Trim() + ".S_S";
                            CoppyToDestinationFolder(fileName);
                            break;
                        case "Bead Filler":
                            fileName = row["KoContNo"].ToString().Trim() + ".B_S";
                            CoppyToDestinationFolder(fileName);
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            RefreshData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRowView row = (DataRowView)gridView1.GetFocusedRow();
            if(row != null)
            {
                string[] mainPlotPos = row["MainSeriesPlotPos"].ToString().Split(';').ToArray();
                string[] mainPlotVal = row["MainSeriesPlotVal"].ToString().Split(';').ToArray();

                string[] series1PlotPos = row["SeriesPlot1Pos"].ToString().Split(';').ToArray();
                string[] series1PlotVal = row["SeriesPlot1Val"].ToString().Split(';').ToArray();
                string[] series2PlotPos = row["SeriesPlot2Pos"].ToString().Split(';').ToArray();
                string[] series2PlotVal = row["SeriesPlot2Val"].ToString().Split(';').ToArray();
                string[] series3PlotPos = row["SeriesPlot3Pos"].ToString().Split(';').ToArray();
                string[] series3PlotVal = row["SeriesPlot3Val"].ToString().Split(';').ToArray();
                string[] series4PlotPos = row["SeriesPlot4Pos"].ToString().Split(';').ToArray();
                string[] series4PlotVal = row["SeriesPlot4Val"].ToString().Split(';').ToArray();
                string[] series5PlotPos = row["SeriesPlot5Pos"].ToString().Split(';').ToArray();
                string[] series5PlotVal = row["SeriesPlot5Val"].ToString().Split(';').ToArray();
                string[] series6PlotPos = row["SeriesPlot6Pos"].ToString().Split(';').ToArray();
                string[] series6PlotVal = row["SeriesPlot6Val"].ToString().Split(';').ToArray();


                for (int i = 0; i < chartReDraw.Series.Count; i++)
                {
                    chartReDraw.Series[i].Points.Clear();
                }


                for (int i = 0; i < mainPlotPos.Length; i++)
                {
                    if (mainPlotPos[i] != "")
                        chartReDraw.Series[0].Points.Add(new SeriesPoint(mainPlotPos[i], mainPlotVal[i]));
                }
                for (int i = 0; i < series1PlotPos.Length; i++)
                {
                    if (series1PlotPos[i] != "")
                        chartReDraw.Series[1].Points.Add(new SeriesPoint(series1PlotPos[i], series1PlotVal[i]));
                }
                for (int i = 0; i < series2PlotPos.Length; i++)
                {
                    if (series2PlotPos[i] != "")
                        chartReDraw.Series[2].Points.Add(new SeriesPoint(series2PlotPos[i], series2PlotVal[i]));
                }
                for (int i = 0; i < series3PlotPos.Length; i++)
                {
                    if (series3PlotPos[i] != "")
                        chartReDraw.Series[3].Points.Add(new SeriesPoint(series3PlotPos[i], series3PlotVal[i]));
                }
                for (int i = 0; i < series4PlotPos.Length; i++)
                {
                    if (series4PlotPos[i] != "")
                        chartReDraw.Series[4].Points.Add(new SeriesPoint(series4PlotPos[i], series4PlotVal[i]));
                }
                for (int i = 0; i < series5PlotPos.Length; i++)
                {
                    if (series5PlotPos[i] != "")
                        chartReDraw.Series[5].Points.Add(new SeriesPoint(series5PlotPos[i], series5PlotVal[i]));
                }
                for (int i = 0; i < series6PlotPos.Length; i++)
                {
                    if (series6PlotPos[i] != "")
                        chartReDraw.Series[6].Points.Add(new SeriesPoint(series6PlotPos[i], series6PlotVal[i]));
                }
            }
        }

        private void gridPendingList_DataSourceChanged(object sender, EventArgs e)
        {
            gridView1_FocusedRowChanged(sender, null);
        }
        
    }
}