using DevExpress.Spreadsheet;
using DevExpress.XtraGrid.Columns;
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
using System.Data.OleDb;
using System.IO;

namespace AutoCreateContourSPEC
{
    public partial class frmMacroApprovement : Form
    {
        public frmMacroApprovement()
        {
            InitializeComponent();
        }        
        private void frmMacroApprovement_Load(object sender, EventArgs e)
        {
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.SplitterDistance = 50;
            splitContainer1.IsSplitterFixed = true;
        }
        private string _contourPath = @"\\\\10.118.43.81\\Contour-BTMV\\1. CONTOUR\\1. Contour\\data\\PSR";
        DataTable _dataMacroAprroveDieNoTable = new DataTable();
        DataTable _dataSimulationBF = new DataTable();
        DataTable _dataSimulationSD = new DataTable();
        DataTable _dataSimulationTP = new DataTable();
        DataAccessDB.PSRBFDataTable _dataBF = new DataAccessDB.PSRBFDataTable();
        DataAccessDB.PSRTOPDataTable _dataTP = new DataAccessDB.PSRTOPDataTable();

        private List<string> _excelDieNo = new List<string>();
        private List<string> _contourDieNo = new List<string>();
        private List<string> _actualDieNo = new List<string>();
        private List<string> _noExistDieNo = new List<string>();
        private Cell _matName;
        private void btnInput_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel files (*.xls, *.xlsx)|*.xls;*.xlsx|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của file Excel được chọn
                    string filePath = openFileDialog.FileName;

                    // Tạo một instance của Workbook
                    Workbook workbook = new Workbook();

                    // Mở file Excel
                    workbook.LoadDocument(filePath);
                    
                    // Lấy dữ liệu từ sheet đầu tiên
                    Worksheet worksheet = workbook.Worksheets[0];                    
                    
                    CellRange usedRange = worksheet.GetUsedRange();
                    CellRange headerRange = worksheet.Range.FromLTRB(usedRange.LeftColumnIndex, usedRange.TopRowIndex, usedRange.RightColumnIndex,usedRange.TopRowIndex);
                    CellRange dataRange = worksheet.Range.FromLTRB(usedRange.LeftColumnIndex, usedRange.TopRowIndex + 1, worksheet.Columns.LastUsedIndex, worksheet.Rows.LastUsedIndex);
                    _matName = worksheet.Cells["F2"];
                    int rowCount = usedRange.RowCount;
                    int colCount = usedRange.ColumnCount;
                    List<string> listHeaderName = new List<string>();
                    foreach (var cell in headerRange)
                    {
                        DataColumn col = new DataColumn();
                        col.ColumnName = cell.Value.ToString();
                        _dataMacroAprroveDieNoTable.Columns.Add(col);
                        listHeaderName.Add(cell.Value.ToString());
                    }

                    for(int i = 1; i < dataRange.RowCount; i++)
                    {
                        CellRange cellRow = worksheet.Range.FromLTRB(0, i, dataRange.RightColumnIndex, i);
                        int cellIndex = 0;
                        DataRow newDataRow = _dataMacroAprroveDieNoTable.NewRow();
                        foreach (Cell cell in cellRow)
                        {
                            if(listHeaderName[cellIndex] == "DieContour")
                            {
                                _excelDieNo.Add(cell.Value.ToString());
                            }
                            newDataRow[listHeaderName[cellIndex]] = cell.Value.ToString();
                            cellIndex++;
                        }
                        _dataMacroAprroveDieNoTable.Rows.Add(newDataRow);
                    }                    
                    gridControl1.DataSource = _dataMacroAprroveDieNoTable;                   
                    
                    gridView1.RefreshData();

                    SearchSpecFileInContour(_matName.ToString());
                    if(_actualDieNo.Count > 0)
                    {
                        btnProcessMacro.Enabled = true;
                    }
                    else
                    {
                        btnProcessMacro.Enabled = false;
                    }
                }
            }
        }

        private void btnInput_MouseHover(object sender, EventArgs e)
        {
            btnInput.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnInput_MouseLeave(object sender, EventArgs e)
        {
            btnInput.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void btnProcessMacro_MouseHover(object sender, EventArgs e)
        {
            btnProcessMacro.Appearance.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void btnProcessMacro_MouseLeave(object sender, EventArgs e)
        {
            btnProcessMacro.Appearance.BackColor = Color.FromArgb(255, 255, 255);
        }
        private class CurrentDieAndSizeName
        {
            public string ContNo { get; set; }
            public string SearchDieNo { get; set; }
            public string KoContNo { get; set; }
        }

        private void SearchSpecFileInContour(string type)
        {
            _contourDieNo.Clear();
            _actualDieNo.Clear();
            _noExistDieNo.Clear();

            _contourDieNo = ReturnListDieNo(type);
            CompareListsDieNo();
        }
        private List<string> ReturnListDieNo(string type)
        {
            string extensionName = "";
            switch (type)
            {
                case "Top":
                    extensionName = "*.T_S";
                    break;
                case "Side":
                    extensionName = "*.S_S";
                    break;
                case "BF":
                    extensionName = "*.B_S";
                    break;
            }
            List<string> returnListData = new List<string>();
            foreach(string fileName in Directory.EnumerateFiles(_contourPath, extensionName, SearchOption.AllDirectories))
            {
                string pathName = Path.GetFileNameWithoutExtension(fileName);
                returnListData.Add(pathName);
            }
            return returnListData;
        }
        private void CompareListsDieNo()
        {
            foreach(string contourDie in _contourDieNo)
            {
                foreach(string excelDie in _excelDieNo)
                {
                    if (contourDie.Contains(excelDie))
                    {
                        _actualDieNo.Add(contourDie);
                        break;
                    }
                }
            }
            foreach(string excelDie in _excelDieNo)
            {
                if (!_actualDieNo.Contains(excelDie))
                {
                    _noExistDieNo.Add(excelDie);
                }
            }
        }
        private void btnProcessMacro_Click(object sender, EventArgs e)
        {
            
            //if(_actualDieNo.Count > 0)
            //{
            //    CreateFileSPEC();
            //}
            //else
            //{
            //    MessageBox.Show("Chưa có danh sách các Die hiện tại");
            //}
        }

        private void CreateFileSPEC()
        {
            switch (_matName.ToString())
            {
                case "Top":
                    CreateTopSPEC();
                    break;
                case "Side":
                    CreateSideSPEC();
                    break;
                case "BF":
                    CreateBFSPEC();
                    break;
            }
        }

        private void CreateTopSPEC()
        {
            string DieCode = "";
            int VersionDie = 0;
            psrtopTableAdapter1.Fill(dataAccessDB1.PSRTOP);
            psrtopTableAdapter1.Fill(_dataTP);
            foreach (string dieName in _actualDieNo)
            {
                DieCode = dieName.Substring(0, 2) + "0" + dieName.Substring(2, 3) + dieName.Substring(dieName.Length - 4, 3);
                string maxVersion = _dataTP.Where(row => row["KoContNo"].ToString() == DieCode).Max(row => row["OiNo"].ToString());

                foreach(DataRow row in _dataTP.Rows)
                { 
                    if(row["KoContNo"].ToString() == DieCode && row["OiNo"].ToString() == maxVersion)  
                    {
                        
                    }
                }
            }
        }
        
        private void CreateSideSPEC()
        {

        }
        private void CreateBFSPEC()
        {

        }
    }
}
