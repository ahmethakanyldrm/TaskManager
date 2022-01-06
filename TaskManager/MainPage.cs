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
using OpenHardwareMonitor.Hardware;

namespace TaskManager
{
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        Computer computer = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true}; 
        public MainPage()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------
        private void MainPage_Load(object sender, EventArgs e)
        {
            if (!Program.isOpen)
            {
                timer_Loader.Start();
                timer_Loader.Interval = 1;
                timer_unloader.Interval = 1;
                progressBarBattery.Value = 0;
                Program.isOpen = true;
            }
            else
            {
                timer.Start();
                timer_Loader.Stop();
                timer_unloader.Stop();
            }
           
            computer.Open();
            GetDrivers();
            comboBoxDrivers.SelectedIndex = 0;
        }

        private void panelCPU_MouseDown(object sender, MouseEventArgs e)
        {
            FormCPU formCPU = new FormCPU();
            formCPU.Show();
            this.Hide();
        }
        private void panelRAM_MouseDown(object sender, MouseEventArgs e)
        {
            FormRAM formRAM = new FormRAM();
            formRAM.Show();
            this.Hide();
        }

        private void panelGPU_MouseDown(object sender, MouseEventArgs e)
        {
            FormGPU formGPU = new FormGPU();
            formGPU.Show();
            this.Hide();
        }

        private void panelStorage_MouseDown(object sender, MouseEventArgs e)
        {
            FormStorage storage = new FormStorage();
            storage.Show();
            this.Hide();
        }

        // --------------------------------------------------------------------
        private void timer_Tick(object sender, EventArgs e)
        {
            FillDetails();
        }
        private void FillDetails()
        {
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                foreach (ISensor sensor in hardware.Sensors)
                {

                   if(sensor.Name.Equals("CPU Total") && sensor.SensorType.Equals(SensorType.Load))
                    {
                        progressBarCPU.Value = Convert.ToInt32(sensor.Value);
                        lblCPUStatus.Text = String.Format("%{0:0.00}", sensor.Value);
                    }

                   else if (sensor.Name.Equals("Memory") && sensor.SensorType.Equals(SensorType.Load))
                    {
                        progressBarRAM.Value = Convert.ToInt32(sensor.Value);
                        lblRAMStatus.Text = String.Format("%{0:0.00}", sensor.Value);
                    }

                   else if (sensor.Name.Equals("GPU Core") && sensor.SensorType.Equals(SensorType.Load))
                    {
                        progressBarGPU.Value = Convert.ToInt32(sensor.Value);
                        lblGPUStatus.Text = String.Format("%{0:0.00}", sensor.Value);
                    }
                }
            }

            StorageChecker();
            BatteryInformationFiller();
        }
        public void StorageChecker()
        {
            string driveName = comboBoxDrivers.SelectedItem.ToString();
            double totalSpace = DriveInfo.GetDrives().Where(x => x.Name == driveName && x.IsReady).FirstOrDefault().TotalSize;
            double freeSpace = DriveInfo.GetDrives().Where(x => x.Name == driveName && x.IsReady).FirstOrDefault().TotalFreeSpace;

            double filledSpace = totalSpace - freeSpace;
            double filledPercent = filledSpace * 100 / totalSpace;

            progressBarStorage.Value = (int)filledPercent;

            lblStorageStatus.Text = String.Format("%{0:0.00}", filledPercent);
        }

        private void BatteryInformationFiller()
        {
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            int battery_percentage = (int)(powerStatus.BatteryLifePercent * 100);
            if (battery_percentage <= 100)
            {
                progressBarBattery.Value = battery_percentage;

                lblBatteryLevel.Text = $"%{battery_percentage}";
            }
            else
            {
                progressBarBattery.Value = 0;
            }

            switch (powerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    pctBatteryEnergy.Visible = true;
                    lblBatteryLevel.Visible = false;
                    break;

                case PowerLineStatus.Offline:
                    pctBatteryEnergy.Visible = false;
                    lblBatteryLevel.Visible = true;
                    break;
            }
        }
        private void GetDrivers()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo driver in allDrives)
            {
                comboBoxDrivers.Items.Add(driver.Name);
            }
        }

        int counter = 0;
        private void timer_Loader_Tick(object sender, EventArgs e)
        {
            counter++;
            progressBarCPU.Value = counter;
            progressBarGPU.Value = counter;
            progressBarRAM.Value = counter;
            progressBarStorage.Value = counter;
            progressBarBattery.Value = counter;

            if (counter == 100)
            {
                timer_Loader.Stop();
                timer_unloader.Start();
            }
        }
        private void timer_unloader_Tick(object sender, EventArgs e)
        {
            counter--;
            progressBarCPU.Value = counter;
            progressBarGPU.Value = counter;
            progressBarRAM.Value = counter;
            progressBarBattery.Value = counter;
            progressBarStorage.Value = counter;

            if (counter == 0)
            {
                timer_unloader.Stop();
                timer.Start();
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            ProcessList processList = new ProcessList();
            processList.Show();
            this.Hide();
        }
        private void btnProcess_MouseHover(object sender, EventArgs e)
        {
            pctrProcessListLine.Visible = true;
        }
        private void btnProcess_MouseLeave(object sender, EventArgs e)
        {
            pctrProcessListLine.Visible = false;
        }
        private void pctRefresh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void pctRefresh_MouseHover(object sender, EventArgs e)
        {
            pctrRefresfLine.Visible = true;
        }
        private void pctRefresh_MouseLeave(object sender, EventArgs e)
        {
            pctrRefresfLine.Visible = false;
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}