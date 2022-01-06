using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace TaskManager
{
    public partial class FormRAM : MetroFramework.Forms.MetroForm
    {
        Computer computer = new Computer() { RAMEnabled = true };
        public FormRAM()
        {
            InitializeComponent();
        }

        private void FormRAM_Load(object sender, EventArgs e)
        {
            computer.Open();
            timer.Start();
            FillDetails();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float totalSize = 0, usedSize = 0, availableSize = 0;

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.Name == "Memory" && sensor.SensorType == SensorType.Load)
                    {
                        progressBarRAM.Value = Convert.ToInt32(sensor.Value);
                        chartRAM.Series["RAM"].Points.AddY(sensor.Value);
                    }

                    else if (sensor.Name == "Used Memory" && sensor.SensorType == SensorType.Data)
                    {
                        lblUsed2.Text = $"{String.Format("{0:0.00}", sensor.Value)} GB";
                        usedSize = (float)sensor.Value;
                    }

                    else if (sensor.Name == "Available Memory" && sensor.SensorType == SensorType.Data)
                    {
                        lblAvailable2.Text = $"{String.Format("{0:0.00}", sensor.Value)} GB";
                        availableSize = (float)sensor.Value;
                    }

                    totalSize = usedSize + availableSize;
                    lblTotal2.Text = $"{String.Format("{0:0.00}", totalSize)} GB";
                }
            }
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            computer.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void FillDetails()
        {
            List<string> sentaxes = new List<string>() { "Speed" };
            List<string> details = FetchInformation("Win32_PhysicalMemory", sentaxes);

            int speed = Convert.ToInt32(details[0]);

            foreach (string detail in details)
            {
                if (Convert.ToInt32(detail) <= speed)
                {
                    speed = Convert.ToInt32(detail);
                }
            }

            lblSpeed2.Text = $"{speed} MHz";
        }

        private List<string> FetchInformation(string hwClass, List<string> synaxes)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\CIMV2", $"SELECT * FROM {hwClass}");

            List<string> details = new List<string>();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                foreach (string syntax in synaxes)
                {
                    details.Add((queryObj[syntax]).ToString());
                }
            }
            return details;
        }
    }
}
