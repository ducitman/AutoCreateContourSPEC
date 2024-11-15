
namespace AutoCreateContourSPEC
{
    partial class frmPendingContourApprove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendingContourApprove));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chartReDraw = new DevExpress.XtraCharts.ChartControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gridPendingList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkReturnedContour = new System.Windows.Forms.CheckBox();
            this.checkPending = new System.Windows.Forms.CheckBox();
            this.btnApproveContour = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturnContour = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReDraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPendingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chartReDraw);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1890, 870);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.TabIndex = 0;
            // 
            // chartReDraw
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartReDraw.Diagram = xyDiagram1;
            this.chartReDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartReDraw.Legend.LegendID = -1;
            this.chartReDraw.Location = new System.Drawing.Point(0, 0);
            this.chartReDraw.Name = "chartReDraw";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = lineSeriesView1;
            series2.Name = "Series 2";
            series2.SeriesID = 1;
            series2.View = lineSeriesView2;
            series3.Name = "Series 3";
            series3.SeriesID = 2;
            series3.View = lineSeriesView3;
            series4.Name = "Series 4";
            series4.SeriesID = 3;
            series4.View = lineSeriesView4;
            series5.Name = "Series 5";
            series5.SeriesID = 4;
            series5.View = lineSeriesView5;
            series6.Name = "Series 6";
            series6.SeriesID = 5;
            series6.View = lineSeriesView6;
            series7.Name = "Series 7";
            series7.SeriesID = 6;
            series7.View = lineSeriesView7;
            this.chartReDraw.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4,
        series5,
        series6,
        series7};
            this.chartReDraw.Size = new System.Drawing.Size(1890, 375);
            this.chartReDraw.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gridPendingList);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.checkReturnedContour);
            this.splitContainer2.Panel2.Controls.Add(this.checkPending);
            this.splitContainer2.Panel2.Controls.Add(this.btnApproveContour);
            this.splitContainer2.Panel2.Controls.Add(this.btnReturnContour);
            this.splitContainer2.Size = new System.Drawing.Size(1890, 491);
            this.splitContainer2.SplitterDistance = 1630;
            this.splitContainer2.TabIndex = 1;
            // 
            // gridPendingList
            // 
            this.gridPendingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPendingList.Location = new System.Drawing.Point(0, 100);
            this.gridPendingList.MainView = this.gridView1;
            this.gridPendingList.Name = "gridPendingList";
            this.gridPendingList.Size = new System.Drawing.Size(1630, 391);
            this.gridPendingList.TabIndex = 2;
            this.gridPendingList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridPendingList.DataSourceChanged += new System.EventHandler(this.gridPendingList_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridPendingList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Size ";
            this.gridColumn1.FieldName = "ContNo";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 212;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Die No";
            this.gridColumn2.FieldName = "KoContNo";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 183;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "OiNo";
            this.gridColumn3.FieldName = "OiNo";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 217;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Reference";
            this.gridColumn4.FieldName = "BSSize";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 217;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "PIC";
            this.gridColumn5.FieldName = "DepName";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 217;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Date";
            this.gridColumn6.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "DepDate";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1630, 100);
            this.panel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(76, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(352, 29);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Danh Sách Contour Đang Chờ";
            // 
            // checkReturnedContour
            // 
            this.checkReturnedContour.AutoSize = true;
            this.checkReturnedContour.Location = new System.Drawing.Point(16, 89);
            this.checkReturnedContour.Name = "checkReturnedContour";
            this.checkReturnedContour.Size = new System.Drawing.Size(161, 23);
            this.checkReturnedContour.TabIndex = 1;
            this.checkReturnedContour.Text = "Returned Contour";
            this.checkReturnedContour.UseVisualStyleBackColor = true;
            this.checkReturnedContour.CheckedChanged += new System.EventHandler(this.checkReturnedContour_CheckedChanged);
            // 
            // checkPending
            // 
            this.checkPending.AutoSize = true;
            this.checkPending.Checked = true;
            this.checkPending.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPending.Location = new System.Drawing.Point(16, 19);
            this.checkPending.Name = "checkPending";
            this.checkPending.Size = new System.Drawing.Size(154, 23);
            this.checkPending.TabIndex = 1;
            this.checkPending.Text = "Pending Contour";
            this.checkPending.UseVisualStyleBackColor = true;
            this.checkPending.CheckedChanged += new System.EventHandler(this.checkPending_CheckedChanged);
            // 
            // btnApproveContour
            // 
            this.btnApproveContour.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApproveContour.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveContour.Appearance.Options.UseBackColor = true;
            this.btnApproveContour.Appearance.Options.UseFont = true;
            this.btnApproveContour.Location = new System.Drawing.Point(16, 296);
            this.btnApproveContour.Name = "btnApproveContour";
            this.btnApproveContour.Size = new System.Drawing.Size(216, 62);
            this.btnApproveContour.TabIndex = 2;
            this.btnApproveContour.Text = "Phê Duyệt Contour";
            this.btnApproveContour.Click += new System.EventHandler(this.btnApproveContour_Click);
            // 
            // btnReturnContour
            // 
            this.btnReturnContour.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnReturnContour.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnContour.Appearance.Options.UseBackColor = true;
            this.btnReturnContour.Appearance.Options.UseFont = true;
            this.btnReturnContour.Enabled = false;
            this.btnReturnContour.Location = new System.Drawing.Point(16, 168);
            this.btnReturnContour.Name = "btnReturnContour";
            this.btnReturnContour.Size = new System.Drawing.Size(216, 62);
            this.btnReturnContour.TabIndex = 3;
            this.btnReturnContour.Text = "Return Contour";
            this.btnReturnContour.Click += new System.EventHandler(this.btnReturnContour_Click);
            // 
            // alertControl1
            // 
            this.alertControl1.AllowHotTrack = false;
            this.alertControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceCaption.Options.UseFont = true;
            this.alertControl1.AppearanceCaption.Options.UseForeColor = true;
            this.alertControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.alertControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alertControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.alertControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceText.Options.UseFont = true;
            this.alertControl1.AppearanceText.Options.UseTextOptions = true;
            this.alertControl1.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alertControl1.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.alertControl1.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.alertControl1.AutoFormDelay = 5000;
            this.alertControl1.AutoHeight = true;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertControl1.ShowPinButton = false;
            // 
            // frmPendingContourApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 870);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmPendingContourApprove.IconOptions.LargeImage")));
            this.Name = "frmPendingContourApprove";
            this.Text = "Danh Sách Đang Chờ Phê Duyệt";
            this.Load += new System.EventHandler(this.frmPendingContourApprove_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReDraw)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPendingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraCharts.ChartControl chartReDraw;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl gridPendingList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox checkReturnedContour;
        private System.Windows.Forms.CheckBox checkPending;
        private DevExpress.XtraEditors.SimpleButton btnApproveContour;
        private DevExpress.XtraEditors.SimpleButton btnReturnContour;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
    }
}