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
    public partial class newMainScreen : Form
    {
        public newMainScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            customerUC1.Show();
            customerUC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            customerUC1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            customerUC1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            customerUC1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            customerUC1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            customerUC1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
