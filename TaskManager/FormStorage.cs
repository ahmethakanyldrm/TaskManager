using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace TaskManager
{
    public partial class FormStorage : MetroFramework.Forms.MetroForm
    {
        private string selectedDisk { get; set; }
        public FormStorage()
        {
            InitializeComponent();
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {
            timer.Start();
            GetDrivers();
            comboBoxDrivers.SelectedIndex = 0;
            selectedDisk = (string)comboBoxDrivers.SelectedItem;
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            double availableFreeSpace = 0, totalSize = 0;
            string diskName = null; 

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo driver in allDrives)
            {
                if($@"{driver.Name}" == $@"{selectedDisk}")
                {
                    availableFreeSpace = driver.AvailableFreeSpace;
                    totalSize = driver.TotalSize;
                    diskName = driver.Name;
                }
            }

            double usedSize = (totalSize - availableFreeSpace)/Math.Pow(1024,3);

            chartStorage.Series["Used Area"].Points.AddY(usedSize);

            double totalSizeGB = totalSize / Math.Pow(1024, 3);
            double Ratio = usedSize / totalSizeGB * 100;
            progressBarStorage.Value = (int) Ratio;

            lblUsedSize2.Text = $"{String.Format("{0:0.00}", usedSize)}";
            lblFreeSize2.Text = $"{String.Format("{0:0.00}", (availableFreeSpace / Math.Pow(1024, 3)))}";
            lblTotalSize2.Text = $"{String.Format("{0:0.00}", totalSizeGB)}";
            lblDiscName2.Text = $"{diskName.Substring(0,1)} Diski";

        }

        private void comboBoxDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartStorage.Series["Used Area"].Points.Clear();
            selectedDisk = (string)comboBoxDrivers.SelectedItem;
        }

        private void GetDrivers()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo driver in allDrives)
            {
                comboBoxDrivers.Items.Add(driver.Name);
                
            }
        }
    }
}
