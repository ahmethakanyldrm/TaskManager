
namespace TaskManager
{
    partial class FormGPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGPU));
            this.panelGraphic = new MetroFramework.Controls.MetroPanel();
            this.chartGPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetails = new MetroFramework.Controls.MetroPanel();
            this.lblFreeMemory2 = new System.Windows.Forms.Label();
            this.lblUsedMemory2 = new System.Windows.Forms.Label();
            this.lblTotalMemory2 = new System.Windows.Forms.Label();
            this.lblGPUName2 = new System.Windows.Forms.Label();
            this.chartT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblFreeMemory = new System.Windows.Forms.Label();
            this.lblUsedMemory = new System.Windows.Forms.Label();
            this.lblGPUName = new System.Windows.Forms.Label();
            this.lblTotalMemory = new System.Windows.Forms.Label();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.progressBarGPU = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGPU)).BeginInit();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraphic
            // 
            this.panelGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic.Controls.Add(this.chartGPU);
            this.panelGraphic.HorizontalScrollbarBarColor = true;
            this.panelGraphic.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGraphic.HorizontalScrollbarSize = 10;
            this.panelGraphic.Location = new System.Drawing.Point(20, 70);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(760, 283);
            this.panelGraphic.TabIndex = 4;
            this.panelGraphic.VerticalScrollbarBarColor = true;
            this.panelGraphic.VerticalScrollbarHighlightOnWheel = false;
            this.panelGraphic.VerticalScrollbarSize = 10;
            // 
            // chartGPU
            // 
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.Name = "ChartArea1";
            this.chartGPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGPU.Legends.Add(legend1);
            this.chartGPU.Location = new System.Drawing.Point(3, 3);
            this.chartGPU.Name = "chartGPU";
            this.chartGPU.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.Purple;
            series1.Legend = "Legend1";
            series1.Name = "GPU";
            this.chartGPU.Series.Add(series1);
            this.chartGPU.Size = new System.Drawing.Size(752, 275);
            this.chartGPU.TabIndex = 2;
            this.chartGPU.Text = "Kullanım Yüzdesi";
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "TitleMain";
            title1.Text = "GPU Kullanım Yüzdesi";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartGPU.Titles.Add(title1);
            // 
            // panelDetails
            // 
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.lblFreeMemory2);
            this.panelDetails.Controls.Add(this.lblUsedMemory2);
            this.panelDetails.Controls.Add(this.lblTotalMemory2);
            this.panelDetails.Controls.Add(this.lblGPUName2);
            this.panelDetails.Controls.Add(this.chartT);
            this.panelDetails.Controls.Add(this.lblFreeMemory);
            this.panelDetails.Controls.Add(this.lblUsedMemory);
            this.panelDetails.Controls.Add(this.lblGPUName);
            this.panelDetails.Controls.Add(this.lblTotalMemory);
            this.panelDetails.HorizontalScrollbarBarColor = true;
            this.panelDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDetails.HorizontalScrollbarSize = 10;
            this.panelDetails.Location = new System.Drawing.Point(20, 412);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(760, 175);
            this.panelDetails.TabIndex = 5;
            this.panelDetails.VerticalScrollbarBarColor = true;
            this.panelDetails.VerticalScrollbarHighlightOnWheel = false;
            this.panelDetails.VerticalScrollbarSize = 10;
            // 
            // lblFreeMemory2
            // 
            this.lblFreeMemory2.AutoSize = true;
            this.lblFreeMemory2.BackColor = System.Drawing.Color.Transparent;
            this.lblFreeMemory2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.lblFreeMemory2.Location = new System.Drawing.Point(89, 134);
            this.lblFreeMemory2.Name = "lblFreeMemory2";
            this.lblFreeMemory2.Size = new System.Drawing.Size(22, 23);
            this.lblFreeMemory2.TabIndex = 9;
            this.lblFreeMemory2.Text = "...";
            // 
            // lblUsedMemory2
            // 
            this.lblUsedMemory2.AutoSize = true;
            this.lblUsedMemory2.BackColor = System.Drawing.Color.Transparent;
            this.lblUsedMemory2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.lblUsedMemory2.Location = new System.Drawing.Point(130, 97);
            this.lblUsedMemory2.Name = "lblUsedMemory2";
            this.lblUsedMemory2.Size = new System.Drawing.Size(22, 23);
            this.lblUsedMemory2.TabIndex = 8;
            this.lblUsedMemory2.Text = "...";
            // 
            // lblTotalMemory2
            // 
            this.lblTotalMemory2.AutoSize = true;
            this.lblTotalMemory2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMemory2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.lblTotalMemory2.Location = new System.Drawing.Point(113, 56);
            this.lblTotalMemory2.Name = "lblTotalMemory2";
            this.lblTotalMemory2.Size = new System.Drawing.Size(22, 23);
            this.lblTotalMemory2.TabIndex = 7;
            this.lblTotalMemory2.Text = "...";
            // 
            // lblGPUName2
            // 
            this.lblGPUName2.AutoSize = true;
            this.lblGPUName2.BackColor = System.Drawing.Color.Transparent;
            this.lblGPUName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(196)))), ((int)(((byte)(195)))));
            this.lblGPUName2.Location = new System.Drawing.Point(123, 13);
            this.lblGPUName2.Name = "lblGPUName2";
            this.lblGPUName2.Size = new System.Drawing.Size(22, 23);
            this.lblGPUName2.TabIndex = 6;
            this.lblGPUName2.Text = "...";
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
            series2.Color = System.Drawing.Color.Red;
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Sıcaklık";
            this.chartT.Series.Add(series2);
            this.chartT.Size = new System.Drawing.Size(384, 167);
            this.chartT.TabIndex = 4;
            this.chartT.Text = "chartT";
            // 
            // lblFreeMemory
            // 
            this.lblFreeMemory.AutoSize = true;
            this.lblFreeMemory.Location = new System.Drawing.Point(7, 134);
            this.lblFreeMemory.Name = "lblFreeMemory";
            this.lblFreeMemory.Size = new System.Drawing.Size(92, 23);
            this.lblFreeMemory.TabIndex = 2;
            this.lblFreeMemory.Text = "Boş Bellek:";
            // 
            // lblUsedMemory
            // 
            this.lblUsedMemory.AutoSize = true;
            this.lblUsedMemory.Location = new System.Drawing.Point(7, 97);
            this.lblUsedMemory.Name = "lblUsedMemory";
            this.lblUsedMemory.Size = new System.Drawing.Size(139, 23);
            this.lblUsedMemory.TabIndex = 2;
            this.lblUsedMemory.Text = "Kullanılan Bellek:";
            // 
            // lblGPUName
            // 
            this.lblGPUName.AutoSize = true;
            this.lblGPUName.Location = new System.Drawing.Point(7, 13);
            this.lblGPUName.Name = "lblGPUName";
            this.lblGPUName.Size = new System.Drawing.Size(133, 23);
            this.lblGPUName.TabIndex = 2;
            this.lblGPUName.Text = "Ekran Kartı İsmi:";
            // 
            // lblTotalMemory
            // 
            this.lblTotalMemory.AutoSize = true;
            this.lblTotalMemory.Location = new System.Drawing.Point(7, 56);
            this.lblTotalMemory.Name = "lblTotalMemory";
            this.lblTotalMemory.Size = new System.Drawing.Size(120, 23);
            this.lblTotalMemory.TabIndex = 2;
            this.lblTotalMemory.Text = "Toplam Bellek:";
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
            this.btnBackToMainPage.TabIndex = 7;
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // progressBarGPU
            // 
            this.progressBarGPU.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.progressBarGPU.HideProgressText = false;
            this.progressBarGPU.Location = new System.Drawing.Point(28, 367);
            this.progressBarGPU.Name = "progressBarGPU";
            this.progressBarGPU.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBarGPU.Size = new System.Drawing.Size(745, 30);
            this.progressBarGPU.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressBarGPU.TabIndex = 6;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelGraphic);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.progressBarGPU);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGPU";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "GPU Details";
            this.Load += new System.EventHandler(this.FormGPU_Load);
            this.panelGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGPU)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelGraphic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGPU;
        private MetroFramework.Controls.MetroPanel panelDetails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartT;
        private System.Windows.Forms.Label lblUsedMemory;
        private System.Windows.Forms.Label lblGPUName;
        private System.Windows.Forms.Label lblTotalMemory;
        private System.Windows.Forms.Button btnBackToMainPage;
        private MetroFramework.Controls.MetroProgressBar progressBarGPU;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblFreeMemory;
        private System.Windows.Forms.Label lblFreeMemory2;
        private System.Windows.Forms.Label lblUsedMemory2;
        private System.Windows.Forms.Label lblTotalMemory2;
        private System.Windows.Forms.Label lblGPUName2;
    }
}