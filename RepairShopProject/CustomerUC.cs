using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class CustomerUC : UserControl
    {
        public CustomerUC()
        {
            InitializeComponent();
        }
        private void CustomerUC_Load(object sender, EventArgs e)
        {
            var c = new Customer();
            c.loadData(DGCustomer);
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
