
namespace AutoCreateContourSPEC
{
    partial class frmAdd_EditDieNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_EditDieNo));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbTiretype = new System.Windows.Forms.ComboBox();
            this.cBDieStatus = new System.Windows.Forms.ComboBox();
            this.cbUsingMachine = new System.Windows.Forms.ComboBox();
            this.txtSizeName = new System.Windows.Forms.TextBox();
            this.txtDieNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.cbTiretype);
            this.splitContainer1.Panel1.Controls.Add(this.cBDieStatus);
            this.splitContainer1.Panel1.Controls.Add(this.cbUsingMachine);
            this.splitContainer1.Panel1.Controls.Add(this.txtSizeName);
            this.splitContainer1.Panel1.Controls.Add(this.txtDieNo);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnClose);
            this.splitContainer1.Panel2.Controls.Add(this.simpleButton1);
            this.splitContainer1.Size = new System.Drawing.Size(567, 657);
            this.splitContainer1.SplitterDistance = 575;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbTiretype
            // 
            this.cbTiretype.FormattingEnabled = true;
            this.cbTiretype.Items.AddRange(new object[] {
            "General",
            "Over V Rank"});
            this.cbTiretype.Location = new System.Drawing.Point(184, 271);
            this.cbTiretype.Name = "cbTiretype";
            this.cbTiretype.Size = new System.Drawing.Size(345, 27);
            this.cbTiretype.TabIndex = 2;
            // 
            // cBDieStatus
            // 
            this.cBDieStatus.FormattingEnabled = true;
            this.cBDieStatus.Items.AddRange(new object[] {
            "Active",
            "Stop"});
            this.cBDieStatus.Location = new System.Drawing.Point(184, 381);
            this.cBDieStatus.Name = "cBDieStatus";
            this.cBDieStatus.Size = new System.Drawing.Size(345, 27);
            this.cBDieStatus.TabIndex = 2;
            // 
            // cbUsingMachine
            // 
            this.cbUsingMachine.FormattingEnabled = true;
            this.cbUsingMachine.Items.AddRange(new object[] {
            "MAT",
            "K1S"});
            this.cbUsingMachine.Location = new System.Drawing.Point(184, 491);
            this.cbUsingMachine.Name = "cbUsingMachine";
            this.cbUsingMachine.Size = new System.Drawing.Size(345, 27);
            this.cbUsingMachine.TabIndex = 2;
            // 
            // txtSizeName
            // 
            this.txtSizeName.Location = new System.Drawing.Point(121, 161);
            this.txtSizeName.Name = "txtSizeName";
            this.txtSizeName.Size = new System.Drawing.Size(408, 27);
            this.txtSizeName.TabIndex = 1;
            // 
            // txtDieNo
            // 
            this.txtDieNo.Location = new System.Drawing.Point(121, 51);
            this.txtDieNo.Name = "txtDieNo";
            this.txtDieNo.Size = new System.Drawing.Size(408, 27);
            this.txtDieNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sử dụng cho máy: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái Die:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại lốp sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Die:";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Location = new System.Drawing.Point(364, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(165, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(32, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(165, 52);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmAdd_EditDieNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 657);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmAdd_EditDieNo.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.Name = "frmAdd_EditDieNo";
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frmAdd_EditDieNo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbTiretype;
        private System.Windows.Forms.ComboBox cBDieStatus;
        private System.Windows.Forms.ComboBox cbUsingMachine;
        private System.Windows.Forms.TextBox txtSizeName;
        private System.Windows.Forms.TextBox txtDieNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}