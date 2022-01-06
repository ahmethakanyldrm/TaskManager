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
    public partial class FormCPU : MetroFramework.Forms.MetroForm
    {
        private bool isLoaded { get; set; } = false;

        Computer computer = new Computer()
        {
            CPUEnabled = true,
        };

        
        public FormCPU()
        {
            InitializeComponent();
        }

        private void FormCPU_Load(object sender, EventArgs e)
        {
            timer.Start();
            computer.Open();
            FillDetails();
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            computer.Close();
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {  
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                foreach (ISensor sensor in hardware.Sensors)
                {

                    if (sensor.Name == "CPU Total" && sensor.SensorType == SensorType.Load)
                    {
                        progressBarCPU.Value = Convert.ToInt32(sensor.Value);
                        chartCPU.Series["CPU"].Points.AddY(sensor.Value);
                    }

                    if(sensor.Name == "CPU Package" && sensor.SensorType == SensorType.Temperature)
                    {
                        chartT.Series["Sıcaklık"].Points.AddY(sensor.Value);
                    }
                }
            }
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

        private void FillDetails()
        {
            List<string> sentaxes = new List<string>() { "Name", "Level", "ThreadCount", "MaxClockSpeed" };
            List<string> details =  FetchInformation("Win32_Processor", sentaxes);

            lblCpuName2.Text = $"{details[0]}";
            lblCoreC2.Text = $"{details[1]}";
            lblThreadC2.Text = $"{details[2]}";
            lblSpeed2.Text = $"{details[3]}";
        }

      
    }
}
