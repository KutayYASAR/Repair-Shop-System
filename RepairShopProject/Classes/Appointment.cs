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
    class Appointment
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        string date;
        string department;
        string customerID;
        string info;
        int ID;
        string status;

        public string Date { get => date; set => date = value; }
        public string Department { get => department; set => department = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string Info { get => info; set => info = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Status { get => status; set => status = value; }

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
            string CommandText = "select * from Appointments";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public void searchAppointment(string input,DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT * FROM Appointments WHERE CustomerID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT * FROM Appointments WHERE Department LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void updateAppointment(string date, string department, string customerID, string info,int id, DataGridView Grid)
        {
            string txtQuery = "update Appointments set Date='" + date + "',Department='" + department + "',CustomerID='" + customerID + "',Info='" + info + "' where ID='" + id + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeAppointment(int ID, DataGridView Grid)
        {
            string txtQuery = "delete from Appointments where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void addAppointment(string date, string department, string customerID, string info,string Status, DataGridView Grid)
        {
            string txtQuery = "insert into Appointments (Date,Department,CustomerID,Info,Status)values('" + date + "','" + department + "','" + customerID + "','" + info + "','"+Status+"')";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void changeStatus(string status,int id,DataGridView Grid)
        {
            string txtQuery = "update Appointments set Status'" + status + "' where ID='" + id + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
    }
}
