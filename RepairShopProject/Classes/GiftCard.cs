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
    class GiftCard
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        string giftCardCode;
        int giftAmount;
        int giftCardBalance;
        

        public string GiftCardCode { get => giftCardCode; set => giftCardCode = value; }
        public int GiftAmount { get => giftAmount; set => giftAmount = value; }
        public int GiftCardBalance { get => giftCardBalance; set => giftCardBalance = value; }

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
            string CommandText = "select * from GiftCards";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();

        }
        public int showBalance(string code)
        {
            setConnection();
            con.Open();
            int balance = 0;
            string txt = "select Balance from GiftCards where Code = '"+code+"'";
            SQLiteCommand cm = new SQLiteCommand(txt,con);
            SQLiteDataReader reader = cm.ExecuteReader();
            while (reader.Read())
            {
                balance = reader.GetInt32(0);
            }
            return balance;
        }
        public void editBalance(int balance,string code)
        {
            string txtQuery = "Update GiftCards set Balance = '" + balance + "' where Code = '" + code + "'";
            executeQuery(txtQuery);
        }
        public void addCard(int balance)
        {
            var code = RandomString(16);
            string txtQuery = "insert into GiftCards (Code,Balance)values('" + code + "','" + balance + "')";
            executeQuery(txtQuery);
            
        }
        public void removeCard(string Code)
        {
            string txtQuery = "delete from Giftcards where Code='" + Code + "'";
            executeQuery(txtQuery);
            
        }
        private static string RandomString(int length)
        {
            var random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
