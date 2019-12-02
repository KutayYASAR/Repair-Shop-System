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
    class Supplier
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int id;
        string name;
        string contact;
        string products;
        string info;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Products { get => products; set => products = value; }
        public string Info { get => info; set => info = value; }

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
            string CommandText = "select * from Supplier";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public void searchSupplier(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
                CommandText = "SELECT * FROM Supplier WHERE Name OR Products LIKE'%" + input + "%'";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void updateSupplier(string Name, string Contact, string Product, string Info, int ID, DataGridView Grid)
        {
            string txtQuery = "update Supplier set Name='" + Name + "',Contact='" + Contact + "',Products='" + Product + "',Info='" + Info + "' where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeSupplier(int ID, DataGridView Grid)
        {
            string txtQuery = "delete from Supplier where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void addSupplier(string Name, string Contact, string Product, string Info, DataGridView Grid)
        {
            string txtQuery = "insert into Supplier (Name,Contact,Products,Info)values('" + Name + "','" + Contact + "','" + Product + "','" + Info + "')";
            executeQuery(txtQuery);
            loadData(Grid);
        }

    }
}
