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
        public CustomersUC customersUC1 = new CustomersUC();
        public InventoryUC inventoryUC1 = new InventoryUC();
        
        public newMainScreen()
        {
            InitializeComponent();
            panel4.Hide();
            Controls.Add(customersUC1);
            Controls.Add(inventoryUC1);
            inventoryUC1.Height = panel3.Height;
            inventoryUC1.Location = panel3.Location;
            inventoryUC1.Top = panel3.Top + 25;
            customersUC1.Height = panel3.Height;
            customersUC1.Location = panel3.Location;
            customersUC1.Top = panel3.Top + 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            inventoryUC1.Hide();
            customersUC1.Show();
            customersUC1.BringToFront();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            customersUC1.Hide();
            inventoryUC1.Show();
            inventoryUC1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            inventoryUC1.Hide();
            customersUC1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            inventoryUC1.Hide();
            customersUC1.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            inventoryUC1.Hide();
            customersUC1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            inventoryUC1.Hide();
            customersUC1.Hide();
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
