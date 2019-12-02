using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using RepairShopProject.Classes;

namespace RepairShopProject.Classes
{
    class Payment
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int ID;
        string date;
        int employeeID;
        int customerID;
        int productName;
        int price;

        public int ID1 { get => ID; set => ID = value; }
        public string Date { get => date; set => date = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public int ProductName { get => productName; set => productName = value; }
        public int Price { get => price; set => price = value; }
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
            string CommandText = "select * from Tickets";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void loadData(DataGridView Grid, string query)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = query;
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }

        public void searchPayment(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                if (input.Contains(".") || input.Contains("/"))
                {
                    CommandText = "SELECT * FROM Payments WHERE Date LIKE'%" + input + "%'";
                }
                else
                {
                    CommandText = "SELECT * FROM Payments WHERE EmployeeID LIKE'%" + input + "%'";
                }
            }
            else
            {
                CommandText = "SELECT Payments.ID,Date,EmployeeID,CustomerID,Price FROM Tickets INNER JOIN Customer ON Customer.ID = Payments.CustomerID WHERE Customer.Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }

        public void removeTicket(int ID, DataGridView Grid)
        {
            string txtQuery = "delete from Payments where ID='" + ID + "'";
            executeQuery(txtQuery);
            
          
        }
        public void addPayment(string Date,int EmployeeID,int CustomerID,int TicketID,int Price,string Method)
        {
            string txtQuery = "insert into Payments (Date,EmployeeID,CustomerID,Price,Method)values('" + Date+ "','" + EmployeeID+ "','" + CustomerID+ "','" + Price+ "','" + Method+ "')";
            string txtQuery1 = "delete from Product_To_Ticket where TicketID = '" + TicketID + "'";
            string txtQuery2 = "delete from Tickets where ID = '" + TicketID + "'";
            executeQuery(txtQuery);
            executeQuery(txtQuery1);
            executeQuery(txtQuery2);
            
        }
       public int totalPrice(int input)
        {
            setConnection();
            con.Open();
            string txtQuery = "Select SUM(SalePrice) FROM Inventory Where (Inventory.ID in(Select ProductID from Product_To_Ticket where TicketID ='" + input + "'))";
            SQLiteCommand cmd = new SQLiteCommand(txtQuery, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            int val = 0;
            while (reader.Read())
            {
                val = reader.GetInt32(0);
            }
            reader.Close();
            con.Close();
            return val;
        }
        
        public void addPaymentOption(string input)
        {
            string txtQuery = "insert into PaymentM (Method)values('" + input + "')";
            executeQuery(txtQuery);
        }
        public void removePaymentOption(string input)
        {
            string txtQuery = "delete from PaymentM where Method = '" + input + "'";
            executeQuery(txtQuery);
        }
        public int applyDiscount(int val,int id,string type)
        {
             int price = totalPrice(id);
            int newTotal;
            if (type == "Precentage")
            {
                int disc = (val*price / 100);
                newTotal = price - disc;
                return newTotal;
            }
            else if (type =="Cash")
            {
                newTotal = price - val;
                return newTotal;
            }
            else
            {
                return price;
            }
        }
    }
}
