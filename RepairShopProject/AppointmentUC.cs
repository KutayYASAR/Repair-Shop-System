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
    public partial class AppointmentUC : UserControl
    {
        public AppointmentUC()
        {
            InitializeComponent();
        }

        private void DGCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var c = new Customer();
                TBACustomer.Text = DGCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                c.searchCustomerOutside(TBACustomer.Text.Trim(), DGCustomer);
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void DGDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var d = new Department();
                TBADept.Text = DGDepartment.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void DGAppo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var c = new Customer();
                TBACustomer.Text = DGAppo.Rows[e.RowIndex].Cells[3].Value.ToString();
                TBADept.Text = DGAppo.Rows[e.RowIndex].Cells[2].Value.ToString();
                TBAId.Text = DGAppo.Rows[e.RowIndex].Cells[0].Value.ToString();
                TBAInfo.Text = DGAppo.Rows[e.RowIndex].Cells[4].Value.ToString();
                CBStatus.SelectedItem = DGAppo.Rows[e.RowIndex].Cells[5].Value.ToString();
                DTApp.Text = DGAppo.Rows[e.RowIndex].Cells[1].Value.ToString();
                c.searchCustomerOutside(TBACustomer.Text.Trim(), DGCustomer);

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void AppointmentUC_Load(object sender, EventArgs e)
        {
            var d = new Department();
            var c = new Customer();
            var a = new Appointment();
            a.loadData(DGAppo);
            c.loadData(DGCustomer, "ins");
            d.loadData(DGDepartment);
        }

        private void BTAAdd_Click(object sender, EventArgs e)
        {
            var a = new Appointment();
            try
            {
                a.addAppointment(DTApp.Value.ToString(), TBADept.Text.Trim(), TBACustomer.Text.Trim(), TBAInfo.Text.Trim(), CBStatus.SelectedItem.ToString(), DGAppo);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTARemove_Click(object sender, EventArgs e)
        {
            var a = new Appointment();
            try
            {
                a.removeAppointment(int.Parse(TBAId.Text.Trim()), DGAppo);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTAUpdate_Click(object sender, EventArgs e)
        {
            var a = new Appointment();
            try
            {
                a.updateAppointment(DTApp.Value.ToString(), TBADept.Text.Trim(), TBACustomer.Text.Trim(), TBAInfo.Text.Trim(), int.Parse(TBAId.Text.Trim()), DGAppo);
                a.changeStatus(CBStatus.SelectedItem.ToString(), int.Parse(TBAId.Text.Trim()), DGAppo);
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill required areas.");
            }
        }

        private void BTAClear_Click(object sender, EventArgs e)
        {
            
            TBACustomer.Text = "";
            TBADept.Text = "";
            TBAId.Text = "";
            TBAInfo.Text = "";
            DTApp.Text = "";
            CBStatus.SelectedIndex = 0;
            var d = new Department();
            var c = new Customer();
            var a = new Appointment();
            a.loadData(DGAppo);
            c.loadData(DGCustomer, "ins");
            d.loadData(DGDepartment);
        }

        private void TBACustomer_TextChanged(object sender, EventArgs e)
        {
            var c = new Customer();
            c.searchCustomerOutside(TBACustomer.Text.Trim(), DGCustomer);
        }
    }
}
