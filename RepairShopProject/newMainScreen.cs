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
        public SupplierUC supplierUC1 = new SupplierUC();
        public TicketUC ticketUC1 = new TicketUC();
        public PaymentUC paymentUC1 = new PaymentUC();

        
        public newMainScreen()
        {
            InitializeComponent();
            panel4.Hide();
            Controls.Add(customersUC1);
            Controls.Add(inventoryUC1);
            Controls.Add(supplierUC1);
            Controls.Add(ticketUC1);
            Controls.Add(paymentUC1);
            supplierUC1.Height = panel3.Height;
            supplierUC1.Location = panel3.Location;
            supplierUC1.Top = panel3.Top + 25;
            paymentUC1.Height = panel3.Height;
            paymentUC1.Location = panel3.Location;
            paymentUC1.Top = panel3.Top + 25;
            inventoryUC1.Height = panel3.Height;
            inventoryUC1.Location = panel3.Location;
            inventoryUC1.Top = panel3.Top + 25;
            customersUC1.Height = panel3.Height;
            customersUC1.Location = panel3.Location;
            customersUC1.Top = panel3.Top + 25;
            ticketUC1.Height = panel3.Height;
            ticketUC1.Location = panel3.Location;
            ticketUC1.Top = panel3.Top + 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button1.Height;
            panel4.Top = button1.Top;
            inventoryUC1.Hide();
            supplierUC1.Hide();
            ticketUC1.Hide();
            paymentUC1.Hide();
            customersUC1.Show();
            customersUC1.BringToFront();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button2.Height;
            panel4.Top = button2.Top;
            supplierUC1.Hide();
            customersUC1.Hide();
            ticketUC1.Hide();
            paymentUC1.Hide();
            inventoryUC1.Show();
            inventoryUC1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button3.Height;
            panel4.Top = button3.Top;
            supplierUC1.Hide();
            inventoryUC1.Hide();
            customersUC1.Hide();
            paymentUC1.Hide();
            ticketUC1.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button4.Height;
            panel4.Top = button4.Top;
            supplierUC1.Hide();
            inventoryUC1.Hide();
            customersUC1.Hide();
            ticketUC1.Hide();
            paymentUC1.Show();
            paymentUC1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button5.Height;
            panel4.Top = button5.Top;
            inventoryUC1.Hide();
            customersUC1.Hide();
            ticketUC1.Hide();
            paymentUC1.Hide();
            supplierUC1.Show();
            supplierUC1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel4.Height = button6.Height;
            panel4.Top = button6.Top;
            inventoryUC1.Hide();
            customersUC1.Hide();
            paymentUC1.Hide();
            supplierUC1.Hide();
            ticketUC1.Show();
            ticketUC1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            var c = new clockinout();
            c.Closed += (s, args) => this.Close();
            c.StartPosition = FormStartPosition.CenterScreen;
            c.Location = new Point(this.Location.X, this.Location.Y);
            c.Show();
        }
    }
}
