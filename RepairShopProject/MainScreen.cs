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
            p.Name = TBIName.Text.Trim();
            p.Model = TBIModel.Text.Trim();
            p.Manifacturer = TBIManifact.Text.Trim();
            p.Category = CBICategory.SelectedItem.ToString();
            p.Amount = int.Parse(TBIAmount.Text.Trim());
            p.BuyPrice = int.Parse(TBIBuyprice.Text.Trim());
            string txtQuery = "insert into Inventory (Name,Model,Amount,BuyPrice,Category,Manifact)values('" + p.Name + "','" + p.Model + "','" + p.Amount + "','" + p.BuyPrice + "','" + p.Category + "','" + p.Manifacturer + "')";
            p.executeQuery(txtQuery);
            p.loadData(DGInventory);
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
            catch (Exception ex)
            {
                MessageBox.Show("Please only select the row header! ");
            }
        }

        private void BTUpdate_Click(object sender, EventArgs e)
        {
            var p = new Product();
            p.Name = TBIName.Text.Trim();
            p.Model = TBIModel.Text.Trim();
            p.Manifacturer = TBIManifact.Text.Trim();
            p.Category = CBICategory.SelectedItem.ToString();
            p.Amount = int.Parse(TBIAmount.Text.Trim());
            p.BuyPrice = int.Parse(TBIBuyprice.Text.Trim());
            string txtQuery = "update Inventory set Name='"+p.Name+ "',Model='"+p.Model+ "',Manifact='" + p.Manifacturer + "',Category='" +p.Category+ "',Amount='" + p.Amount + "',BuyPrice='" + p.BuyPrice + "' where ID='" + int.Parse(TBIId.Text.Trim()) + "'";
            p.updateData(DGInventory, txtQuery);
        }

        private void BTRemove_Click(object sender, EventArgs e)
        {
            var p = new Product();
            p.Name = TBIName.Text.Trim();
            p.Model = TBIModel.Text.Trim();
            p.Manifacturer = TBIManifact.Text.Trim();
            p.Category = CBICategory.SelectedItem.ToString();
            p.Amount = int.Parse(TBIAmount.Text.Trim());
            p.BuyPrice = int.Parse(TBIBuyprice.Text.Trim());
            string txtQuery = "delete from Inventory where ID='" + int.Parse(TBIId.Text.Trim()) + "'";
            p.removeData(DGInventory, txtQuery);
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
            catch (Exception x)
            {
                MessageBox.Show("Please only select the row header! ");
            }
        }

        private void BTCAdd_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.Name = TBCName.Text.Trim();
            c.Surname = TBCSurname.Text.Trim();
            c.Contact = TBCPhone.Text.Trim();
            c.Email = TBCMail.Text.Trim();
            string txtQuery = "insert into Customer (Name,Surname,Contact,Email)values('" + c.Name + "','" + c.Surname + "','" + c.Contact + "','" + c.Email + "')";
            c.executeQuery(txtQuery);
            c.loadData(DGCustomer);
        }

        private void BTCRemove_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.Name = TBCName.Text.Trim();
            c.Surname = TBCSurname.Text.Trim();
            c.Contact = TBCPhone.Text.Trim();
            c.Email = TBCMail.Text.Trim();
            string txtQuery = "delete from Customer where ID='" + int.Parse(TBCId.Text.Trim()) + "'";
            c.executeQuery(txtQuery);
            c.loadData(DGCustomer);
        }

        private void BTCUpdate_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            c.Name = TBCName.Text.Trim();
            c.Surname = TBCSurname.Text.Trim();
            c.Contact = TBCPhone.Text.Trim();
            c.Email = TBCMail.Text.Trim();
            string txtQuery = "update Customer set Name='" + c.Name + "',Surname='" + c.Surname + "',Contact='" + c.Contact + "',Email='" + c.Email + "' where ID='" + int.Parse(TBCId.Text.Trim()) + "'";
            c.executeQuery(txtQuery);
            c.loadData(DGCustomer);
        }

        private void BTCClear_Click(object sender, EventArgs e)
        {
            TBCId.Text = "";
            TBCMail.Text = "";
            TBCName.Text = "";
            TBCPhone.Text = "";
            TBCSurname.Text = "";
        }

    }
}
