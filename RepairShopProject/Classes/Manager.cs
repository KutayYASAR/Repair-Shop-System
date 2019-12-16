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
    class Manager: Employee
    {
        public void loadconf(DataGridView Grid)
        {
            setConnection();
            con.Open();
            cmd = con.CreateCommand();
            string CommandText = "select * from Confirmation";
            DB = new SQLiteDataAdapter(CommandText, con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Grid.DataSource = DT;
            con.Close();
        }
        public void addConf(string conf)
        {
            string txtQuery = "insert into Confirmation (Conf)values('" + conf + "')";
            executeQuery(txtQuery);
        }
        public void removeConf(string conf)
        {
            string txtQuery = "delete from Confirmation where conf ='" + conf + "'";
            executeQuery(txtQuery);
        }
        public void promoteEmployee(int id)
        {
            string txtQuery = "update Employee set isManager = '" + 1 + "' where ID = '"+id+"'";
            executeQuery(txtQuery);
        }
    }
}
