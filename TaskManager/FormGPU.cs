using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.Management;

namespace TaskManager
{
    public partial class FormGPU : MetroFramework.Forms.MetroForm
    {
        Computer computer = new Computer() { GPUEnabled = true};
        public FormGPU()
        {
            InitializeComponent();
        }

        private void FormGPU_Load(object sender, EventArgs e)
        {
            timer.Start();
            computer.Open();
            FillDetails();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                foreach (ISensor sensor in hardware.Sensors)
                {

                    if (sensor.Name == "GPU Core" && sensor.SensorType == SensorType.Load)
                    {
                        progressBarGPU.Value = Convert.ToInt32(sensor.Value);
                        chartGPU.Series["GPU"].Points.AddY(sensor.Value);
                        
                    }

                    else if (sensor.Name == "GPU Core" && sensor.SensorType == SensorType.Temperature)
                    {
                        chartT.Series["Sıcaklık"].Points.AddY(sensor.Value);
                    }

                    else if (sensor.Name == "GPU Memory Total" && sensor.SensorType == SensorType.SmallData)
                    {
                        lblTotalMemory2.Text = $"{String.Format("{0:0.00}", sensor.Value)} MB";
                    }

                    else if (sensor.Name == "GPU Memory Used" && sensor.SensorType == SensorType.SmallData)
                    {
                        lblUsedMemory2.Text = $"{String.Format("{0:0.00}", sensor.Value)} MB";
                    }

                    else if (sensor.Name == "GPU Memory Free" && sensor.SensorType == SensorType.SmallData)
                    {
                        lblFreeMemory2.Text = $"{String.Format("{0:0.00}", sensor.Value)} MB";
                    }

                }
            }
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            computer.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void FillDetails()
        {
            List<string> sentaxes = new List<string>() { "Name" };
            List<string> details = FetchInformation("Win32_VideoController", sentaxes);

            lblGPUName2.Text = $"{details[details.Count-1]}";
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
