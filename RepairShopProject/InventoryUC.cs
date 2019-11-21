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
    public partial class InventoryUC : UserControl
    {
        public InventoryUC()
        {
            InitializeComponent();
            CBICategory.SelectedIndex = 0;
        }

        private void BTIAdd_Click(object sender, EventArgs e)
        {
            var p = new Product();
            try
            {
                p.addProduct(TBIName.Text.Trim(), TBIManifact.Text.Trim(), TBIModel.Text.Trim(), CBICategory.SelectedItem.ToString(), int.Parse(TBIBuyprice.Text.Trim()), int.Parse(TBIAmount.Text.Trim()), DGInventory);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
            
        }

        private void BTIRemove_Click(object sender, EventArgs e)
        {
            var p = new Product();
            try
            {
                p.removeProduct(int.Parse(TBIId.Text.Trim()), DGInventory);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
           
        }

        private void BTIUpdate_Click(object sender, EventArgs e)
        {
            var p = new Product();
            try
            {
                p.updateProduct(TBIName.Text.Trim(), TBIManifact.Text.Trim(), TBIModel.Text.Trim(), CBICategory.SelectedItem.ToString(), int.Parse(TBIBuyprice.Text.Trim()), int.Parse(TBIAmount.Text.Trim()), int.Parse(TBIId.Text.Trim()), DGInventory);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
            
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

        private void BTISearch_Click(object sender, EventArgs e)
        {
            var p = new Product();
            try
            {
                p.searchProduct(TBISearch.Text.Trim(), DGInventory);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
            
        }

        private void InventoryUC_Load(object sender, EventArgs e)
        {
            var p = new Product();
            p.loadData(DGInventory);
        }

        private void DGInventory_CellClick(object sender, DataGridViewCellEventArgs e)
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
                MessageBox.Show("Please only select the row!");
            }
        }
    }
}
