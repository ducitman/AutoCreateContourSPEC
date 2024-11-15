
namespace AutoCreateContourSPEC
{
    partial class frmContourItemsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContourItemsData));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDataItems = new DevExpress.XtraEditors.SimpleButton();
            this.gridContourItemsData = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AutoCreateContourSPEC.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContourItemsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddDataItems);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridContourItemsData);
            this.splitContainer1.Size = new System.Drawing.Size(1337, 993);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(307, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 34);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddDataItems
            // 
            this.btnAddDataItems.Location = new System.Drawing.Point(44, 26);
            this.btnAddDataItems.Name = "btnAddDataItems";
            this.btnAddDataItems.Size = new System.Drawing.Size(112, 34);
            this.btnAddDataItems.TabIndex = 0;
            this.btnAddDataItems.Text = "Add";
            this.btnAddDataItems.Click += new System.EventHandler(this.btnAddDataItems_Click);
            // 
            // gridContourItemsData
            // 
            this.gridContourItemsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContourItemsData.Location = new System.Drawing.Point(0, 0);
            this.gridContourItemsData.MainView = this.gridView;
            this.gridContourItemsData.Name = "gridContourItemsData";
            this.gridContourItemsData.Size = new System.Drawing.Size(1337, 907);
            this.gridContourItemsData.TabIndex = 1;
            this.gridContourItemsData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridContourItemsData;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // frmContourItemsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 993);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmContourItemsData.IconOptions.LargeImage")));
            this.Name = "frmContourItemsData";
            this.Text = "Danh Sách Contour Items";
            this.Load += new System.EventHandler(this.frmContourItemsData_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContourItemsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridContourItemsData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnAddDataItems;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}