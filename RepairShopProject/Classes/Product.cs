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
        int salePrice;
        int amount;
        int id;

        public string Name { get => name; set => name = value; }
        public string Manifacturer { get => manifacturer; set => manifacturer = value; }
        public string Model { get => model; set => model = value; }
        public string Category { get => category; set => category = value; }
        public int BuyPrice { get => buyPrice; set => buyPrice = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Id { get => id; set => id = value; }
        public int SalePrice { get => salePrice; set => salePrice = value; }

        public void setConnection()
        {
            con = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
        }
        public void addProduct(string Name,string Manifacturer,string Model,string Category,int BuyPrice,int SalePrice,int Amount, DataGridView Grid)
        {

            string txtQuery = "insert into Inventory (Name,Model,Amount,BuyPrice,Category,Manifact,SalePrice)values('" + Name + "','" + Model + "','" + Amount + "','" + BuyPrice + "','" + Category + "','" + Manifacturer + "','"+SalePrice+"')";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeProduct(int ID,DataGridView Grid)
        {
            string txtQuery = "delete from Inventory where ID='" +ID +"'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void updateProduct(string Name, string Manifacturer, string Model, string Category, int BuyPrice, int SalePrice, int Amount,int ID, DataGridView Grid)
        {
            string txtQuery = "update Inventory set Name='" + Name + "',Model='" + Model + "',Manifact='" + Manifacturer + "',Category='" + Category + "',Amount='" + Amount + "',BuyPrice='" + BuyPrice + "',SalePrice='"+SalePrice+"' where ID='" + ID + "'";
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
        public void searchProduct(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT * FROM Inventory WHERE ID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT * FROM Inventory WHERE Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
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
        public void loadData(DataGridView Grid, string loadtype)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "select * from Inventory";
            if (loadtype == "nm")
            {
                CommandText = "select Name,Model from Inventory";
            }
            else if (loadtype == "inm")
            {
                CommandText = "select ID,Name,Model from Inventory";
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
