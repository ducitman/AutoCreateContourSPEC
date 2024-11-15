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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using System.Reflection;

namespace AutoCreateContourSPEC
{
    public partial class frmContourItemsData : DevExpress.XtraEditors.XtraForm
    {
        public frmContourItemsData()
        {
            InitializeComponent();
        }
        private DataSpecItems _specitems = new DataSpecItems();
        private DataTable _dataItemstbl;
        public class DataSpecItems
        {
            public int ID { get; set; }
            public string Parameter { get; set; }
            public string MachineType { get; set; }
            public string Registered_By { get; set; }
            public string Registered_Date { get; set; }
            public bool ParamStatus { get; set; }
        }

        private void frmContourItemsData_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            _dataItemstbl = SqlConnect_10_118_11_111.GetData(@"Select * from BTMVLocalApps.dbo.MTRL_SimulationItems");
            gridContourItemsData.DataSource = _dataItemstbl;

            // Tạo RepositoryItemButtonEdit
            RepositoryItemButtonEdit riButtonEdit = new RepositoryItemButtonEdit();
            riButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor; // Ẩn văn bản
            riButtonEdit.Buttons.Clear(); // Xóa các nút hiện tại

            // Thêm nút Update
            EditorButton updateButton = new EditorButton(ButtonPredefines.Glyph, "Update", -1, true, true, false, ImageLocation.MiddleCenter, null);
            riButtonEdit.Buttons.Add(updateButton);

            // Thêm nút Remove
            EditorButton removeButton = new EditorButton(ButtonPredefines.Glyph, "Remove", -1, true, true, false, ImageLocation.MiddleCenter, null);
            removeButton.Appearance.BackColor = Color.Red;
            removeButton.Appearance.Options.UseBackColor = true;
            riButtonEdit.Buttons.Add(removeButton);

            // Thêm sự kiện MouseHover và MouseLeave
            riButtonEdit.MouseHover += (s, e) =>
            {
                // Khi chuột di chuyển qua nút, đặt FontStyle là Bold
                removeButton.Appearance.FontStyleDelta = FontStyle.Bold;
                updateButton.Appearance.FontStyleDelta = FontStyle.Bold;
            };

            riButtonEdit.MouseLeave += (s, e) =>
            {
                // Khi chuột rời khỏi nút, đặt FontStyle trở lại bình thường
                removeButton.Appearance.FontStyleDelta = FontStyle.Regular;
                updateButton.Appearance.FontStyleDelta = FontStyle.Regular;
            };

            if (gridView.Columns["Actions"] != null)
            {
                gridView.Columns["Actions"].ColumnEdit = riButtonEdit;
            }
            else
            {
                // Tạo một cột mới
                GridColumn actionsColumn = new GridColumn();
                actionsColumn.FieldName = "Actions";
                actionsColumn.Visible = true;
                actionsColumn.VisibleIndex = gridView.Columns.Count; // Đặt vị trí cột mới ở cuối

                // Gán RepositoryItemButtonEdit cho cột mới
                actionsColumn.ColumnEdit = riButtonEdit;

                // Thêm cột mới vào GridView
                gridView.Columns.Add(actionsColumn);
            }
            riButtonEdit.ButtonClick += (s, e) =>
            {
                if (e.Button.Caption == "Update")
                {                    
                    // Xử lý sự kiện nhấp vào nút Update
                    int rowHandle = gridView.FocusedRowHandle; // Lấy hàng hiện tại
                    PropertyInfo[] properties = typeof(DataSpecItems).GetProperties();
                    for (int i = 0; i < gridView.Columns.Count; i++)
                    {
                        if (gridView.Columns[i].FieldName != "Actions") // Bỏ qua cột "Actions"
                        {
                            object cellValue = gridView.GetRowCellValue(rowHandle, gridView.Columns[i]);
                            // cellValue chứa giá trị của ô tại cột i và hàng hiện tại
                            string paramName = gridView.Columns[i].FieldName;
                            if (gridView.Columns[i].FieldName == "Registered_Date")
                            {
                                _specitems.Registered_Date = cellValue.ToString();
                            }
                            else
                            {
                                foreach (PropertyInfo property in properties)
                                {
                                    if (property.Name.ToString() == paramName)
                                    {
                                        if (property.PropertyType.Name.ToString() == "Double")
                                        {
                                            if (cellValue.ToString() != "")
                                            {
                                                typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, Convert.ToDouble(cellValue));
                                            }
                                            else
                                            {
                                                typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, 0);
                                            }
                                        }
                                        else if (property.PropertyType.Name.ToString() == "Int32")
                                        {
                                            if (cellValue.ToString() != "")
                                            {
                                                typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, Convert.ToInt32(cellValue));
                                            }
                                            else
                                            {
                                                typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, 0);
                                            }
                                        }
                                        else if (property.PropertyType.Name.ToString() == "Bool")
                                        {
                                            if (cellValue.ToString() != "1")
                                            {
                                                typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, true);
                                            }
                                            else
                                            {
                                                typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, false);
                                            }
                                        }
                                        else
                                        {
                                            typeof(DataSpecItems).GetProperty(paramName).SetValue(_specitems, cellValue);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    if (gridView.FocusedRowHandle < _dataItemstbl.Rows.Count - 1)
                    {
                        DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thay đổi dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.Yes)
                        {
                            string query = @"Update BTMVLocalApps.dbo.MTRL_SimulationItems set Parameter = '" + _specitems.Parameter + "', MachineType = '" + _specitems.MachineType + "',Registered_By = '" + _specitems.Registered_By + "',Registered_Date = '" + Convert.ToDateTime(_specitems.Registered_Date) + "',ParamStatus = '" + _specitems.ParamStatus + "' where ID = '" + _specitems.ID + "'";
                            try
                            {
                                SqlConnect_10_118_11_111.ExecuteQuery(query);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        
                        DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thêm dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.Yes)
                        {
                            string query = @"INSERT INTO BTMVLocalApps.dbo.MTRL_SimulationItems(Parameter,MachineType,Registered_By,Registered_Date,ParamStatus) VALUES ('" + _specitems.Parameter + "','" + _specitems.MachineType + "','" + _specitems.Registered_By + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + _specitems.ParamStatus + "')";
                            try
                            {
                                SqlConnect_10_118_11_111.ExecuteQuery(query);
                                btnRefresh_Click(null, null);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    
                }
                else if (e.Button.Caption == "Remove")
                {
                    // Xử lý sự kiện nhấp vào nút Remove
                    int rowHandle = gridView.FocusedRowHandle;
                    object ParamValue = gridView.GetRowCellValue(rowHandle, gridView.Columns["Parameter"]);
                    object ID = gridView.GetRowCellValue(rowHandle, gridView.Columns["ID"]);
                    DialogResult rs = MessageBox.Show("Bạn có thực sự muốn xóa dữ liệu của trường '"+ParamValue+"' không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(rs == DialogResult.Yes)
                    {
                        string query = @"Delete from MTRL_SimulationItems where ID = '" + ID + "'";
                        try
                        {
                            SqlConnect_10_118_11_111.ExecuteQuery(query);
                            btnRefresh_Click(null, null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            };
        }        

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            BindData();
            Thread.Sleep(2000);
            splashScreenManager1.CloseWaitForm();
        }

        private void btnAddDataItems_Click(object sender, EventArgs e)
        {
            gridView.AddNewRow();
            gridView.FocusedRowHandle = gridView.RowCount - 1;            
        }
    }
}