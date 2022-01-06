
namespace TaskManager
{
    partial class ProcessList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessList));
            this.gridProcesses = new MetroFramework.Controls.MetroGrid();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProcesses
            // 
            this.gridProcesses.AllowUserToAddRows = false;
            this.gridProcesses.AllowUserToDeleteRows = false;
            this.gridProcesses.AllowUserToResizeRows = false;
            this.gridProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProcesses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProcesses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProcesses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProcesses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProcesses.ColumnHeadersHeight = 38;
            this.gridProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProcesses.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProcesses.EnableHeadersVisualStyles = false;
            this.gridProcesses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProcesses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProcesses.Location = new System.Drawing.Point(25, 86);
            this.gridProcesses.MultiSelect = false;
            this.gridProcesses.Name = "gridProcesses";
            this.gridProcesses.ReadOnly = true;
            this.gridProcesses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProcesses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProcesses.RowHeadersWidth = 51;
            this.gridProcesses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProcesses.RowTemplate.Height = 24;
            this.gridProcesses.RowTemplate.ReadOnly = true;
            this.gridProcesses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProcesses.Size = new System.Drawing.Size(750, 485);
            this.gridProcesses.Style = MetroFramework.MetroColorStyle.Green;
            this.gridProcesses.TabIndex = 1;
            this.gridProcesses.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridProcesses_CellFormatting);
            this.gridProcesses.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProcesses_CellMouseDown);
            this.gridProcesses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gridProcesses_MouseClick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
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
            this.btnBackToMainPage.TabIndex = 8;
            this.btnBackToMainPage.UseVisualStyleBackColor = false;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // ProcessList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackToMainPage);
            this.Controls.Add(this.gridProcesses);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProcessList";
            this.Padding = new System.Windows.Forms.Padding(25, 86, 25, 29);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Process List";
            this.Load += new System.EventHandler(this.ProcessList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridProcesses;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnBackToMainPage;
    }
}