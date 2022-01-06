using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Intro_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Task Manager2.mp4";
            timer1.Interval = 300;
            timer1.Start();
        }

      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 10)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();

            }
        }
    }
}
