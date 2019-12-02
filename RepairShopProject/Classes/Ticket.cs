using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace RepairShopProject.Classes
{
    class Ticket
    {
        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int id;
        int customerId;
        string startDate;
        string endEstimate;
        string info;
        string status;
        string usedParts;

        public int Id { get => id; set => id = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string EndEstimate { get => endEstimate; set => endEstimate = value; }
        public string Info { get => info; set => info = value; }
        public string Status { get => status; set => status = value; }
        public string UsedParts { get => usedParts; set => usedParts = value; }

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
        public void loadData(DataGridView Grid,string query)
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
        public void searchTicket(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT * FROM Tickets WHERE ID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT Tickets.ID,CustomerID,StartDate,EndEstimate,Info,Status FROM Tickets INNER JOIN Customer ON Customer.ID = Tickets.CustomerID WHERE Customer.Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void searchTicketOutside(string input, DataGridView Grid)
        {
            string CommandText;
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            if (input.Contains("0") || input.Contains("1") || input.Contains("2") || input.Contains("3") || input.Contains("4") || input.Contains("5") || input.Contains("6") || input.Contains("7") || input.Contains("8") || input.Contains("9"))
            {
                CommandText = "SELECT ID,CustomerID,Info FROM Tickets WHERE ID LIKE'%" + input + "%'";
            }
            else
            {
                CommandText = "SELECT Tickets.ID,CustomerID,Info FROM Tickets INNER JOIN Customer ON Customer.ID = Tickets.CustomerID WHERE Customer.Name LIKE'%" + input + "%'";
            }
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }

        public void updateTicket(string startDate, string endDate, string Info, string Status, int CustomerID, int ID, DataGridView Grid)
        {
            string txtQuery = "update Tickets set StartDate='" + startDate + "',EndEstimate='" + endDate + "',Info='" + Info + "',Status='" + Status + "',CustomerID='"+CustomerID+"' where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void removeTicket(int ID, DataGridView Grid, DataGridView Grid2)
        {
            string txtQuery = "delete from Tickets where ID='" + ID + "'";
            executeQuery(txtQuery);
            loadData(Grid);
            string txtQuery1 = "delete from Product_To_Ticket where TicketID = '" + ID + "'";
            executeQuery(txtQuery1);
        }
        public void addTicket(string startDate, string endDate, string Info, string Status,int CustomerID, DataGridView Grid)
        {
            string txtQuery = "insert into Tickets (StartDate,EndEstimate,Info,Status,CustomerID)values('" + startDate + "','" + endDate + "','" + Info + "','" + Status + "','"+CustomerID+"')";
            executeQuery(txtQuery);
            loadData(Grid);
        }
        public void addPTD (int TicketID,int ProductID)
        {
            string txtQuery = "insert into Product_To_Ticket (ProductID,TicketID)values('" + ProductID + "','" + TicketID + "')";
            executeQuery(txtQuery);
        }
        public void removePTD(int TicketID, string Product)
        {
            string txtQuery = "delete from Product_To_Ticket where (ProductID in(select ID from Inventory where Name='"+Product+"')) and TicketID='"+TicketID+"'";
            executeQuery(txtQuery);
        }
        public void used(int TicketID, DataGridView Grid)
        {
            string txtQuery = "Select Name From Inventory INNER JOIN  Product_To_Ticket ON ID = Product_To_Ticket.ProductID WHERE Product_To_Ticket.TicketID ='" + TicketID + "' ";
            loadData(Grid,txtQuery);
        }
    }
}
