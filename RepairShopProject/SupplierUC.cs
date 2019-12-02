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
    public partial class SupplierUC : UserControl
    {
        public SupplierUC()
        {
            InitializeComponent();
        }

        private void BTSAdd_Click(object sender, EventArgs e)
        {
            var c = new Supplier();
            try
            {
                c.addSupplier(TBSName.Text.Trim(), TBSContact.Text.Trim(), TBSProduct.Text.Trim(), TBSInfo.Text.Trim(), DGSupplier);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTSRemove_Click(object sender, EventArgs e)
        {
            var c = new Supplier();
            try
            {
                c.removeSupplier(int.Parse(TBSId.Text.Trim()), DGSupplier);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTSUpdate_Click(object sender, EventArgs e)
        {
            var c = new Supplier();
            try
            {
                c.updateSupplier(TBSName.Text.Trim(), TBSContact.Text.Trim(), TBSProduct.Text.Trim(), TBSInfo.Text.Trim(), int.Parse(TBSId.Text.Trim()), DGSupplier);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTSSearch_Click(object sender, EventArgs e)
        {
            var c = new Supplier();
            try
            {
                c.searchSupplier(TBSSearch.Text.Trim(), DGSupplier);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
                throw;
            }
        }

        private void BTSClear_Click(object sender, EventArgs e)
        {
            var c = new Supplier();
            TBSId.Text = "";
            TBSInfo.Text = "";
            TBSName.Text = "";
            TBSContact.Text = "";
            TBSProduct.Text = "";
            c.loadData(DGSupplier);
        }

        private void SupplierUC_Load(object sender, EventArgs e)
        {
            var c = new Supplier();
            c.loadData(DGSupplier);
        }
    }
}
