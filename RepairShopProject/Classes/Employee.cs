using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace RepairShopProject.Classes
{
    class Employee
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int id;
        string name;
        string surname;
        string email;
        string password;
        string phone;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }

        public void setConnection()
        {
            con = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
        }
        public void addEmployee(string Name, string Surname, string Email, string Password, string Phone, DataGridView Grid)
        {

            string txtQuery = "insert into Employee (Name,Surname,Email,Password,Phone)values('" + Name + "','" + Surname + "','" + Email + "','" + Password + "','" + Phone + "')";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeEmployee(int ID, DataGridView Grid)
        {
            string txtQuery = "delete from Employee where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void updateEmployee(string Name, string Surname, string Email, string Password, string Phone,int ID, DataGridView Grid)
        {
            string txtQuery = "update Employee set Name='" + Name + "',Surname='" + Surname + "',Email='" + Email + "',Password='" + Password + "',Phone='" + Phone + "' where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
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
            string CommandText = "select * from Employee";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void ClockIn(int id)
        {
            string date = DateTime.Now.TimeOfDay.ToString().Trim();
            string txtQuery = "insert into EmployeeATD (Date,EmployeeID,CIN)values('"+DateTime.Now.Date.ToString().Trim()+"','" + id + "','" + date + "')";
            executeQuery(txtQuery);
        }
        public void ClockOut(int id)
        {
            try
            {
                string date = DateTime.Now.TimeOfDay.ToString().Trim();
                string txtQuery = "update EmployeeATD set COUT = '" + date + "' where EmployeeID = '" + id + "' and Date = '"+ DateTime.Now.Date.ToString().Trim() + "'";
                executeQuery(txtQuery);

            }
            catch (Exception)
            {
                MessageBox.Show("Clock in first!");
            }
        }
        public void changePassword(string password,string email,string newPass)
        {
            string txt = "update Employee set Password = '" + newPass + "' where Email = '" + email + "' and Password= '" + password + "'";
            executeQuery(txt);
        }
        public void searchEmployee(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT * FROM Employee WHERE ID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT * FROM Employee WHERE Name LIKE'%" + input + "%'";
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
