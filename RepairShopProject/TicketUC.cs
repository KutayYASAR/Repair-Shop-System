using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class TicketUC : UserControl
    {
        bool clicked = false;
        public TicketUC()
        {
            InitializeComponent();

        }
        private void TicketUC_Load(object sender, EventArgs e)
        {
            var c = new Customer();
            var t = new Ticket();
            var p = new Product();
            p.loadData(DGProduct,"inm");
            t.loadData(DGTicket);
            c.loadData(DGCustomer,"ins");
        }

        private void TBCName_TextChanged(object sender, EventArgs e)
        {
            var c = new Customer();var t = new Ticket();
            if (!clicked)
            {
                t.searchTicket(TBCName.Text, DGTicket);
            }
            c.searchCustomerOutside(TBCId.Text, DGCustomer);
        }

        private void TBCId_TextChanged(object sender, EventArgs e)
        {
            var c = new Customer();
            c.searchCustomerOutside(TBCId.Text, DGCustomer);
        }

        private void BTTAdd_Click(object sender, EventArgs e)
        {
            var t = new Ticket();
            try
            {
                t.addTicket(DTStart.Value.ToString(), DTEnd.Value.ToString(), TBTInfo.Text.Trim(), CBStatus.SelectedItem.ToString(), int.Parse(TBCId.Text.Trim()), DGTicket);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTTRemove_Click(object sender, EventArgs e)
        {
            var t = new Ticket();
            try
            {
                t.removeTicket(int.Parse(TBTId.Text.Trim()),DGTicket,DGUsed);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTTUpdate_Click(object sender, EventArgs e)
        {
            var t = new Ticket();
            try
            {
                t.updateTicket(DTStart.Value.ToString(), DTEnd.Value.ToString(), TBTInfo.Text.Trim(), CBStatus.SelectedItem.ToString(), int.Parse(TBCId.Text.Trim()), int.Parse(TBTId.Text.Trim()), DGTicket);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void DGTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clicked = true;
                TBCName.Text = "";
                TBTId.Text = DGTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBTInfo.Text = DGTicket.Rows[e.RowIndex].Cells[4].Value.ToString();
                TBCId.Text = DGTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
                var c = new Customer();
                var t = new Ticket();
                c.searchCustomerOutside(TBCId.Text.Trim(), DGCustomer);
                TBCName.Text = DGCustomer.Rows[0].Cells[1].Value.ToString();
                CBStatus.SelectedItem = DGTicket.Rows[e.RowIndex].Cells[5].Value.ToString();
                DTStart.Text = DGTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
                DTEnd.Text = DGTicket.Rows[e.RowIndex].Cells[3].Value.ToString();
                t.used(int.Parse(TBTId.Text.Trim()),DGUsed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTTClear_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            var t = new Ticket();
            var p = new Product();
            TBTId.Text = "";
            TBTInfo.Text = "";
            TBCId.Text = "";
            TBCName.Text = "";
            CBStatus.SelectedIndex = 0;
            DTStart.Text = "";
            DTEnd.Text = "";
            p.loadData(DGProduct, "inm");
            t.loadData(DGTicket);
            c.loadData(DGCustomer, "ins");
            DGUsed.DataSource = null;
        }

        private void DGCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                try
                {
                    var c = new Customer();
                    TBCId.Text = DGCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                    c.searchCustomerOutside(TBCId.Text.Trim(), DGCustomer);
                    TBCName.Text = DGCustomer.Rows[0].Cells[1].Value.ToString();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            
        }

        private void DGProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var t = new Ticket();
                TBPAdd.Text = DGProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                t.addPTD(int.Parse(TBTId.Text.Trim()), int.Parse(TBPAdd.Text.Trim()));
                t.used(int.Parse(TBTId.Text.Trim()),DGUsed);
            }
            catch (Exception)
            {
                MessageBox.Show("Select the ticket first!");
            }
        }


        private void DGUsed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this part ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var t = new Ticket();
                    string UsedDelete = DGUsed.Rows[e.RowIndex].Cells[0].Value.ToString();
                    t.removePTD(int.Parse(TBTId.Text.Trim()),UsedDelete);
                    t.used(int.Parse(TBTId.Text.Trim()),DGUsed);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
