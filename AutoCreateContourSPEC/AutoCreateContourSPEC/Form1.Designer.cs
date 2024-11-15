
namespace AutoCreateContourSPEC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApprove = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xTabBF = new DevExpress.XtraTab.XtraTabPage();
            this.gridBFData = new DevExpress.XtraGrid.GridControl();
            this.pSRBFSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAccessDB1 = new AutoCreateContourSPEC.DataAccessDB();
            this.gridViewBF = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContNoBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKoContNoBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOiNoBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBSSizeBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReasonBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNoBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepNameBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepDateBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugeNumBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugePosBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugeBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateCodeBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotesBF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTabSide = new DevExpress.XtraTab.XtraTabPage();
            this.gridSideData = new DevExpress.XtraGrid.GridControl();
            this.pSRSideSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewSide = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContNoSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKoContNoSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBSSizeSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReasonSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNoSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbaNoSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepNameSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWidSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHumpGaugeSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepDateSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugeNumSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugePosSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugeSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotesSide = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xTabTop = new DevExpress.XtraTab.XtraTabPage();
            this.gridTopData = new DevExpress.XtraGrid.GridControl();
            this.pSRTopSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewTop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContNoTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKoContNoTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOiNoTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBSSizeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatNameTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReasonTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefNoTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbaNoTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepNameTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWidTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHumpWidTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHumpGaugeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSplitPosTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSplitGaugeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMPosTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBMGaugeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepDateTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugeNumTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugePosTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGaugeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStateCodeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCenterGaugeTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotesTop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.psrbfTableAdapter1 = new AutoCreateContourSPEC.DataAccessDBTableAdapters.PSRBFTableAdapter();
            this.psrbsideTableAdapter1 = new AutoCreateContourSPEC.DataAccessDBTableAdapters.PSRBSIDETableAdapter();
            this.psrtopTableAdapter1 = new AutoCreateContourSPEC.DataAccessDBTableAdapters.PSRTOPTableAdapter();
            this.dataAppLogs1 = new AutoCreateContourSPEC.DataAppLogs();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xTabBF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBFData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSRBFSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccessDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBF)).BeginInit();
            this.xTabSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSideData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSRSideSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSide)).BeginInit();
            this.xTabTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSRTopSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppLogs1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1768, 841);
            this.splitContainer1.SplitterDistance = 87;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1768, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAll.ImageOptions.Image")));
            this.btnAll.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btnAll.Location = new System.Drawing.Point(1339, 29);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(201, 39);
            this.btnAll.TabIndex = 6;
            this.btnAll.Text = "Hiển thị tất cả";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.ImageOptions.Image")));
            this.btnFilter.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btnFilter.Location = new System.Drawing.Point(1174, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(119, 39);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến:";
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(905, 28);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(233, 40);
            this.dateTo.TabIndex = 4;
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(595, 28);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(233, 40);
            this.dateFrom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phần mềm tạo SPEC Contour tự động";
            // 
            // btnApprove
            // 
            this.btnApprove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApprove.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApprove.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.btnApprove.Appearance.Options.UseBackColor = true;
            this.btnApprove.Appearance.Options.UseBorderColor = true;
            this.btnApprove.Appearance.Options.UseFont = true;
            this.btnApprove.Appearance.Options.UseForeColor = true;
            this.btnApprove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnApprove.Location = new System.Drawing.Point(1645, 0);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(123, 87);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Approve";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xTabBF;
            this.xtraTabControl1.Size = new System.Drawing.Size(1768, 750);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xTabBF,
            this.xTabSide,
            this.xTabTop});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xTabBF
            // 
            this.xTabBF.Controls.Add(this.gridBFData);
            this.xTabBF.Name = "xTabBF";
            this.xTabBF.Size = new System.Drawing.Size(1766, 706);
            this.xTabBF.Text = "BF";
            // 
            // gridBFData
            // 
            this.gridBFData.DataSource = this.pSRBFSource;
            this.gridBFData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBFData.Location = new System.Drawing.Point(0, 0);
            this.gridBFData.MainView = this.gridViewBF;
            this.gridBFData.Name = "gridBFData";
            this.gridBFData.Size = new System.Drawing.Size(1766, 706);
            this.gridBFData.TabIndex = 0;
            this.gridBFData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBF});
            // 
            // pSRBFSource
            // 
            this.pSRBFSource.DataMember = "PSRBF";
            this.pSRBFSource.DataSource = this.dataAccessDB1;
            // 
            // dataAccessDB1
            // 
            this.dataAccessDB1.DataSetName = "DataAccessDB";
            this.dataAccessDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewBF
            // 
            this.gridViewBF.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContNoBF,
            this.colKoContNoBF,
            this.colOiNoBF,
            this.colBSSizeBF,
            this.colReasonBF,
            this.colRefNoBF,
            this.colDepNameBF,
            this.colDepDateBF,
            this.colGaugeNumBF,
            this.colGaugePosBF,
            this.colGaugeBF,
            this.colStateCodeBF,
            this.colNotesBF});
            this.gridViewBF.GridControl = this.gridBFData;
            this.gridViewBF.Name = "gridViewBF";
            this.gridViewBF.OptionsBehavior.ReadOnly = true;
            this.gridViewBF.OptionsView.ShowAutoFilterRow = true;
            this.gridViewBF.OptionsView.ShowGroupPanel = false;
            // 
            // colContNoBF
            // 
            this.colContNoBF.Caption = "Cont No";
            this.colContNoBF.FieldName = "ContNo";
            this.colContNoBF.MinWidth = 30;
            this.colContNoBF.Name = "colContNoBF";
            this.colContNoBF.Visible = true;
            this.colContNoBF.VisibleIndex = 0;
            this.colContNoBF.Width = 112;
            // 
            // colKoContNoBF
            // 
            this.colKoContNoBF.Caption = "Ko No";
            this.colKoContNoBF.FieldName = "KoContNo";
            this.colKoContNoBF.MinWidth = 30;
            this.colKoContNoBF.Name = "colKoContNoBF";
            this.colKoContNoBF.Visible = true;
            this.colKoContNoBF.VisibleIndex = 1;
            this.colKoContNoBF.Width = 112;
            // 
            // colOiNoBF
            // 
            this.colOiNoBF.Caption = "Oi No";
            this.colOiNoBF.FieldName = "OiNo";
            this.colOiNoBF.MinWidth = 30;
            this.colOiNoBF.Name = "colOiNoBF";
            this.colOiNoBF.Visible = true;
            this.colOiNoBF.VisibleIndex = 2;
            this.colOiNoBF.Width = 112;
            // 
            // colBSSizeBF
            // 
            this.colBSSizeBF.Caption = "BSSize";
            this.colBSSizeBF.FieldName = "BSSize";
            this.colBSSizeBF.MinWidth = 30;
            this.colBSSizeBF.Name = "colBSSizeBF";
            this.colBSSizeBF.Visible = true;
            this.colBSSizeBF.VisibleIndex = 3;
            this.colBSSizeBF.Width = 112;
            // 
            // colReasonBF
            // 
            this.colReasonBF.Caption = "Reason";
            this.colReasonBF.FieldName = "Reason";
            this.colReasonBF.MinWidth = 30;
            this.colReasonBF.Name = "colReasonBF";
            this.colReasonBF.Visible = true;
            this.colReasonBF.VisibleIndex = 4;
            this.colReasonBF.Width = 112;
            // 
            // colRefNoBF
            // 
            this.colRefNoBF.Caption = "RefNo";
            this.colRefNoBF.FieldName = "RefNo";
            this.colRefNoBF.MinWidth = 30;
            this.colRefNoBF.Name = "colRefNoBF";
            this.colRefNoBF.Visible = true;
            this.colRefNoBF.VisibleIndex = 5;
            this.colRefNoBF.Width = 112;
            // 
            // colDepNameBF
            // 
            this.colDepNameBF.Caption = "DepName";
            this.colDepNameBF.FieldName = "DepName";
            this.colDepNameBF.MinWidth = 30;
            this.colDepNameBF.Name = "colDepNameBF";
            this.colDepNameBF.Visible = true;
            this.colDepNameBF.VisibleIndex = 6;
            this.colDepNameBF.Width = 112;
            // 
            // colDepDateBF
            // 
            this.colDepDateBF.Caption = "DepDate";
            this.colDepDateBF.FieldName = "DepDate";
            this.colDepDateBF.MinWidth = 30;
            this.colDepDateBF.Name = "colDepDateBF";
            this.colDepDateBF.Visible = true;
            this.colDepDateBF.VisibleIndex = 7;
            this.colDepDateBF.Width = 112;
            // 
            // colGaugeNumBF
            // 
            this.colGaugeNumBF.Caption = "GaugeNum";
            this.colGaugeNumBF.FieldName = "GaugeNum";
            this.colGaugeNumBF.MinWidth = 30;
            this.colGaugeNumBF.Name = "colGaugeNumBF";
            this.colGaugeNumBF.Visible = true;
            this.colGaugeNumBF.VisibleIndex = 8;
            this.colGaugeNumBF.Width = 112;
            // 
            // colGaugePosBF
            // 
            this.colGaugePosBF.Caption = "GaugePos";
            this.colGaugePosBF.FieldName = "GaugePos";
            this.colGaugePosBF.MinWidth = 30;
            this.colGaugePosBF.Name = "colGaugePosBF";
            this.colGaugePosBF.Visible = true;
            this.colGaugePosBF.VisibleIndex = 9;
            this.colGaugePosBF.Width = 112;
            // 
            // colGaugeBF
            // 
            this.colGaugeBF.Caption = "Gauge ";
            this.colGaugeBF.FieldName = "Gauge";
            this.colGaugeBF.MinWidth = 30;
            this.colGaugeBF.Name = "colGaugeBF";
            this.colGaugeBF.Visible = true;
            this.colGaugeBF.VisibleIndex = 10;
            this.colGaugeBF.Width = 112;
            // 
            // colStateCodeBF
            // 
            this.colStateCodeBF.Caption = "State Code";
            this.colStateCodeBF.FieldName = "StateCode";
            this.colStateCodeBF.MinWidth = 30;
            this.colStateCodeBF.Name = "colStateCodeBF";
            this.colStateCodeBF.Visible = true;
            this.colStateCodeBF.VisibleIndex = 11;
            this.colStateCodeBF.Width = 112;
            // 
            // colNotesBF
            // 
            this.colNotesBF.Caption = "Notes";
            this.colNotesBF.FieldName = "Notes";
            this.colNotesBF.MinWidth = 30;
            this.colNotesBF.Name = "colNotesBF";
            this.colNotesBF.Visible = true;
            this.colNotesBF.VisibleIndex = 12;
            this.colNotesBF.Width = 112;
            // 
            // xTabSide
            // 
            this.xTabSide.Controls.Add(this.gridSideData);
            this.xTabSide.Name = "xTabSide";
            this.xTabSide.Size = new System.Drawing.Size(1766, 706);
            this.xTabSide.Text = "SIDE";
            // 
            // gridSideData
            // 
            this.gridSideData.DataSource = this.pSRSideSource;
            this.gridSideData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSideData.Location = new System.Drawing.Point(0, 0);
            this.gridSideData.MainView = this.gridViewSide;
            this.gridSideData.Name = "gridSideData";
            this.gridSideData.Size = new System.Drawing.Size(1766, 706);
            this.gridSideData.TabIndex = 1;
            this.gridSideData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSide});
            // 
            // pSRSideSource
            // 
            this.pSRSideSource.DataMember = "PSRBSIDE";
            this.pSRSideSource.DataSource = this.dataAccessDB1;
            // 
            // gridViewSide
            // 
            this.gridViewSide.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContNoSide,
            this.colKoContNoSide,
            this.colOiNo,
            this.colBSSizeSide,
            this.colReasonSide,
            this.colRefNoSide,
            this.colAbaNoSide,
            this.colDepNameSide,
            this.colWidSide,
            this.colHumpGaugeSide,
            this.colDepDateSide,
            this.colGaugeNumSide,
            this.colGaugePosSide,
            this.colGaugeSide,
            this.colNotesSide});
            this.gridViewSide.GridControl = this.gridSideData;
            this.gridViewSide.Name = "gridViewSide";
            this.gridViewSide.OptionsBehavior.ReadOnly = true;
            this.gridViewSide.OptionsView.ShowAutoFilterRow = true;
            this.gridViewSide.OptionsView.ShowGroupPanel = false;
            // 
            // colContNoSide
            // 
            this.colContNoSide.Caption = "ContNo";
            this.colContNoSide.FieldName = "ContNo";
            this.colContNoSide.MinWidth = 30;
            this.colContNoSide.Name = "colContNoSide";
            this.colContNoSide.Visible = true;
            this.colContNoSide.VisibleIndex = 0;
            this.colContNoSide.Width = 112;
            // 
            // colKoContNoSide
            // 
            this.colKoContNoSide.Caption = "Ko No";
            this.colKoContNoSide.FieldName = "KoContNo";
            this.colKoContNoSide.MinWidth = 30;
            this.colKoContNoSide.Name = "colKoContNoSide";
            this.colKoContNoSide.Visible = true;
            this.colKoContNoSide.VisibleIndex = 1;
            this.colKoContNoSide.Width = 112;
            // 
            // colOiNo
            // 
            this.colOiNo.Caption = "Oi No";
            this.colOiNo.FieldName = "OiNo";
            this.colOiNo.MinWidth = 30;
            this.colOiNo.Name = "colOiNo";
            this.colOiNo.Visible = true;
            this.colOiNo.VisibleIndex = 2;
            this.colOiNo.Width = 112;
            // 
            // colBSSizeSide
            // 
            this.colBSSizeSide.Caption = "BSSize";
            this.colBSSizeSide.FieldName = "BSSize";
            this.colBSSizeSide.MinWidth = 30;
            this.colBSSizeSide.Name = "colBSSizeSide";
            this.colBSSizeSide.Visible = true;
            this.colBSSizeSide.VisibleIndex = 3;
            this.colBSSizeSide.Width = 112;
            // 
            // colReasonSide
            // 
            this.colReasonSide.Caption = "Reason";
            this.colReasonSide.FieldName = "Reason";
            this.colReasonSide.MinWidth = 30;
            this.colReasonSide.Name = "colReasonSide";
            this.colReasonSide.Visible = true;
            this.colReasonSide.VisibleIndex = 4;
            this.colReasonSide.Width = 112;
            // 
            // colRefNoSide
            // 
            this.colRefNoSide.Caption = "Ref No";
            this.colRefNoSide.FieldName = "RefNo";
            this.colRefNoSide.MinWidth = 30;
            this.colRefNoSide.Name = "colRefNoSide";
            this.colRefNoSide.Visible = true;
            this.colRefNoSide.VisibleIndex = 5;
            this.colRefNoSide.Width = 112;
            // 
            // colAbaNoSide
            // 
            this.colAbaNoSide.Caption = "AbaNo";
            this.colAbaNoSide.FieldName = "AbaNo";
            this.colAbaNoSide.MinWidth = 30;
            this.colAbaNoSide.Name = "colAbaNoSide";
            this.colAbaNoSide.Visible = true;
            this.colAbaNoSide.VisibleIndex = 6;
            this.colAbaNoSide.Width = 112;
            // 
            // colDepNameSide
            // 
            this.colDepNameSide.Caption = "DepName";
            this.colDepNameSide.FieldName = "DepName";
            this.colDepNameSide.MinWidth = 30;
            this.colDepNameSide.Name = "colDepNameSide";
            this.colDepNameSide.Visible = true;
            this.colDepNameSide.VisibleIndex = 7;
            this.colDepNameSide.Width = 112;
            // 
            // colWidSide
            // 
            this.colWidSide.Caption = "Wid ";
            this.colWidSide.FieldName = "Wid";
            this.colWidSide.MinWidth = 30;
            this.colWidSide.Name = "colWidSide";
            this.colWidSide.Visible = true;
            this.colWidSide.VisibleIndex = 8;
            this.colWidSide.Width = 112;
            // 
            // colHumpGaugeSide
            // 
            this.colHumpGaugeSide.Caption = "HumpGauge";
            this.colHumpGaugeSide.FieldName = "HumpGauge";
            this.colHumpGaugeSide.MinWidth = 30;
            this.colHumpGaugeSide.Name = "colHumpGaugeSide";
            this.colHumpGaugeSide.Visible = true;
            this.colHumpGaugeSide.VisibleIndex = 9;
            this.colHumpGaugeSide.Width = 112;
            // 
            // colDepDateSide
            // 
            this.colDepDateSide.Caption = "DepDate";
            this.colDepDateSide.FieldName = "DepDate";
            this.colDepDateSide.MinWidth = 30;
            this.colDepDateSide.Name = "colDepDateSide";
            this.colDepDateSide.Visible = true;
            this.colDepDateSide.VisibleIndex = 10;
            this.colDepDateSide.Width = 112;
            // 
            // colGaugeNumSide
            // 
            this.colGaugeNumSide.Caption = "GaugeNum";
            this.colGaugeNumSide.FieldName = "GaugeNum";
            this.colGaugeNumSide.MinWidth = 30;
            this.colGaugeNumSide.Name = "colGaugeNumSide";
            this.colGaugeNumSide.Visible = true;
            this.colGaugeNumSide.VisibleIndex = 11;
            this.colGaugeNumSide.Width = 112;
            // 
            // colGaugePosSide
            // 
            this.colGaugePosSide.Caption = "GaugePos";
            this.colGaugePosSide.FieldName = "GaugePos";
            this.colGaugePosSide.MinWidth = 30;
            this.colGaugePosSide.Name = "colGaugePosSide";
            this.colGaugePosSide.Visible = true;
            this.colGaugePosSide.VisibleIndex = 12;
            this.colGaugePosSide.Width = 112;
            // 
            // colGaugeSide
            // 
            this.colGaugeSide.Caption = "Gauge";
            this.colGaugeSide.FieldName = "Gauge";
            this.colGaugeSide.MinWidth = 30;
            this.colGaugeSide.Name = "colGaugeSide";
            this.colGaugeSide.Visible = true;
            this.colGaugeSide.VisibleIndex = 13;
            this.colGaugeSide.Width = 112;
            // 
            // colNotesSide
            // 
            this.colNotesSide.Caption = "Notes";
            this.colNotesSide.FieldName = "Notes";
            this.colNotesSide.MinWidth = 30;
            this.colNotesSide.Name = "colNotesSide";
            this.colNotesSide.Visible = true;
            this.colNotesSide.VisibleIndex = 14;
            this.colNotesSide.Width = 112;
            // 
            // xTabTop
            // 
            this.xTabTop.Controls.Add(this.gridTopData);
            this.xTabTop.Name = "xTabTop";
            this.xTabTop.Size = new System.Drawing.Size(1766, 706);
            this.xTabTop.Text = "TOP";
            // 
            // gridTopData
            // 
            this.gridTopData.DataSource = this.pSRTopSource;
            this.gridTopData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTopData.Location = new System.Drawing.Point(0, 0);
            this.gridTopData.MainView = this.gridViewTop;
            this.gridTopData.Name = "gridTopData";
            this.gridTopData.Size = new System.Drawing.Size(1766, 706);
            this.gridTopData.TabIndex = 1;
            this.gridTopData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTop});
            // 
            // pSRTopSource
            // 
            this.pSRTopSource.DataMember = "PSRTOP";
            this.pSRTopSource.DataSource = this.dataAccessDB1;
            // 
            // gridViewTop
            // 
            this.gridViewTop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContNoTop,
            this.colKoContNoTop,
            this.colOiNoTop,
            this.colBSSizeTop,
            this.colMatNameTop,
            this.colReasonTop,
            this.colRefNoTop,
            this.colAbaNoTop,
            this.colDepNameTop,
            this.colWidTop,
            this.colHumpWidTop,
            this.colHumpGaugeTop,
            this.colSplitPosTop,
            this.colSplitGaugeTop,
            this.colBMPosTop,
            this.colBMGaugeTop,
            this.colDepDateTop,
            this.colGaugeNumTop,
            this.colGaugePosTop,
            this.colGaugeTop,
            this.colStateCodeTop,
            this.colCenterGaugeTop,
            this.colNotesTop});
            this.gridViewTop.GridControl = this.gridTopData;
            this.gridViewTop.Name = "gridViewTop";
            this.gridViewTop.OptionsBehavior.ReadOnly = true;
            this.gridViewTop.OptionsView.ShowAutoFilterRow = true;
            this.gridViewTop.OptionsView.ShowGroupPanel = false;
            // 
            // colContNoTop
            // 
            this.colContNoTop.Caption = "ContNo";
            this.colContNoTop.FieldName = "ContNo";
            this.colContNoTop.MinWidth = 30;
            this.colContNoTop.Name = "colContNoTop";
            this.colContNoTop.Visible = true;
            this.colContNoTop.VisibleIndex = 0;
            this.colContNoTop.Width = 112;
            // 
            // colKoContNoTop
            // 
            this.colKoContNoTop.FieldName = "KoContNo";
            this.colKoContNoTop.MinWidth = 30;
            this.colKoContNoTop.Name = "colKoContNoTop";
            this.colKoContNoTop.Visible = true;
            this.colKoContNoTop.VisibleIndex = 1;
            this.colKoContNoTop.Width = 112;
            // 
            // colOiNoTop
            // 
            this.colOiNoTop.Caption = "Oi No";
            this.colOiNoTop.FieldName = "OiNo";
            this.colOiNoTop.MinWidth = 30;
            this.colOiNoTop.Name = "colOiNoTop";
            this.colOiNoTop.Visible = true;
            this.colOiNoTop.VisibleIndex = 2;
            this.colOiNoTop.Width = 112;
            // 
            // colBSSizeTop
            // 
            this.colBSSizeTop.Caption = "BS Size";
            this.colBSSizeTop.FieldName = "BSSize";
            this.colBSSizeTop.MinWidth = 30;
            this.colBSSizeTop.Name = "colBSSizeTop";
            this.colBSSizeTop.Visible = true;
            this.colBSSizeTop.VisibleIndex = 3;
            this.colBSSizeTop.Width = 112;
            // 
            // colMatNameTop
            // 
            this.colMatNameTop.Caption = "MatName";
            this.colMatNameTop.FieldName = "MatName";
            this.colMatNameTop.MinWidth = 30;
            this.colMatNameTop.Name = "colMatNameTop";
            this.colMatNameTop.Visible = true;
            this.colMatNameTop.VisibleIndex = 4;
            this.colMatNameTop.Width = 112;
            // 
            // colReasonTop
            // 
            this.colReasonTop.Caption = "Reason ";
            this.colReasonTop.FieldName = "Reason";
            this.colReasonTop.MinWidth = 30;
            this.colReasonTop.Name = "colReasonTop";
            this.colReasonTop.Visible = true;
            this.colReasonTop.VisibleIndex = 5;
            this.colReasonTop.Width = 112;
            // 
            // colRefNoTop
            // 
            this.colRefNoTop.Caption = "RefNo";
            this.colRefNoTop.FieldName = "RefNo";
            this.colRefNoTop.MinWidth = 30;
            this.colRefNoTop.Name = "colRefNoTop";
            this.colRefNoTop.Visible = true;
            this.colRefNoTop.VisibleIndex = 6;
            this.colRefNoTop.Width = 112;
            // 
            // colAbaNoTop
            // 
            this.colAbaNoTop.Caption = "AbaNo";
            this.colAbaNoTop.FieldName = "AbaNo";
            this.colAbaNoTop.MinWidth = 30;
            this.colAbaNoTop.Name = "colAbaNoTop";
            this.colAbaNoTop.Visible = true;
            this.colAbaNoTop.VisibleIndex = 7;
            this.colAbaNoTop.Width = 112;
            // 
            // colDepNameTop
            // 
            this.colDepNameTop.Caption = "DepName";
            this.colDepNameTop.FieldName = "DepName";
            this.colDepNameTop.MinWidth = 30;
            this.colDepNameTop.Name = "colDepNameTop";
            this.colDepNameTop.Visible = true;
            this.colDepNameTop.VisibleIndex = 8;
            this.colDepNameTop.Width = 112;
            // 
            // colWidTop
            // 
            this.colWidTop.Caption = "Wid Top";
            this.colWidTop.FieldName = "Wid";
            this.colWidTop.MinWidth = 30;
            this.colWidTop.Name = "colWidTop";
            this.colWidTop.Visible = true;
            this.colWidTop.VisibleIndex = 9;
            this.colWidTop.Width = 112;
            // 
            // colHumpWidTop
            // 
            this.colHumpWidTop.Caption = "HumpWid";
            this.colHumpWidTop.FieldName = "HumpWid";
            this.colHumpWidTop.MinWidth = 30;
            this.colHumpWidTop.Name = "colHumpWidTop";
            this.colHumpWidTop.Width = 112;
            // 
            // colHumpGaugeTop
            // 
            this.colHumpGaugeTop.Caption = "HumpGauge";
            this.colHumpGaugeTop.FieldName = "HumpGauge";
            this.colHumpGaugeTop.MinWidth = 30;
            this.colHumpGaugeTop.Name = "colHumpGaugeTop";
            this.colHumpGaugeTop.Width = 112;
            // 
            // colSplitPosTop
            // 
            this.colSplitPosTop.Caption = "SplitPos";
            this.colSplitPosTop.FieldName = "SplitPos";
            this.colSplitPosTop.MinWidth = 30;
            this.colSplitPosTop.Name = "colSplitPosTop";
            this.colSplitPosTop.Width = 112;
            // 
            // colSplitGaugeTop
            // 
            this.colSplitGaugeTop.Caption = "Split Gauge";
            this.colSplitGaugeTop.FieldName = "SplitGauge";
            this.colSplitGaugeTop.MinWidth = 30;
            this.colSplitGaugeTop.Name = "colSplitGaugeTop";
            this.colSplitGaugeTop.Width = 112;
            // 
            // colBMPosTop
            // 
            this.colBMPosTop.Caption = "BMPos";
            this.colBMPosTop.FieldName = "BMPos";
            this.colBMPosTop.MinWidth = 30;
            this.colBMPosTop.Name = "colBMPosTop";
            this.colBMPosTop.Width = 112;
            // 
            // colBMGaugeTop
            // 
            this.colBMGaugeTop.Caption = "BMGauge";
            this.colBMGaugeTop.FieldName = "BMGauge";
            this.colBMGaugeTop.MinWidth = 30;
            this.colBMGaugeTop.Name = "colBMGaugeTop";
            this.colBMGaugeTop.Width = 112;
            // 
            // colDepDateTop
            // 
            this.colDepDateTop.Caption = "DepDate";
            this.colDepDateTop.FieldName = "DepDate";
            this.colDepDateTop.MinWidth = 30;
            this.colDepDateTop.Name = "colDepDateTop";
            this.colDepDateTop.Visible = true;
            this.colDepDateTop.VisibleIndex = 10;
            this.colDepDateTop.Width = 112;
            // 
            // colGaugeNumTop
            // 
            this.colGaugeNumTop.Caption = "GaugeNum";
            this.colGaugeNumTop.FieldName = "GaugeNum";
            this.colGaugeNumTop.MinWidth = 30;
            this.colGaugeNumTop.Name = "colGaugeNumTop";
            this.colGaugeNumTop.Visible = true;
            this.colGaugeNumTop.VisibleIndex = 11;
            this.colGaugeNumTop.Width = 112;
            // 
            // colGaugePosTop
            // 
            this.colGaugePosTop.Caption = "GaugePos";
            this.colGaugePosTop.FieldName = "GaugePos";
            this.colGaugePosTop.MinWidth = 30;
            this.colGaugePosTop.Name = "colGaugePosTop";
            this.colGaugePosTop.Visible = true;
            this.colGaugePosTop.VisibleIndex = 12;
            this.colGaugePosTop.Width = 112;
            // 
            // colGaugeTop
            // 
            this.colGaugeTop.Caption = "Gauge";
            this.colGaugeTop.FieldName = "Gauge";
            this.colGaugeTop.MinWidth = 30;
            this.colGaugeTop.Name = "colGaugeTop";
            this.colGaugeTop.Visible = true;
            this.colGaugeTop.VisibleIndex = 13;
            this.colGaugeTop.Width = 112;
            // 
            // colStateCodeTop
            // 
            this.colStateCodeTop.Caption = "State Code";
            this.colStateCodeTop.FieldName = "StageCode";
            this.colStateCodeTop.MinWidth = 30;
            this.colStateCodeTop.Name = "colStateCodeTop";
            this.colStateCodeTop.Width = 112;
            // 
            // colCenterGaugeTop
            // 
            this.colCenterGaugeTop.Caption = "CenterGauge";
            this.colCenterGaugeTop.FieldName = "CenterGauge";
            this.colCenterGaugeTop.MinWidth = 30;
            this.colCenterGaugeTop.Name = "colCenterGaugeTop";
            this.colCenterGaugeTop.Width = 112;
            // 
            // colNotesTop
            // 
            this.colNotesTop.Caption = "Notes";
            this.colNotesTop.FieldName = "Notes";
            this.colNotesTop.MinWidth = 30;
            this.colNotesTop.Name = "colNotesTop";
            this.colNotesTop.Visible = true;
            this.colNotesTop.VisibleIndex = 14;
            this.colNotesTop.Width = 112;
            // 
            // psrbfTableAdapter1
            // 
            this.psrbfTableAdapter1.ClearBeforeFill = true;
            // 
            // psrbsideTableAdapter1
            // 
            this.psrbsideTableAdapter1.ClearBeforeFill = true;
            // 
            // psrtopTableAdapter1
            // 
            this.psrtopTableAdapter1.ClearBeforeFill = true;
            // 
            // dataAppLogs1
            // 
            this.dataAppLogs1.DataSetName = "DataAppLogs";
            this.dataAppLogs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 841);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Phê Duyệt Contour Spec";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xTabBF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBFData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSRBFSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccessDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBF)).EndInit();
            this.xTabSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSideData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSRSideSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSide)).EndInit();
            this.xTabTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTopData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSRTopSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAppLogs1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xTabBF;
        private DevExpress.XtraGrid.GridControl gridBFData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBF;
        private DevExpress.XtraTab.XtraTabPage xTabSide;
        private DevExpress.XtraTab.XtraTabPage xTabTop;
        private DevExpress.XtraGrid.GridControl gridSideData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSide;
        private DevExpress.XtraGrid.GridControl gridTopData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTop;
        private DevExpress.XtraGrid.Columns.GridColumn colContNoBF;
        private DevExpress.XtraGrid.Columns.GridColumn colKoContNoBF;
        private DevExpress.XtraGrid.Columns.GridColumn colOiNoBF;
        private DevExpress.XtraGrid.Columns.GridColumn colBSSizeBF;
        private DevExpress.XtraGrid.Columns.GridColumn colReasonBF;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNoBF;
        private DevExpress.XtraGrid.Columns.GridColumn colDepNameBF;
        private DevExpress.XtraGrid.Columns.GridColumn colDepDateBF;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugeNumBF;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugePosBF;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugeBF;
        private DevExpress.XtraGrid.Columns.GridColumn colStateCodeBF;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesBF;
        private DevExpress.XtraGrid.Columns.GridColumn colContNoSide;
        private DevExpress.XtraGrid.Columns.GridColumn colKoContNoSide;
        private DevExpress.XtraGrid.Columns.GridColumn colOiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBSSizeSide;
        private DevExpress.XtraGrid.Columns.GridColumn colReasonSide;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNoSide;
        private DevExpress.XtraGrid.Columns.GridColumn colAbaNoSide;
        private DevExpress.XtraGrid.Columns.GridColumn colDepNameSide;
        private DevExpress.XtraGrid.Columns.GridColumn colWidSide;
        private DevExpress.XtraGrid.Columns.GridColumn colHumpGaugeSide;
        private DevExpress.XtraGrid.Columns.GridColumn colDepDateSide;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugeNumSide;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugePosSide;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugeSide;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesSide;
        private DevExpress.XtraGrid.Columns.GridColumn colContNoTop;
        private DevExpress.XtraGrid.Columns.GridColumn colKoContNoTop;
        private DevExpress.XtraGrid.Columns.GridColumn colOiNoTop;
        private DevExpress.XtraGrid.Columns.GridColumn colBSSizeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colMatNameTop;
        private DevExpress.XtraGrid.Columns.GridColumn colReasonTop;
        private DevExpress.XtraGrid.Columns.GridColumn colRefNoTop;
        private DevExpress.XtraGrid.Columns.GridColumn colAbaNoTop;
        private DevExpress.XtraGrid.Columns.GridColumn colDepNameTop;
        private DevExpress.XtraGrid.Columns.GridColumn colWidTop;
        private DevExpress.XtraGrid.Columns.GridColumn colHumpWidTop;
        private DevExpress.XtraGrid.Columns.GridColumn colHumpGaugeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colSplitPosTop;
        private DevExpress.XtraGrid.Columns.GridColumn colSplitGaugeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colBMPosTop;
        private DevExpress.XtraGrid.Columns.GridColumn colBMGaugeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colDepDateTop;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugeNumTop;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugePosTop;
        private DevExpress.XtraGrid.Columns.GridColumn colGaugeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colStateCodeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colCenterGaugeTop;
        private DevExpress.XtraGrid.Columns.GridColumn colNotesTop;
        private DataAccessDB dataAccessDB1;
        private DataAccessDBTableAdapters.PSRBFTableAdapter psrbfTableAdapter1;
        private DataAccessDBTableAdapters.PSRBSIDETableAdapter psrbsideTableAdapter1;
        private DataAccessDBTableAdapters.PSRTOPTableAdapter psrtopTableAdapter1;
        private System.Windows.Forms.BindingSource pSRBFSource;
        private System.Windows.Forms.BindingSource pSRSideSource;
        private System.Windows.Forms.BindingSource pSRTopSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnApprove;
        private DataAppLogs dataAppLogs1;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.SimpleButton btnAll;
    }
}

