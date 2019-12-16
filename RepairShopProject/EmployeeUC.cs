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
    public partial class EmployeeUC : UserControl
    {
        private bool loading = false;
        public EmployeeUC()
        {
            InitializeComponent();
        }

        private void DGAppo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loading = true;
            TBEId.Text = DGAppo.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBEName.Text = DGAppo.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBESurname.Text = DGAppo.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBEMail.Text = DGAppo.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBEPass.Text = DGAppo.Rows[e.RowIndex].Cells[4].Value.ToString();
            TBEPhone.Text = DGAppo.Rows[e.RowIndex].Cells[5].Value.ToString();
            loading = false;
        }

        private void BTAAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var em = new Employee();
                em.addEmployee(TBEName.Text.Trim(), TBESurname.Text.Trim(), TBEMail.Text.Trim(), TBEPass.Text.Trim(), TBEPhone.Text.Trim(), DGAppo);
            }
            catch(Exception)
            {
                MessageBox.Show("Fill All Areas");
            }
        }

        private void BTARemove_Click(object sender, EventArgs e)
        {
            try
            {
                var em = new Employee();
                em.removeEmployee(int.Parse(TBEId.Text.Trim()), DGAppo);
            }
            catch (Exception)
            {
                MessageBox.Show("Fill All Areas");
            }
        }

        private void BTAUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var em = new Employee();
                em.updateEmployee(TBEName.Text.Trim(), TBESurname.Text.Trim(), TBEMail.Text.Trim(), TBEPass.Text.Trim(), TBEPhone.Text.Trim(), int.Parse(TBEId.Text.Trim()), DGAppo);
            }
            catch (Exception)
            {
                MessageBox.Show("Fill All Areas");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Are you sure?", "PROMOTE", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    var m = new Manager();
                    m.executeQuery("update Employee set isManager = '"+1+"' where ID = '"+TBEId.Text.Trim()+"'");
                }
            }
            catch
            {
                MessageBox.Show("Fill All Areas");
            }
        }

        private void BTAClear_Click(object sender, EventArgs e)
        {
            TBEId.Text = "";
            TBEName.Text ="";
            TBESurname.Text = "";
            TBEMail.Text ="";
            TBEPass.Text = "";
            TBEPhone.Text = "";
            var em = new Employee();
            em.loadData(DGAppo);
        }

        private void TBADept_TextChanged(object sender, EventArgs e)
        {
            if (loading == false)
            {
                var em = new Employee();
                em.searchEmployee(TBEName.Text.Trim(), DGAppo);
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (loading == false)
            {
                var em = new Employee();
                em.searchEmployee(TBEId.Text.Trim(), DGAppo);
            }
            
        }

        private void EmployeeUC_Load(object sender, EventArgs e)
        {
            var em = new Employee();
            em.loadData(DGAppo);
        }
    }
}
