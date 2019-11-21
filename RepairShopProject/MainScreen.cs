using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            CBICategory.SelectedIndex = 0;
        }
        private void TPCustomers_Enter(object sender, EventArgs e)
        {
            
            var c = new Customer();
            c.loadData(DGCustomer);
        }
        private void TBInventory_Enter(object sender, EventArgs e)
        {
            var p = new Product();
            p.loadData(DGInventory);
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            var p = new Product();
            p.addProduct(TBIName.Text.Trim(),TBIManifact.Text.Trim(),TBIModel.Text.Trim(),CBICategory.SelectedItem.ToString(),int.Parse(TBIBuyprice.Text.Trim()),int.Parse(TBIAmount.Text.Trim()), DGInventory);
        }
        private void DGInventory_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                TBIId.Text = DGInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBIName.Text = DGInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
                TBIModel.Text = DGInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
                TBIAmount.Text = DGInventory.Rows[e.RowIndex].Cells[3].Value.ToString();
                TBIBuyprice.Text = DGInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
                CBICategory.SelectedItem = DGInventory.Rows[e.RowIndex].Cells[5].Value.ToString();
                TBIManifact.Text = DGInventory.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please only select the row header! ");
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            var p = new Product();
            p.updateProduct(TBIName.Text.Trim(), TBIManifact.Text.Trim(), TBIModel.Text.Trim(), CBICategory.SelectedItem.ToString(), int.Parse(TBIBuyprice.Text.Trim()), int.Parse(TBIAmount.Text.Trim()),int.Parse(TBIId.Text.Trim()), DGInventory); 
        }

        private void BTRemove_Click(object sender, EventArgs e)
        {
            var p = new Product();
            p.removeProduct(int.Parse(TBIId.Text.Trim()),DGInventory);
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            
            TBIName.Text = "";
            TBIModel.Text = "";
            TBIManifact.Text = "";
            TBIAmount.Text = "";
            TBIBuyprice.Text = "";
            TBIId.Text = "";
            CBICategory.SelectedIndex = 0;
            

        }

        private void DGCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TBCId.Text = DGCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBCName.Text = DGCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                TBCSurname.Text = DGCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                TBCPhone.Text = DGCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                TBCMail.Text = DGCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please only select the row header! ");
            }
        }

        private void BTCAdd_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.addCustomer(TBCName.Text.Trim(), TBCSurname.Text.Trim(), TBCPhone.Text.Trim(), TBCMail.Text.Trim(), DGCustomer);

        }

        private void BTCRemove_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.removeCustomer(int.Parse(TBCId.Text.Trim()),DGCustomer);

        }

        private void BTCUpdate_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.updateCustomer(TBCName.Text.Trim(), TBCSurname.Text.Trim(), TBCPhone.Text.Trim(), TBCMail.Text.Trim(), int.Parse(TBCId.Text.Trim()), DGCustomer);
        }

        private void BTCClear_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            TBCId.Text = "";
            TBCMail.Text = "";
            TBCName.Text = "";
            TBCPhone.Text = "";
            TBCSurname.Text = "";
            c.loadData(DGCustomer);
        }

        private void BTCSearch_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.searchCustomer(TBCName.Text.Trim(), DGCustomer);
        }
    }
}
