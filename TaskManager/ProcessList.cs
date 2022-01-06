using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class ProcessList : MetroFramework.Forms.MetroForm
    {
        public ProcessList()
        {
            InitializeComponent();
        }

        private void ProcessList_Load(object sender, EventArgs e)
        {
            timer.Start();
            Process[] processesArr = Process.GetProcesses(); // Get all process

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("İsim", typeof(string));
            dataTable.Columns.Add("Başlık", typeof(string));
            dataTable.Columns.Add("Durum", typeof(string));
            dataTable.Columns.Add("Öncelik", typeof(string));
            dataTable.Columns.Add("Ayrılan Bellek", typeof(double));

            FillTable(dataTable, processesArr);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Process[] processesArr = Process.GetProcesses();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("İsim", typeof(string));
            dataTable.Columns.Add("Başlık", typeof(string));
            dataTable.Columns.Add("Durum", typeof(string));
            dataTable.Columns.Add("Öncelik", typeof(string));
            dataTable.Columns.Add("Ayrılan Bellek", typeof(double));


            FillTable(dataTable, processesArr);
        }

        private void FillTable(DataTable dataTable, Process[] processesArr)
        {
            foreach (Process process in processesArr.OrderByDescending(p => p.MainWindowTitle))
            {
                string responding = null, basePriority = null;

                if (process.Responding.Equals(true))
                {
                    responding = "Çalışıyor";
                }

                else
                {
                    responding = "Yanıt vermiyor";
                }

                switch (process.BasePriority)
                {
                    case 4:
                        basePriority = "Boşta";
                        break;

                    case 8:
                        basePriority = "Normal";
                        break;

                    case 13:
                        basePriority = "Yüksek";
                        break;

                    case 24:
                        basePriority = "Gerçek zamanlı";
                        break;

                    default:
                        basePriority = "Boşta";
                        break;
                }

                dataTable.Rows.Add(
                    process.Id,
                    process.ProcessName,
                    process.MainWindowTitle,
                    responding,
                    basePriority,
                    Math.Round((process.WorkingSet / Math.Pow(1024, 2)), 2)
                    );
            }
            gridProcesses.DataSource = dataTable;
        }

        private void gridProcesses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in gridProcesses.Rows)
            {
                if (row.Cells[1].Value.Equals("svchost"))
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Green;
                }
            }
        }

        private void gridProcesses_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                int positionMouse = gridProcesses.HitTest(e.X, e.Y).RowIndex;

                if (positionMouse > -1)
                {
                    menu.Items.Add("Sonlandır").Name = "Kill";
                }

                menu.Show(gridProcesses, new Point(e.X, e.Y));
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_Item_Clicked);
            }
        }

        private void menu_Item_Clicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridViewRow selectedRow = gridProcesses.Rows[gridProcesses.SelectedCells[0].RowIndex];
            int cellValue = (int)selectedRow.Cells["Id"].Value;

            ProcessKill(cellValue);
        }

        private void gridProcesses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;

                if (e.RowIndex != -1)
                {
                    this.gridProcesses.ClearSelection();
                    this.gridProcesses.Rows[rowSelected].Selected = true;
                }
            }
        }

        private void ProcessKill(int id)
        {
            Process process = Process.GetProcessById(id);
            process.Kill();

            Process[] processesArr = Process.GetProcesses();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("İsim", typeof(string));
            dataTable.Columns.Add("Başlık", typeof(string));
            dataTable.Columns.Add("Durum", typeof(string));
            dataTable.Columns.Add("Öncelik", typeof(string));
            dataTable.Columns.Add("Ayrılan Bellek", typeof(double));


            FillTable(dataTable, processesArr);
        }

        private void btnBackToMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }
    }
}
