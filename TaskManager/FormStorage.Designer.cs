
namespace TaskManager
{
    partial class FormStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStorage));
            this.chartStorage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelDetails = new MetroFramework.Controls.MetroPanel();
            this.lblDiscName = new System.Windows.Forms.Label();
            this.lblUsedSize = new System.Windows.Forms.Label();
            this.lblFreeSize = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.panelGraphic = new MetroFramework.Controls.MetroPanel();
            this.comboBoxDrivers = new MetroFramework.Controls.MetroComboBox();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.progressBarStorage = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblDiscName2 = new System.Windows.Forms.Label();
            this.lblTotalSize2 = new System.Windows.Forms.Label();
            this.lblUsedSize2 = new System.Windows.Forms.Label();
            this.lblFreeSize2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStorage)).BeginInit();
            this.panelDetails.SuspendLayout();
            this.panelGraphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartStorage
            // 
            this.chartStorage.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.None;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.Name = "ChartArea1";
            this.chartStorage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStorage.Legends.Add(legend1);
            this.chartStorage.Location = new System.Drawing.Point(3, 3);
            this.chartStorage.Name = "chartStorage";
            this.chartStorage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Used Area";
            series1.YValuesPerPoint = 2;
            this.chartStorage.Series.Add(series1);
            this.chartStorage.Size = new System.Drawing.Size(752, 275);
            this.chartStorage.TabIndex = 2;
            title1.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            title1.Name = "ChartTitle";
            title1.Text = "Kullanılan Alan Grafiği (GB)";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartStorage.Titles.Add(title1);
            // 
            // panelDetails
            // 
            this.panelDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetails.Controls.Add(this.lblFreeSize2);
            this.panelDetails.Controls.Add(this.lblUsedSize2);
            this.panelDetails.Controls.Add(this.lblTotalSize2);
            this.panelDetails.Controls.Add(this.lblDiscName2);
            this.panelDetails.Controls.Add(this.lblDiscName);
            this.panelDetails.Controls.Add(this.lblUsedSize);
            this.panelDetails.Controls.Add(this.lblFreeSize);
            this.panelDetails.Controls.Add(this.lblTotalSize);
            this.panelDetails.HorizontalScrollbarBarColor = true;
            this.panelDetails.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDetails.HorizontalScrollbarSize = 10;
            this.panelDetails.Location = new System.Drawing.Point(20, 412);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(760, 175);
            this.panelDetails.TabIndex = 8;
            this.panelDetails.VerticalScrollbarBarColor = true;
            this.panelDetails.VerticalScrollbarHighlightOnWheel = false;
            this.panelDetails.VerticalScrollbarSize = 10;
            // 
            // lblDiscName
            // 
            this.lblDiscName.AutoSize = true;
            this.lblDiscName.ForeColor = System.Drawing.Color.Gray;
            this.lblDiscName.Location = new System.Drawing.Point(0, 12);
            this.lblDiscName.Name = "lblDiscName";
            this.lblDiscName.Size = new System.Drawing.Size(64, 19);
            this.lblDiscName.TabIndex = 2;
            this.lblDiscName.Text = "Disk Adı:";
            // 
            // lblUsedSize
            // 
            this.lblUsedSize.AutoSize = true;
            this.lblUsedSize.ForeColor = System.Drawing.Color.Gray;
            this.lblUsedSize.Location = new System.Drawing.Point(0, 70);
            this.lblUsedSize.Name = "lblUsedSize";
            this.lblUsedSize.Size = new System.Drawing.Size(138, 19);
            this.lblUsedSize.TabIndex = 2;
            this.lblUsedSize.Text = "Disk Kullanılan Alan:";
            // 
            // lblFreeSize
            // 
            this.lblFreeSize.AutoSize = true;
            this.lblFreeSize.ForeColor = System.Drawing.Color.Gray;
            this.lblFreeSize.Location = new System.Drawing.Point(0, 101);
            this.lblFreeSize.Name = "lblFreeSize";
            this.lblFreeSize.Size = new System.Drawing.Size(97, 19);
            this.lblFreeSize.TabIndex = 2;
            this.lblFreeSize.Text = "Disk Boş Alan:";
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSize.Location = new System.Drawing.Point(0, 41);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(125, 19);
            this.lblTotalSize.TabIndex = 2;
            this.lblTotalSize.Text = "Disk Toplam Alan: ";
            // 
            // panelGraphic
            // 
            this.panelGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphic.Controls.Add(this.comboBoxDrivers);
            this.panelGraphic.Controls.Add(this.chartStorage);
            this.panelGraphic.HorizontalScrollbarBarColor = true;
            this.panelGraphic.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGraphic.HorizontalScrollbarSize = 10;
            this.panelGraphic.Location = new System.Drawing.Point(20, 70);
            this.panelGraphic.Name = "panelGraphic";
            this.panelGraphic.Size = new System.Drawing.Size(760, 283);
            this.panelGraphic.TabIndex = 9;
            this.panelGraphic.VerticalScrollbarBarColor = true;
            this.panelGraphic.VerticalScrollbarHighlightOnWheel = false;
            this.panelGraphic.VerticalScrollbarSize = 10;
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxDrivers.ItemHeight = 23;
            this.comboBoxDrivers.Location = new System.Drawing.Point(619, 74);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(132, 29);
            this.comboBoxDrivers.TabIndex = 12;
            this.comboBoxDrivers.UseSelectable = true;
            this.comboBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrivers_SelectedIndexChanged);
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
            this.btnBackToMainPage.TabIndex = 11;
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // progressBarStorage
            // 
            this.progressBarStorage.FontWeight = MetroFramework.MetroProgressBarWeight.Bold;
            this.progressBarStorage.HideProgressText = false;
            this.progressBarStorage.Location = new System.Drawing.Point(28, 367);
            this.progressBarStorage.Name = "progressBarStorage";
            this.progressBarStorage.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.progressBarStorage.Size = new System.Drawing.Size(745, 30);
            this.progressBarStorage.Style = MetroFramework.MetroColorStyle.Red;
            this.progressBarStorage.TabIndex = 10;
            this.progressBarStorage.Value = 25;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblDiscName2
            // 
            this.lblDiscName2.AutoSize = true;
            this.lblDiscName2.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscName2.ForeColor = System.Drawing.Color.Black;
            this.lblDiscName2.Location = new System.Drawing.Point(70, 12);
            this.lblDiscName2.Name = "lblDiscName2";
            this.lblDiscName2.Size = new System.Drawing.Size(18, 19);
            this.lblDiscName2.TabIndex = 7;
            this.lblDiscName2.Text = "...";
            // 
            // lblTotalSize2
            // 
            this.lblTotalSize2.AutoSize = true;
            this.lblTotalSize2.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSize2.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSize2.Location = new System.Drawing.Point(131, 41);
            this.lblTotalSize2.Name = "lblTotalSize2";
            this.lblTotalSize2.Size = new System.Drawing.Size(18, 19);
            this.lblTotalSize2.TabIndex = 8;
            this.lblTotalSize2.Text = "...";
            // 
            // lblUsedSize2
            // 
            this.lblUsedSize2.AutoSize = true;
            this.lblUsedSize2.BackColor = System.Drawing.Color.Transparent;
            this.lblUsedSize2.ForeColor = System.Drawing.Color.Black;
            this.lblUsedSize2.Location = new System.Drawing.Point(144, 70);
            this.lblUsedSize2.Name = "lblUsedSize2";
            this.lblUsedSize2.Size = new System.Drawing.Size(18, 19);
            this.lblUsedSize2.TabIndex = 9;
            this.lblUsedSize2.Text = "...";
            // 
            // lblFreeSize2
            // 
            this.lblFreeSize2.AutoSize = true;
            this.lblFreeSize2.BackColor = System.Drawing.Color.Transparent;
            this.lblFreeSize2.ForeColor = System.Drawing.Color.Black;
            this.lblFreeSize2.Location = new System.Drawing.Point(103, 101);
            this.lblFreeSize2.Name = "lblFreeSize2";
            this.lblFreeSize2.Size = new System.Drawing.Size(18, 19);
            this.lblFreeSize2.TabIndex = 10;
            this.lblFreeSize2.Text = "...";
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelGraphic);
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.progressBarStorage);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStorage";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Storage Details";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartStorage)).EndInit();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelGraphic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStorage;
        private MetroFramework.Controls.MetroPanel panelDetails;
        private System.Windows.Forms.Label lblDiscName;
        private System.Windows.Forms.Label lblUsedSize;
        private System.Windows.Forms.Label lblFreeSize;
        private System.Windows.Forms.Label lblTotalSize;
        private MetroFramework.Controls.MetroPanel panelGraphic;
        private System.Windows.Forms.Button btnBackToMainPage;
        private MetroFramework.Controls.MetroProgressBar progressBarStorage;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroComboBox comboBoxDrivers;
        private System.Windows.Forms.Label lblFreeSize2;
        private System.Windows.Forms.Label lblUsedSize2;
        private System.Windows.Forms.Label lblTotalSize2;
        private System.Windows.Forms.Label lblDiscName2;
    }
}