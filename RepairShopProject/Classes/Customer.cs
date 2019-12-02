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
    class Customer
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int id;
        string name;
        string surname;
        string contact;
        string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }

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
            string CommandText = "select * from Customer";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public void loadData(DataGridView Grid, string loadtype)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "select * from Customer";
            if (loadtype == "n")
            {
                CommandText = "select Name from Customer";
            }
            else if (loadtype == "ns")
            {
                CommandText = "select Name,Surname from Customer";
            }
            else if (loadtype=="ins")
            {
                CommandText = "select ID,Name,Surname from Customer";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public void searchCustomer(string input,DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT * FROM Customer WHERE Contact LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT * FROM Customer WHERE Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void searchCustomerOutside(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT ID,Name,Surname FROM Customer WHERE ID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT ID,Name,Surname FROM Customer WHERE Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void updateCustomer(string Name, string Surname, string Contact, string Email,int ID, DataGridView Grid)
        {
            string txtQuery = "update Customer set Name='" + Name + "',Surname='" + Surname + "',Contact='" + Contact + "',Email='" + Email + "' where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeCustomer(int ID,DataGridView Grid)
        {
            string txtQuery = "delete from Customer where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void addCustomer(string Name,string Surname,string Contact,string Email,DataGridView Grid)
        {
            string txtQuery = "insert into Customer (Name,Surname,Contact,Email)values('" + Name + "','" + Surname + "','" + Contact + "','" + Email + "')";
            executeQuery(txtQuery);
            loadData(Grid);
        }
    }
}
