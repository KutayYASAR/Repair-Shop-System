using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace RepairShopProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void BTRegister_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
            string query = @"insert into Employee (Name,Surname,Email,Password,Phone) values(@Name,@Surname,@Email,@Password,@Phone)";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.Add(new SQLiteParameter("@Name", TBName.Text.Trim()));
            cmd.Parameters.Add(new SQLiteParameter("@Surname", TBSurname.Text.Trim()));
            cmd.Parameters.Add(new SQLiteParameter("@Email", TBMail.Text.Trim()));
            cmd.Parameters.Add(new SQLiteParameter("@Password", TBPassword.Text.Trim()));
            cmd.Parameters.Add(new SQLiteParameter("@Phone", TBPhone.Text.Trim()));
            con.Open();
            cmd.ExecuteNonQuery();
            TBName.Clear();TBSurname.Clear();TBMail.Clear();TBPassword.Clear();TBPhone.Clear();
            lblMsg.ForeColor = Color.DarkGreen;
            lblMsg.Text = "Succesfull Registration";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Closed += (s, args) => this.Close();
            l.StartPosition = FormStartPosition.Manual;
            l.Location = new Point(this.Location.X, this.Location.Y);
            l.Show();
        }

        private void TBName_Click(object sender, EventArgs e)
        {
            TBName.Clear();
        }

        private void TBSurname_Click(object sender, EventArgs e)
        {
            TBSurname.Clear();
        }

        private void TBPhone_Click(object sender, EventArgs e)
        {
            TBPhone.Clear();
        }

        private void TBMail_Click(object sender, EventArgs e)
        {
            TBMail.Clear();
        }

        private void TBPassword_Click(object sender, EventArgs e)
        {
            TBPassword.Clear();
        }

        private void TBConfirm_Click(object sender, EventArgs e)
        {
            TBConfirm.Clear();
        }
    }
}
