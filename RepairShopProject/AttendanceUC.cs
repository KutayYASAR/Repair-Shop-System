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
  
    public partial class AttendanceUC : UserControl
    {
        int EmpID;
        private bool clearClick = false;
        public AttendanceUC()
        {
            InitializeComponent();
        }

        private void DGEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID = int.Parse(DGEmp.Rows[e.RowIndex].Cells[0].Value.ToString());
            var em = new Employee();
            em.loadData("select * from EmployeeATD where EmployeeID= '"+EmpID+"'",
                DGAtt);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var em = new Employee();
            if (clearClick == true)
            {
                em.loadData("select * from EmployeeATD where EmployeeID= '" + EmpID + "'",
                    DGAtt);
                clearClick = false;
            }
            else
            {
                em.loadData("select * from EmployeeATD where EmployeeID= '" + EmpID + "' and Date = '" + dateTimePicker1.Value.Date.ToString() + "'",
                    DGAtt);
            }
        }

        private void AttendanceUC_Load(object sender, EventArgs e)
        {
            var em = new Employee();
            em.loadData(DGEmp);
        }

        private void BTAClear_Click(object sender, EventArgs e)
        {
            clearClick = true;
            DGAtt.DataSource = null;
            dateTimePicker1.Value = DateTime.Now.Date;
            
        }
    }
}
