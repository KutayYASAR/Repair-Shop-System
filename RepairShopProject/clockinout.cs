using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class clockinout : Form
    {
        public clockinout()
        {
            InitializeComponent();
        }

        private void BTIn_Click(object sender, EventArgs e)
        {
            var em = new Employee();
            em.ClockIn(Login.EmployeeID);
            this.Hide();
            var m = new newMainScreen();
            m.Closed += (s, args) => this.Close();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Location = new Point(this.Location.X, this.Location.Y);
            m.Show();
        }

        private void BTOut_Click(object sender, EventArgs e)
        {
            var em = new Employee();
            em.ClockOut(Login.EmployeeID);
            this.Hide();
            var m = new newMainScreen();
            m.Closed += (s, args) => this.Close();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Location = new Point(this.Location.X, this.Location.Y);
            m.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new newMainScreen();
            m.Closed += (s, args) => this.Close();
            m.StartPosition = FormStartPosition.CenterScreen;
            m.Location = new Point(this.Location.X, this.Location.Y);
            m.Show();
        }
    }
}
