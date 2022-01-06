
namespace TaskManager
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panelCPU = new MetroFramework.Controls.MetroPanel();
            this.lblCPUStatus = new MetroFramework.Controls.MetroLabel();
            this.progressBarCPU = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.panelStorage = new MetroFramework.Controls.MetroPanel();
            this.comboBoxDrivers = new MetroFramework.Controls.MetroComboBox();
            this.lblStorageStatus = new MetroFramework.Controls.MetroLabel();
            this.progressBarStorage = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblStorage = new MetroFramework.Controls.MetroLabel();
            this.panelGPU = new MetroFramework.Controls.MetroPanel();
            this.lblGPUStatus = new MetroFramework.Controls.MetroLabel();
            this.progressBarGPU = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblGPU = new MetroFramework.Controls.MetroLabel();
            this.panelRAM = new MetroFramework.Controls.MetroPanel();
            this.lblRAMStatus = new MetroFramework.Controls.MetroLabel();
            this.progressBarRAM = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_Loader = new System.Windows.Forms.Timer(this.components);
            this.timer_unloader = new System.Windows.Forms.Timer(this.components);
            this.btnExitApplication = new System.Windows.Forms.PictureBox();
            this.pctrProcessListLine = new System.Windows.Forms.PictureBox();
            this.btnProcess = new System.Windows.Forms.PictureBox();
            this.pctrRefresfLine = new System.Windows.Forms.PictureBox();
            this.pctRefresh = new System.Windows.Forms.PictureBox();
            this.progressBarBattery = new MetroFramework.Controls.MetroProgressSpinner();
            this.pctBatteryEnergy = new System.Windows.Forms.PictureBox();
            this.lblBatteryLevel = new System.Windows.Forms.Label();
            this.panelCPU.SuspendLayout();
            this.panelStorage.SuspendLayout();
            this.panelGPU.SuspendLayout();
            this.panelRAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrProcessListLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRefresfLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBatteryEnergy)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCPU
            // 
            this.panelCPU.BackColor = System.Drawing.Color.White;
            this.panelCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCPU.Controls.Add(this.lblCPUStatus);
            this.panelCPU.Controls.Add(this.progressBarCPU);
            this.panelCPU.Controls.Add(this.lblCPU);
            this.panelCPU.HorizontalScrollbarBarColor = true;
            this.panelCPU.HorizontalScrollbarHighlightOnWheel = false;
            this.panelCPU.HorizontalScrollbarSize = 10;
            this.panelCPU.Location = new System.Drawing.Point(28, 89);
            this.panelCPU.Name = "panelCPU";
            this.panelCPU.Size = new System.Drawing.Size(400, 200);
            this.panelCPU.TabIndex = 0;
            this.panelCPU.VerticalScrollbarBarColor = true;
            this.panelCPU.VerticalScrollbarHighlightOnWheel = false;
            this.panelCPU.VerticalScrollbarSize = 10;
            this.panelCPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCPU_MouseDown);
            // 
            // lblCPUStatus
            // 
            this.lblCPUStatus.AutoSize = true;
            this.lblCPUStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCPUStatus.Location = new System.Drawing.Point(165, 163);
            this.lblCPUStatus.Name = "lblCPUStatus";
            this.lblCPUStatus.Size = new System.Drawing.Size(62, 20);
            this.lblCPUStatus.TabIndex = 4;
            this.lblCPUStatus.Text = "%00.00";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.BackColor = System.Drawing.Color.Black;
            this.progressBarCPU.Location = new System.Drawing.Point(148, 57);
            this.progressBarCPU.Maximum = 100;
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(100, 100);
            this.progressBarCPU.Spinning = false;
            this.progressBarCPU.Style = MetroFramework.MetroColorStyle.Orange;
            this.progressBarCPU.TabIndex = 3;
            this.progressBarCPU.UseSelectable = true;
            this.progressBarCPU.Value = 5;
            // 
            // lblCPU
            // 
            this.lblCPU.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCPU.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCPU.Location = new System.Drawing.Point(-1, 0);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(400, 25);
            this.lblCPU.TabIndex = 2;
            this.lblCPU.Text = "CPU";
            this.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelStorage
            // 
            this.panelStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStorage.Controls.Add(this.comboBoxDrivers);
            this.panelStorage.Controls.Add(this.lblStorageStatus);
            this.panelStorage.Controls.Add(this.progressBarStorage);
            this.panelStorage.Controls.Add(this.lblStorage);
            this.panelStorage.HorizontalScrollbarBarColor = true;
            this.panelStorage.HorizontalScrollbarHighlightOnWheel = false;
            this.panelStorage.HorizontalScrollbarSize = 10;
            this.panelStorage.Location = new System.Drawing.Point(472, 317);
            this.panelStorage.Name = "panelStorage";
            this.panelStorage.Size = new System.Drawing.Size(400, 200);
            this.panelStorage.TabIndex = 0;
            this.panelStorage.VerticalScrollbarBarColor = true;
            this.panelStorage.VerticalScrollbarHighlightOnWheel = false;
            this.panelStorage.VerticalScrollbarSize = 10;
            this.panelStorage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelStorage_MouseDown);
            // 
            // comboBoxDrivers
            // 
            this.comboBoxDrivers.BackColor = System.Drawing.Color.White;
            this.comboBoxDrivers.FormattingEnabled = true;
            this.comboBoxDrivers.ItemHeight = 24;
            this.comboBoxDrivers.Location = new System.Drawing.Point(274, 3);
            this.comboBoxDrivers.Name = "comboBoxDrivers";
            this.comboBoxDrivers.Size = new System.Drawing.Size(121, 30);
            this.comboBoxDrivers.Style = MetroFramework.MetroColorStyle.Silver;
            this.comboBoxDrivers.TabIndex = 5;
            this.comboBoxDrivers.UseSelectable = true;
            // 
            // lblStorageStatus
            // 
            this.lblStorageStatus.AutoSize = true;
            this.lblStorageStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStorageStatus.Location = new System.Drawing.Point(169, 166);
            this.lblStorageStatus.Name = "lblStorageStatus";
            this.lblStorageStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStorageStatus.TabIndex = 4;
            this.lblStorageStatus.Text = "%00.00";
            // 
            // progressBarStorage
            // 
            this.progressBarStorage.BackColor = System.Drawing.Color.Black;
            this.progressBarStorage.EnsureVisible = false;
            this.progressBarStorage.Location = new System.Drawing.Point(154, 63);
            this.progressBarStorage.Maximum = 100;
            this.progressBarStorage.Name = "progressBarStorage";
            this.progressBarStorage.Size = new System.Drawing.Size(100, 100);
            this.progressBarStorage.Spinning = false;
            this.progressBarStorage.Style = MetroFramework.MetroColorStyle.Red;
            this.progressBarStorage.TabIndex = 3;
            this.progressBarStorage.UseSelectable = true;
            this.progressBarStorage.Value = 50;
            // 
            // lblStorage
            // 
            this.lblStorage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblStorage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblStorage.Location = new System.Drawing.Point(-1, 0);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(400, 25);
            this.lblStorage.TabIndex = 2;
            this.lblStorage.Text = "Hafıza";
            this.lblStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGPU
            // 
            this.panelGPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGPU.Controls.Add(this.lblGPUStatus);
            this.panelGPU.Controls.Add(this.progressBarGPU);
            this.panelGPU.Controls.Add(this.lblGPU);
            this.panelGPU.HorizontalScrollbarBarColor = true;
            this.panelGPU.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGPU.HorizontalScrollbarSize = 10;
            this.panelGPU.Location = new System.Drawing.Point(28, 317);
            this.panelGPU.Name = "panelGPU";
            this.panelGPU.Size = new System.Drawing.Size(400, 200);
            this.panelGPU.TabIndex = 0;
            this.panelGPU.VerticalScrollbarBarColor = true;
            this.panelGPU.VerticalScrollbarHighlightOnWheel = false;
            this.panelGPU.VerticalScrollbarSize = 10;
            this.panelGPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGPU_MouseDown);
            // 
            // lblGPUStatus
            // 
            this.lblGPUStatus.AutoSize = true;
            this.lblGPUStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGPUStatus.Location = new System.Drawing.Point(165, 166);
            this.lblGPUStatus.Name = "lblGPUStatus";
            this.lblGPUStatus.Size = new System.Drawing.Size(62, 20);
            this.lblGPUStatus.TabIndex = 4;
            this.lblGPUStatus.Text = "%00.00";
            // 
            // progressBarGPU
            // 
            this.progressBarGPU.BackColor = System.Drawing.Color.Black;
            this.progressBarGPU.Location = new System.Drawing.Point(148, 63);
            this.progressBarGPU.Maximum = 100;
            this.progressBarGPU.Name = "progressBarGPU";
            this.progressBarGPU.Size = new System.Drawing.Size(100, 100);
            this.progressBarGPU.Spinning = false;
            this.progressBarGPU.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressBarGPU.TabIndex = 3;
            this.progressBarGPU.UseSelectable = true;
            this.progressBarGPU.Value = 5;
            // 
            // lblGPU
            // 
            this.lblGPU.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGPU.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblGPU.Location = new System.Drawing.Point(-1, -1);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(400, 25);
            this.lblGPU.TabIndex = 2;
            this.lblGPU.Text = "GPU";
            this.lblGPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRAM
            // 
            this.panelRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRAM.Controls.Add(this.lblRAMStatus);
            this.panelRAM.Controls.Add(this.progressBarRAM);
            this.panelRAM.Controls.Add(this.lblRAM);
            this.panelRAM.HorizontalScrollbarBarColor = true;
            this.panelRAM.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRAM.HorizontalScrollbarSize = 10;
            this.panelRAM.Location = new System.Drawing.Point(472, 89);
            this.panelRAM.Name = "panelRAM";
            this.panelRAM.Size = new System.Drawing.Size(400, 200);
            this.panelRAM.TabIndex = 0;
            this.panelRAM.VerticalScrollbarBarColor = true;
            this.panelRAM.VerticalScrollbarHighlightOnWheel = false;
            this.panelRAM.VerticalScrollbarSize = 10;
            this.panelRAM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRAM_MouseDown);
            // 
            // lblRAMStatus
            // 
            this.lblRAMStatus.AutoSize = true;
            this.lblRAMStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRAMStatus.Location = new System.Drawing.Point(169, 163);
            this.lblRAMStatus.Name = "lblRAMStatus";
            this.lblRAMStatus.Size = new System.Drawing.Size(62, 20);
            this.lblRAMStatus.TabIndex = 4;
            this.lblRAMStatus.Text = "%00.00";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.BackColor = System.Drawing.Color.Black;
            this.progressBarRAM.EnsureVisible = false;
            this.progressBarRAM.Location = new System.Drawing.Point(154, 57);
            this.progressBarRAM.Maximum = 100;
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(100, 100);
            this.progressBarRAM.Spinning = false;
            this.progressBarRAM.Style = MetroFramework.MetroColorStyle.Lime;
            this.progressBarRAM.TabIndex = 3;
            this.progressBarRAM.UseSelectable = true;
            this.progressBarRAM.Value = 50;
            // 
            // lblRAM
            // 
            this.lblRAM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRAM.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRAM.Location = new System.Drawing.Point(-1, 0);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(400, 25);
            this.lblRAM.TabIndex = 2;
            this.lblRAM.Text = "RAM";
            this.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_Loader
            // 
            this.timer_Loader.Tick += new System.EventHandler(this.timer_Loader_Tick);
            // 
            // timer_unloader
            // 
            this.timer_unloader.Tick += new System.EventHandler(this.timer_unloader_Tick);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitApplication.BackgroundImage")));
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.Location = new System.Drawing.Point(807, 16);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(65, 67);
            this.btnExitApplication.TabIndex = 4;
            this.btnExitApplication.TabStop = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // pctrProcessListLine
            // 
            this.pctrProcessListLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctrProcessListLine.BackgroundImage")));
            this.pctrProcessListLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrProcessListLine.Location = new System.Drawing.Point(180, 561);
            this.pctrProcessListLine.Name = "pctrProcessListLine";
            this.pctrProcessListLine.Size = new System.Drawing.Size(100, 72);
            this.pctrProcessListLine.TabIndex = 7;
            this.pctrProcessListLine.TabStop = false;
            this.pctrProcessListLine.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnProcess.Image")));
            this.btnProcess.Location = new System.Drawing.Point(194, 523);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(67, 71);
            this.btnProcess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnProcess.TabIndex = 8;
            this.btnProcess.TabStop = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            this.btnProcess.MouseLeave += new System.EventHandler(this.btnProcess_MouseLeave);
            this.btnProcess.MouseHover += new System.EventHandler(this.btnProcess_MouseHover);
            // 
            // pctrRefresfLine
            // 
            this.pctrRefresfLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctrRefresfLine.BackgroundImage")));
            this.pctrRefresfLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrRefresfLine.Location = new System.Drawing.Point(636, 562);
            this.pctrRefresfLine.Name = "pctrRefresfLine";
            this.pctrRefresfLine.Size = new System.Drawing.Size(100, 72);
            this.pctrRefresfLine.TabIndex = 9;
            this.pctrRefresfLine.TabStop = false;
            this.pctrRefresfLine.Visible = false;
            // 
            // pctRefresh
            // 
            this.pctRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctRefresh.BackgroundImage")));
            this.pctRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRefresh.Location = new System.Drawing.Point(651, 522);
            this.pctRefresh.Name = "pctRefresh";
            this.pctRefresh.Size = new System.Drawing.Size(67, 71);
            this.pctRefresh.TabIndex = 10;
            this.pctRefresh.TabStop = false;
            this.pctRefresh.Click += new System.EventHandler(this.pctRefresh_Click);
            this.pctRefresh.MouseLeave += new System.EventHandler(this.pctRefresh_MouseLeave);
            this.pctRefresh.MouseHover += new System.EventHandler(this.pctRefresh_MouseHover);
            // 
            // progressBarBattery
            // 
            this.progressBarBattery.BackColor = System.Drawing.Color.Black;
            this.progressBarBattery.EnsureVisible = false;
            this.progressBarBattery.Location = new System.Drawing.Point(416, 524);
            this.progressBarBattery.Maximum = 100;
            this.progressBarBattery.Name = "progressBarBattery";
            this.progressBarBattery.Size = new System.Drawing.Size(71, 70);
            this.progressBarBattery.Spinning = false;
            this.progressBarBattery.Style = MetroFramework.MetroColorStyle.Teal;
            this.progressBarBattery.TabIndex = 6;
            this.progressBarBattery.UseSelectable = true;
            this.progressBarBattery.Value = 100;
            // 
            // pctBatteryEnergy
            // 
            this.pctBatteryEnergy.Image = ((System.Drawing.Image)(resources.GetObject("pctBatteryEnergy.Image")));
            this.pctBatteryEnergy.Location = new System.Drawing.Point(442, 545);
            this.pctBatteryEnergy.Name = "pctBatteryEnergy";
            this.pctBatteryEnergy.Size = new System.Drawing.Size(20, 30);
            this.pctBatteryEnergy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBatteryEnergy.TabIndex = 18;
            this.pctBatteryEnergy.TabStop = false;
            this.pctBatteryEnergy.Visible = false;
            // 
            // lblBatteryLevel
            // 
            this.lblBatteryLevel.AutoSize = true;
            this.lblBatteryLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblBatteryLevel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryLevel.Location = new System.Drawing.Point(434, 551);
            this.lblBatteryLevel.Name = "lblBatteryLevel";
            this.lblBatteryLevel.Size = new System.Drawing.Size(0, 17);
            this.lblBatteryLevel.TabIndex = 19;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 613);
            this.ControlBox = false;
            this.Controls.Add(this.lblBatteryLevel);
            this.Controls.Add(this.pctBatteryEnergy);
            this.Controls.Add(this.progressBarBattery);
            this.Controls.Add(this.pctRefresh);
            this.Controls.Add(this.pctrRefresfLine);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.pctrProcessListLine);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.panelRAM);
            this.Controls.Add(this.panelGPU);
            this.Controls.Add(this.panelStorage);
            this.Controls.Add(this.panelCPU);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.Padding = new System.Windows.Forms.Padding(25, 60, 25, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "TASK MANAGER";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panelCPU.ResumeLayout(false);
            this.panelCPU.PerformLayout();
            this.panelStorage.ResumeLayout(false);
            this.panelStorage.PerformLayout();
            this.panelGPU.ResumeLayout(false);
            this.panelGPU.PerformLayout();
            this.panelRAM.ResumeLayout(false);
            this.panelRAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrProcessListLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRefresfLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBatteryEnergy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelCPU;
        private MetroFramework.Controls.MetroPanel panelStorage;
        private MetroFramework.Controls.MetroPanel panelGPU;
        private MetroFramework.Controls.MetroPanel panelRAM;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel lblStorage;
        private MetroFramework.Controls.MetroLabel lblGPU;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroProgressSpinner progressBarCPU;
        private MetroFramework.Controls.MetroProgressSpinner progressBarStorage;
        private MetroFramework.Controls.MetroProgressSpinner progressBarGPU;
        private MetroFramework.Controls.MetroProgressSpinner progressBarRAM;
        private MetroFramework.Controls.MetroLabel lblCPUStatus;
        private MetroFramework.Controls.MetroLabel lblRAMStatus;
        private MetroFramework.Controls.MetroLabel lblStorageStatus;
        private MetroFramework.Controls.MetroLabel lblGPUStatus;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroComboBox comboBoxDrivers;
        private System.Windows.Forms.Timer timer_Loader;
        private System.Windows.Forms.Timer timer_unloader;
        private System.Windows.Forms.PictureBox btnExitApplication;
        private System.Windows.Forms.PictureBox pctrProcessListLine;
        private System.Windows.Forms.PictureBox btnProcess;
        private System.Windows.Forms.PictureBox pctrRefresfLine;
        private System.Windows.Forms.PictureBox pctRefresh;
        private MetroFramework.Controls.MetroProgressSpinner progressBarBattery;
        private System.Windows.Forms.PictureBox pctBatteryEnergy;
        private System.Windows.Forms.Label lblBatteryLevel;
    }
}

