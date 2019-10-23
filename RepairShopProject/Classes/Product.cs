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
    /*SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
    SQLiteCommand cmd = new SQLiteCommand("SELECT * from Inventory", con);
    con.Open();
            SQLiteDataReader dr = cmd.ExecuteReader();
    DataTable dt = new DataTable();
    dt.Load(dr);
            dr.Close();
            con.Close();
            DGInventory.DataSource = dt;*/
    public class Product
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        string name;
        string manifacturer;
        string model;
        string category;
        int buyPrice;
        int amount;
        int id;

        public string Name { get => name; set => name = value; }
        public string Manifacturer { get => manifacturer; set => manifacturer = value; }
        public string Model { get => model; set => model = value; }
        public string Category { get => category; set => category = value; }
        public int BuyPrice { get => buyPrice; set => buyPrice = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Id { get => id; set => id = value; }

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
            string CommandText = "select * from Inventory";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public void updateData(DataGridView Grid,string txtQuery)
        {
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeData(DataGridView Grid, string txtQuery)
        {
            executeQuery(txtQuery);
            loadData(Grid);
        }
    }
}
