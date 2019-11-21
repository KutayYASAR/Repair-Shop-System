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
    public partial class CustomersUC : UserControl
    {
        public CustomersUC()
        {
            InitializeComponent();
        }

        private void CustomersUC_Load(object sender, EventArgs e)
        {
            var c = new Customer();
            c.loadData(DGCustomer);
        }

        private void BTCAdd_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            try
            {
                c.addCustomer(TBCName.Text.Trim(), TBCSurname.Text.Trim(), TBCPhone.Text.Trim(), TBCMail.Text.Trim(), DGCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
            
        }

        private void BTCRemove_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            try
            {
                c.removeCustomer(int.Parse(TBCId.Text.Trim()), DGCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
            
        }

        private void BTCUpdate_Click(object sender, EventArgs e)
        {
            var c = new Customer();
            try
            {
                c.updateCustomer(TBCName.Text.Trim(), TBCSurname.Text.Trim(), TBCPhone.Text.Trim(), TBCMail.Text.Trim(), int.Parse(TBCId.Text.Trim()), DGCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
            
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
            try
            {
                c.searchCustomer(TBCSearch.Text.Trim(), DGCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
                throw;
            }
            
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
                MessageBox.Show("Please only select the row !");
            }
        }
    }
    }

