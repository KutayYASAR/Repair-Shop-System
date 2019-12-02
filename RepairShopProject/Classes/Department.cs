using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RepairShopProject.Classes
{
    class Department
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int departmentID;
        string departmentName;
        string departmentInfo;

        public int DepartmentID { get => departmentID; set => departmentID = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string DepartmentInfo { get => departmentInfo; set => departmentInfo = value; }

        public void setConnection()
        {
            con = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
        }
        public void executeQuery(string txtQuery)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void loadData(DataGridView Grid)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "select * from Department";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public void addDepartment(string Name,string Info,DataGridView grid)
        {
            string txtQuery = "insert into Department(Name, Info)values('" + Name + "', '" + Info + "')";
            executeQuery(txtQuery);
            loadData(grid);
        }
        public void removeDepartment(int ID,DataGridView grid)
        {
            string txtQuery = "delete from Department where ID = '"+ID+"'";
            executeQuery(txtQuery);
            loadData(grid);
        }
        public void updateDepartment(string Name,string Info,int ID,DataGridView grid)
        {
            string txtQuery = "update Department set Name='" + Name + "',Info ='" + Info + "' where ID ='" + ID + "'";
            executeQuery(txtQuery);
            loadData(grid);
        }
        public void searchDepartment(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT * FROM Department WHERE ID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT * FROM Department WHERE Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
    }
}
