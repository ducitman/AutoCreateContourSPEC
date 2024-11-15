
namespace AutoCreateContourSPEC
{
    partial class Form2
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
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series13 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView13 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series14 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView14 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series15 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView15 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView15)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram5;
            this.chartControl1.Legend.LegendID = -1;
            this.chartControl1.Location = new System.Drawing.Point(1, -1);
            this.chartControl1.Name = "chartControl1";
            series13.Name = "Series 1";
            series13.SeriesID = 0;
            series13.View = lineSeriesView13;
            series14.Name = "Series 2";
            series14.SeriesID = 1;
            series14.View = lineSeriesView14;
            series15.Name = "Series 3";
            series15.SeriesID = 2;
            series15.View = lineSeriesView15;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series13,
        series14,
        series15};
            this.chartControl1.Size = new System.Drawing.Size(1290, 524);
            this.chartControl1.TabIndex = 0;
            // 
            // alertControl1
            // 
            this.alertControl1.AllowHotTrack = false;
            this.alertControl1.AppearanceCaption.BackColor = System.Drawing.Color.Black;
            this.alertControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.alertControl1.AppearanceCaption.Options.UseBackColor = true;
            this.alertControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.alertControl1.AppearanceCaption.Options.UseFont = true;
            this.alertControl1.AppearanceCaption.Options.UseForeColor = true;
            this.alertControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.alertControl1.AppearanceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertControl1.AppearanceText.Options.UseBackColor = true;
            this.alertControl1.AppearanceText.Options.UseBorderColor = true;
            this.alertControl1.AppearanceText.Options.UseFont = true;
            this.alertControl1.AppearanceText.Options.UseForeColor = true;
            this.alertControl1.AppearanceText.Options.UseTextOptions = true;
            this.alertControl1.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alertControl1.AppearanceText.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.alertControl1.AutoFormDelay = 5000;
            this.alertControl1.AutoHeight = true;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.FadeIn;
            this.alertControl1.ShowAnimationType = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alertControl1.ShowCloseButton = false;
            this.alertControl1.ShowPinButton = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(767, 597);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(238, 64);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(1111, 597);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(238, 64);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "NG";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 761);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.chartControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}