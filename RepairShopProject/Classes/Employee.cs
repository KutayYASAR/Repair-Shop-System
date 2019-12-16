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
        protected SQLiteConnection con;
        protected SQLiteCommand cmd;
        protected SQLiteDataAdapter DB;
        protected DataSet DS = new DataSet();
        protected DataTable DT = new DataTable();
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

            string txtQuery = "insert into Employee (Name,Surname,Email,Password,Phone,isManager)values('" + Name + "','" + Surname + "','" + Email + "','" + Password + "','" + Phone + "','"+0+"')";
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
            string CommandText = "select ID,Name,Surname,Email,Password,Phone from Employee";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void loadData(string txtQuery,DataGridView Grid)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = txtQuery;
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
        public int Login(string mail,string password)
        {
            SQLiteConnection conc = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
            SQLiteCommand cmd = new SQLiteCommand("SELECT `Email`, `Password` FROM `Employee` WHERE `Email` = '" + mail + "' AND `Password` = '" + password + "'", conc);
            conc.Open();
            SQLiteCommand cmd2 = new SQLiteCommand("Select Email,Password FROM Employee WHERE Email = '" + mail + "' and Password = '" + password + "' and isManager = '" + 1 + "' ", conc);
            SQLiteDataReader dr = cmd.ExecuteReader();
            SQLiteDataReader dr1 = cmd2.ExecuteReader();
            int count = 0;
            int countmanager = 0;
            while (dr1.Read())
            {
                countmanager++;
            }
            while (dr.Read())
            {
                count++;
            }
            if (countmanager==1)
            {
                return 2;
            }
            if (count == 1)
            {
                return 1;

            }
            else if (count == 0)
            {
                return 0;
            }
            else
                return 0;
            dr.Close();
            dr1.Close();
            conc.Close();
        }
        public void Logout(Form form)
        {
            DialogResult dg = new DialogResult();
            dg=MessageBox.Show("Logging out?","LOGOUT",MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                form.Hide();
                Login l = new Login();
                l.Closed += (s, args) => form.Close();
                l.StartPosition = FormStartPosition.Manual;
                l.Location = new System.Drawing.Point(form.Location.X, form.Location.Y);
                l.Show();
            }
                
            else
                return;
        }
    }
}
