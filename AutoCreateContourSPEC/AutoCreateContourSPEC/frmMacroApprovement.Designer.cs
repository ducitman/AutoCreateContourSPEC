
namespace AutoCreateContourSPEC
{
    partial class frmMacroApprovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMacroApprovement));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnProcessMacro = new DevExpress.XtraEditors.SimpleButton();
            this.btnInput = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dataAccessDB1 = new AutoCreateContourSPEC.DataAccessDB();
            this.psrbfTableAdapter1 = new AutoCreateContourSPEC.DataAccessDBTableAdapters.PSRBFTableAdapter();
            this.psrbsideTableAdapter1 = new AutoCreateContourSPEC.DataAccessDBTableAdapters.PSRBSIDETableAdapter();
            this.psrtopTableAdapter1 = new AutoCreateContourSPEC.DataAccessDBTableAdapters.PSRTOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccessDB1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnProcessMacro);
            this.splitContainer1.Panel1.Controls.Add(this.btnInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1473, 879);
            this.splitContainer1.SplitterDistance = 81;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnProcessMacro
            // 
            this.btnProcessMacro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProcessMacro.ImageOptions.Image")));
            this.btnProcessMacro.Location = new System.Drawing.Point(1243, 8);
            this.btnProcessMacro.Name = "btnProcessMacro";
            this.btnProcessMacro.Size = new System.Drawing.Size(218, 66);
            this.btnProcessMacro.TabIndex = 0;
            this.btnProcessMacro.Text = "Process Macro";
            this.btnProcessMacro.Click += new System.EventHandler(this.btnProcessMacro_Click);
            this.btnProcessMacro.MouseLeave += new System.EventHandler(this.btnProcessMacro_MouseLeave);
            this.btnProcessMacro.MouseHover += new System.EventHandler(this.btnProcessMacro_MouseHover);
            // 
            // btnInput
            // 
            this.btnInput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.ImageOptions.Image")));
            this.btnInput.Location = new System.Drawing.Point(12, 8);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(218, 66);
            this.btnInput.TabIndex = 0;
            this.btnInput.Text = "Input";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            this.btnInput.MouseLeave += new System.EventHandler(this.btnInput_MouseLeave);
            this.btnInput.MouseHover += new System.EventHandler(this.btnInput_MouseHover);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1473, 794);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // dataAccessDB1
            // 
            this.dataAccessDB1.DataSetName = "DataAccessDB";
            this.dataAccessDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // frmMacroApprovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 879);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMacroApprovement";
            this.Text = "Phê Duyệt Tự Động cho Size Mass";
            this.Load += new System.EventHandler(this.frmMacroApprovement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccessDB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton btnInput;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnProcessMacro;
        private DataAccessDB dataAccessDB1;
        private DataAccessDBTableAdapters.PSRBFTableAdapter psrbfTableAdapter1;
        private DataAccessDBTableAdapters.PSRBSIDETableAdapter psrbsideTableAdapter1;
        private DataAccessDBTableAdapters.PSRTOPTableAdapter psrtopTableAdapter1;
    }
}