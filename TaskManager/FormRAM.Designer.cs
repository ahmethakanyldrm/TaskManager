
namespace TaskManager
{
    partial class FormRAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRAM));
            this.chartRAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetails = new MetroFramework.Controls.MetroPanel();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblUsed2 = new System.Windows.Forms.Label();
            this.lblAvailable2 = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblUsed = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panelGraphic = new MetroFramework.Controls.MetroPanel();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.progressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartRAM
            // 
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.Name = "ChartArea1";
            this.chartRAM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRAM.Legends.Add(legend1);
            this.chartRAM.Location = new System.Drawing.Point(3, 3);
            this.chartRAM.Name = "chartRAM";
            this.chartRAM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "RAM";
            this.chartRAM.Series.Add(series1);
            this.chartRAM.Size = new System.Drawing.Size(752, 275);
            this.chartRAM.TabIndex = 2;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "TitleMain";
            title1.Text = "RAM Kullanım Yüzdesi";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartRAM.Titles.Add(title1);
            // 
            // panelDetails
            // 
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.lblSpeed2);
            this.panelDetails.Controls.Add(this.lblUsed2);
            this.panelDetails.Controls.Add(this.lblAvailable2);
            this.panelDetails.Controls.Add(this.lblTotal2);
            this.panelDetails.Controls.Add(this.lblSpeed);
            this.panelDetails.Controls.Add(this.lblUsed);
            this.panelDetails.Controls.Add(this.lblAvailable);
            this.panelDetails.Controls.Add(this.lblTotal);
            this.panelDetails.HorizontalScrollbarBarColor = true;
            this.panelDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDetails.HorizontalScrollbarSize = 10;
            this.panelDetails.Location = new System.Drawing.Point(20, 412);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(760, 175);
            this.panelDetails.TabIndex = 4;
            this.panelDetails.VerticalScrollbarBarColor = true;
            this.panelDetails.VerticalScrollbarHighlightOnWheel = false;
            this.panelDetails.VerticalScrollbarSize = 10;
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed2.ForeColor = System.Drawing.Color.Black;
            this.lblSpeed2.Location = new System.Drawing.Point(39, 119);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(18, 19);
            this.lblSpeed2.TabIndex = 9;
            this.lblSpeed2.Text = "...";
            // 
            // lblUsed2
            // 
            this.lblUsed2.AutoSize = true;
            this.lblUsed2.BackColor = System.Drawing.Color.Transparent;
            this.lblUsed2.ForeColor = System.Drawing.Color.Black;
            this.lblUsed2.Location = new System.Drawing.Point(113, 85);
            this.lblUsed2.Name = "lblUsed2";
            this.lblUsed2.Size = new System.Drawing.Size(18, 19);
            this.lblUsed2.TabIndex = 8;
            this.lblUsed2.Text = "...";
            // 
            // lblAvailable2
            // 
            this.lblAvailable2.AutoSize = true;
            this.lblAvailable2.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailable2.ForeColor = System.Drawing.Color.Black;
            this.lblAvailable2.Location = new System.Drawing.Point(130, 49);
            this.lblAvailable2.Name = "lblAvailable2";
            this.lblAvailable2.Size = new System.Drawing.Size(18, 19);
            this.lblAvailable2.TabIndex = 7;
            this.lblAvailable2.Text = "...";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal2.ForeColor = System.Drawing.Color.Black;
            this.lblTotal2.Location = new System.Drawing.Point(100, 16);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(18, 19);
            this.lblTotal2.TabIndex = 6;
            this.lblTotal2.Text = "...";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.ForeColor = System.Drawing.Color.Gray;
            this.lblSpeed.Location = new System.Drawing.Point(0, 119);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(33, 19);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Hız:";
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.ForeColor = System.Drawing.Color.Gray;
            this.lblUsed.Location = new System.Drawing.Point(0, 85);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(107, 19);
            this.lblUsed.TabIndex = 2;
            this.lblUsed.Text = "Kullanılan Alan:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.ForeColor = System.Drawing.Color.Gray;
            this.lblAvailable.Location = new System.Drawing.Point(0, 49);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(124, 19);
            this.lblAvailable.TabIndex = 2;
            this.lblAvailable.Text = "Kullanılabilir Alan:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTotal.Location = new System.Drawing.Point(0, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Toplam Alan: ";
            // 
            // panelGraphic
            // 
            this.panelGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic.Controls.Add(this.chartRAM);
            this.panelGraphic.HorizontalScrollbarBarColor = true;
            this.panelGraphic.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGraphic.HorizontalScrollbarSize = 10;
            this.panelGraphic.Location = new System.Drawing.Point(20, 70);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(760, 283);
            this.panelGraphic.TabIndex = 5;
            this.panelGraphic.VerticalScrollbarBarColor = true;
            this.panelGraphic.VerticalScrollbarHighlightOnWheel = false;
            this.panelGraphic.VerticalScrollbarSize = 10;
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
            // progressBarRAM
            // 
            this.progressBarRAM.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.progressBarRAM.HideProgressText = false;
            this.progressBarRAM.Location = new System.Drawing.Point(28, 367);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBarRAM.Size = new System.Drawing.Size(745, 30);
            this.progressBarRAM.Style = MetroFramework.MetroColorStyle.Lime;
            this.progressBarRAM.TabIndex = 6;
            this.progressBarRAM.Value = 25;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormRAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelGraphic);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.progressBarRAM);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRAM";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "RAM Details";
            this.Load += new System.EventHandler(this.FormRAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartRAM)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelGraphic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRAM;
        private MetroFramework.Controls.MetroPanel panelDetails;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblTotal;
        private MetroFramework.Controls.MetroPanel panelGraphic;
        private System.Windows.Forms.Button btnBackToMainPage;
        private MetroFramework.Controls.MetroProgressBar progressBarRAM;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Label lblUsed2;
        private System.Windows.Forms.Label lblAvailable2;
        private System.Windows.Forms.Label lblTotal2;
    }
}