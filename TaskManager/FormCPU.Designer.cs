
using System.Drawing;

namespace TaskManager
{
    partial class FormCPU
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCPU));
            this.panelGraphic = new MetroFramework.Controls.MetroPanel();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetails = new MetroFramework.Controls.MetroPanel();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblThreadC2 = new System.Windows.Forms.Label();
            this.lblCoreC2 = new System.Windows.Forms.Label();
            this.lblCpuName2 = new System.Windows.Forms.Label();
            this.chartT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblThreadC = new System.Windows.Forms.Label();
            this.lblCoreC = new System.Windows.Forms.Label();
            this.lblCPUName = new System.Windows.Forms.Label();
            this.progressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraphic
            // 
            this.panelGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic.Controls.Add(this.chartCPU);
            this.panelGraphic.HorizontalScrollbarBarColor = true;
            this.panelGraphic.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGraphic.HorizontalScrollbarSize = 10;
            this.panelGraphic.Location = new System.Drawing.Point(20, 70);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(760, 283);
            this.panelGraphic.TabIndex = 0;
            this.panelGraphic.VerticalScrollbarBarColor = true;
            this.panelGraphic.VerticalScrollbarHighlightOnWheel = false;
            this.panelGraphic.VerticalScrollbarSize = 10;
            // 
            // chartCPU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(3, 3);
            this.chartCPU.Name = "chartCPU";
            this.chartCPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.chartCPU.Series.Add(series1);
            this.chartCPU.Size = new System.Drawing.Size(752, 275);
            this.chartCPU.TabIndex = 2;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "TitleMain";
            title1.Text = "CPU Kullanım Yüzdesi";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartCPU.Titles.Add(title1);
            // 
            // panelDetails
            // 
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.lblSpeed2);
            this.panelDetails.Controls.Add(this.lblThreadC2);
            this.panelDetails.Controls.Add(this.lblCoreC2);
            this.panelDetails.Controls.Add(this.lblCpuName2);
            this.panelDetails.Controls.Add(this.chartT);
            this.panelDetails.Controls.Add(this.lblSpeed);
            this.panelDetails.Controls.Add(this.lblThreadC);
            this.panelDetails.Controls.Add(this.lblCoreC);
            this.panelDetails.Controls.Add(this.lblCPUName);
            this.panelDetails.HorizontalScrollbarBarColor = true;
            this.panelDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDetails.HorizontalScrollbarSize = 10;
            this.panelDetails.Location = new System.Drawing.Point(20, 412);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(760, 167);
            this.panelDetails.TabIndex = 0;
            this.panelDetails.VerticalScrollbarBarColor = true;
            this.panelDetails.VerticalScrollbarHighlightOnWheel = false;
            this.panelDetails.VerticalScrollbarSize = 10;
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed2.ForeColor = System.Drawing.Color.Black;
            this.lblSpeed2.Location = new System.Drawing.Point(81, 121);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(21, 19);
            this.lblSpeed2.TabIndex = 8;
            this.lblSpeed2.Text = "...";
            // 
            // lblThreadC2
            // 
            this.lblThreadC2.AutoSize = true;
            this.lblThreadC2.BackColor = System.Drawing.Color.Transparent;
            this.lblThreadC2.ForeColor = System.Drawing.Color.Black;
            this.lblThreadC2.Location = new System.Drawing.Point(131, 87);
            this.lblThreadC2.Name = "lblThreadC2";
            this.lblThreadC2.Size = new System.Drawing.Size(21, 19);
            this.lblThreadC2.TabIndex = 7;
            this.lblThreadC2.Text = "...";
            // 
            // lblCoreC2
            // 
            this.lblCoreC2.AutoSize = true;
            this.lblCoreC2.BackColor = System.Drawing.Color.Transparent;
            this.lblCoreC2.ForeColor = System.Drawing.Color.Black;
            this.lblCoreC2.Location = new System.Drawing.Point(117, 53);
            this.lblCoreC2.Name = "lblCoreC2";
            this.lblCoreC2.Size = new System.Drawing.Size(21, 19);
            this.lblCoreC2.TabIndex = 6;
            this.lblCoreC2.Text = "...";
            // 
            // lblCpuName2
            // 
            this.lblCpuName2.AutoSize = true;
            this.lblCpuName2.BackColor = System.Drawing.Color.Transparent;
            this.lblCpuName2.ForeColor = System.Drawing.Color.Black;
            this.lblCpuName2.Location = new System.Drawing.Point(84, 19);
            this.lblCpuName2.Name = "lblCpuName2";
            this.lblCpuName2.Size = new System.Drawing.Size(21, 19);
            this.lblCpuName2.TabIndex = 5;
            this.lblCpuName2.Text = "...";
            // 
            // chartT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartT.Legends.Add(legend2);
            this.chartT.Location = new System.Drawing.Point(375, 3);
            this.chartT.Name = "chartT";
            this.chartT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Sıcaklık";
            this.chartT.Series.Add(series2);
            this.chartT.Size = new System.Drawing.Size(384, 167);
            this.chartT.TabIndex = 4;
            this.chartT.Text = "chartT";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSpeed.ForeColor = System.Drawing.Color.Gray;
            this.lblSpeed.Location = new System.Drawing.Point(-1, 121);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(79, 20);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Temel Hız:";
            // 
            // lblThreadC
            // 
            this.lblThreadC.AutoSize = true;
            this.lblThreadC.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThreadC.ForeColor = System.Drawing.Color.Gray;
            this.lblThreadC.Location = new System.Drawing.Point(-1, 87);
            this.lblThreadC.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreadC.Name = "lblThreadC";
            this.lblThreadC.Size = new System.Drawing.Size(129, 20);
            this.lblThreadC.TabIndex = 2;
            this.lblThreadC.Text = "Mantıksal İşlemci:";
            // 
            // lblCoreC
            // 
            this.lblCoreC.AutoSize = true;
            this.lblCoreC.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCoreC.ForeColor = System.Drawing.Color.Gray;
            this.lblCoreC.Location = new System.Drawing.Point(-1, 53);
            this.lblCoreC.Margin = new System.Windows.Forms.Padding(0);
            this.lblCoreC.Name = "lblCoreC";
            this.lblCoreC.Size = new System.Drawing.Size(115, 20);
            this.lblCoreC.TabIndex = 2;
            this.lblCoreC.Text = "Çekirdek Sayısı:";
            // 
            // lblCPUName
            // 
            this.lblCPUName.AutoSize = true;
            this.lblCPUName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCPUName.ForeColor = System.Drawing.Color.Gray;
            this.lblCPUName.Location = new System.Drawing.Point(-1, 18);
            this.lblCPUName.Margin = new System.Windows.Forms.Padding(0);
            this.lblCPUName.Name = "lblCPUName";
            this.lblCPUName.Size = new System.Drawing.Size(86, 20);
            this.lblCPUName.TabIndex = 2;
            this.lblCPUName.Text = "İşlemci Adı:";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.progressBarCPU.HideProgressText = false;
            this.progressBarCPU.Location = new System.Drawing.Point(28, 367);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBarCPU.Size = new System.Drawing.Size(745, 30);
            this.progressBarCPU.Style = MetroFramework.MetroColorStyle.Orange;
            this.progressBarCPU.TabIndex = 1;
            this.progressBarCPU.Value = 25;
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackToMainPage.BackgroundImage")));
            this.btnBackToMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackToMainPage.FlatAppearance.BorderSize = 0;
            this.btnBackToMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainPage.Location = new System.Drawing.Point(722, 14);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(50, 50);
            this.btnBackToMainPage.TabIndex = 3;
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormCPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelGraphic);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCPU";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "CPU Details";
            this.Load += new System.EventHandler(this.FormCPU_Load);
            this.panelGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGraphic;
        private MetroFramework.Controls.MetroPanel panelDetails;
        private MetroFramework.Controls.MetroProgressBar progressBarCPU;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblCPUName;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblThreadC;
        private System.Windows.Forms.Label lblCoreC;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartT;
        private System.Windows.Forms.Label lblCpuName2;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Label lblThreadC2;
        private System.Windows.Forms.Label lblCoreC2;
    }
}