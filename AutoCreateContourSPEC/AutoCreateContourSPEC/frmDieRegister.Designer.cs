
namespace AutoCreateContourSPEC
{
    partial class frmDieRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDieRegister));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnDieEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDieRegister = new DevExpress.XtraEditors.SimpleButton();
            this.gridApprovedDieNo = new DevExpress.XtraGrid.GridControl();
            this.gridViewApprovedDieNo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AutoCreateContourSPEC.WaitForm1), true, true);
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridApprovedDieNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovedDieNo)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnDieEdit);
            this.splitContainer1.Panel1.Controls.Add(this.btnDieRegister);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridApprovedDieNo);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 763);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(922, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 75);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDieEdit
            // 
            this.btnDieEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDieEdit.Appearance.Options.UseBackColor = true;
            this.btnDieEdit.Location = new System.Drawing.Point(334, 12);
            this.btnDieEdit.Name = "btnDieEdit";
            this.btnDieEdit.Size = new System.Drawing.Size(173, 75);
            this.btnDieEdit.TabIndex = 0;
            this.btnDieEdit.Text = "Sửa Thông Tin Die";
            this.btnDieEdit.Click += new System.EventHandler(this.btnDieEdit_Click);
            // 
            // btnDieRegister
            // 
            this.btnDieRegister.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDieRegister.Appearance.Options.UseBackColor = true;
            this.btnDieRegister.Location = new System.Drawing.Point(40, 12);
            this.btnDieRegister.Name = "btnDieRegister";
            this.btnDieRegister.Size = new System.Drawing.Size(173, 75);
            this.btnDieRegister.TabIndex = 0;
            this.btnDieRegister.Text = "Đăng ký Die";
            this.btnDieRegister.Click += new System.EventHandler(this.btnDieRegister_Click);
            // 
            // gridApprovedDieNo
            // 
            this.gridApprovedDieNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridApprovedDieNo.Location = new System.Drawing.Point(0, 0);
            this.gridApprovedDieNo.MainView = this.gridViewApprovedDieNo;
            this.gridApprovedDieNo.Name = "gridApprovedDieNo";
            this.gridApprovedDieNo.Size = new System.Drawing.Size(1135, 658);
            this.gridApprovedDieNo.TabIndex = 4;
            this.gridApprovedDieNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewApprovedDieNo});
            // 
            // gridViewApprovedDieNo
            // 
            this.gridViewApprovedDieNo.GridControl = this.gridApprovedDieNo;
            this.gridViewApprovedDieNo.Name = "gridViewApprovedDieNo";
            this.gridViewApprovedDieNo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewApprovedDieNo.OptionsView.ShowGroupPanel = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(628, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(173, 75);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDieRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 763);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDieRegister.IconOptions.LargeImage")));
            this.Name = "frmDieRegister";
            this.Text = "Đăng Ký DieNo";
            this.Load += new System.EventHandler(this.frmDieRegister_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridApprovedDieNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovedDieNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnDieEdit;
        private DevExpress.XtraEditors.SimpleButton btnDieRegister;
        private DevExpress.XtraGrid.GridControl gridApprovedDieNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewApprovedDieNo;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}