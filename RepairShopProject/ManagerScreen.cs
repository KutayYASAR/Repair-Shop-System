using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairShopProject
{
    public partial class ManagerScreen : Form
    {
        public ConfCodeUC confCodeUC = new ConfCodeUC();
        public EmployeeUC employeeUC = new EmployeeUC();
        public ProfitUC profitUC = new ProfitUC();
        public AttendanceUC attendanceUC = new AttendanceUC();
        public ManagerScreen()
        {
            InitializeComponent();
            panel4.Hide();
            Controls.Add(confCodeUC);
            Controls.Add(employeeUC);
            Controls.Add(profitUC);
            Controls.Add(attendanceUC);
            confCodeUC.Height = panel3.Height;
            confCodeUC.Location = panel3.Location;
            confCodeUC.Top = panel3.Top + 25;
            employeeUC.Height = panel3.Height;
            employeeUC.Location = panel3.Location;
            employeeUC.Top = panel3.Top + 25;
            profitUC.Height = panel3.Height;
            profitUC.Location = panel3.Location;
            profitUC.Top = panel3.Top + 25;
            attendanceUC.Height = panel3.Height;
            attendanceUC.Location = panel3.Location;
            attendanceUC.Top = panel3.Top + 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            confCodeUC.Hide();
            profitUC.Hide();
            attendanceUC.Hide();
            employeeUC.Show();
            employeeUC.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            confCodeUC.Hide();
            profitUC.Hide();
            employeeUC.Hide();
            attendanceUC.Show();
            attendanceUC.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            confCodeUC.Hide();
            attendanceUC.Hide();
            employeeUC.Hide();
            profitUC.Show();
            profitUC.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            profitUC.Hide();
            attendanceUC.Hide();
            employeeUC.Hide();
            confCodeUC.Show();
            confCodeUC.BringToFront();
        }
    }
}
