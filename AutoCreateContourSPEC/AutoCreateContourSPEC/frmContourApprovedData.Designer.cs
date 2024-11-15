
namespace AutoCreateContourSPEC
{
    partial class frmSpecForContourResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecForContourResult));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridApprovedContourData = new DevExpress.XtraGrid.GridControl();
            this.gridViewApprovedData = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridApprovedContourData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovedData)).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridApprovedContourData);
            this.splitContainer1.Size = new System.Drawing.Size(1337, 851);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(173, 49);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridApprovedContourData
            // 
            this.gridApprovedContourData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridApprovedContourData.Location = new System.Drawing.Point(0, 0);
            this.gridApprovedContourData.MainView = this.gridViewApprovedData;
            this.gridApprovedContourData.Name = "gridApprovedContourData";
            this.gridApprovedContourData.Size = new System.Drawing.Size(1337, 770);
            this.gridApprovedContourData.TabIndex = 2;
            this.gridApprovedContourData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewApprovedData});
            // 
            // gridViewApprovedData
            // 
            this.gridViewApprovedData.GridControl = this.gridApprovedContourData;
            this.gridViewApprovedData.Name = "gridViewApprovedData";
            this.gridViewApprovedData.OptionsBehavior.ReadOnly = true;
            this.gridViewApprovedData.OptionsView.ShowAutoFilterRow = true;
            this.gridViewApprovedData.OptionsView.ShowGroupPanel = false;
            // 
            // frmSpecForContourResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 851);
            this.Controls.Add(this.splitContainer1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmSpecForContourResult.IconOptions.LargeImage")));
            this.Name = "frmSpecForContourResult";
            this.Text = "Dữ Liệu Contour cho Contour Result Online";
            this.Load += new System.EventHandler(this.frmSpecForContourResult_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridApprovedContourData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewApprovedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridApprovedContourData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewApprovedData;
    }
}