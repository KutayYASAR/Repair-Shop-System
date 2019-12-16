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

        List<string> ConfCode = new List<string>();
        string a;
        public Register()
        {   
            ConfCode.Add("123");
            InitializeComponent();
        }

        private void BTRegister_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
            string query = @"insert into Employee (Name,Surname,Email,Password,Phone) values(@Name,@Surname,@Email,@Password,@Phone)";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            if ((TBName.Text.Trim()!="" && TBName.Text.Trim()!="Ad")&&
                (TBSurname.Text.Trim() != "" && TBSurname.Text.Trim() != "Soyad") &&
                (TBMail.Text.Trim() != "" && TBMail.Text.Trim() != "Mail") &&
                (TBPassword.Text.Trim() != "" && TBPassword.Text.Trim() != "Password") &&
                (TBPhone.Text.Trim() != "" && TBPhone.Text.Trim() != "Telefon")&&
                (TBConfirm.Text.Trim() != "" && TBConfirm.Text.Trim() != "Confirmation Code"))
            {
                SQLiteCommand cm = new SQLiteCommand("Select Conf from Confirmation", con);
                con.Open();
                SQLiteDataReader dr = cm.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    a = dr.GetString(0);
                    ConfCode.Add(a);
                    
                }
                dr.Close();
                con.Close();
                if (!ConfCode.ToArray().Contains<string>(TBConfirm.Text.Trim()))
                {
                    lblMsg.ForeColor = Color.DarkRed;
                    lblMsg.Text = "Wrong Conf. Code";
                }
                else
                {
                    cmd.Parameters.Add(new SQLiteParameter("@Name", TBName.Text.Trim()));
                    cmd.Parameters.Add(new SQLiteParameter("@Surname", TBSurname.Text.Trim()));
                    cmd.Parameters.Add(new SQLiteParameter("@Email", TBMail.Text.Trim()));
                    cmd.Parameters.Add(new SQLiteParameter("@Password", TBPassword.Text.Trim()));
                    cmd.Parameters.Add(new SQLiteParameter("@Phone", TBPhone.Text.Trim()));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    TBName.Clear(); TBSurname.Clear(); TBMail.Clear(); TBPassword.Clear(); TBPhone.Clear();
                    lblMsg.ForeColor = Color.DarkGreen;
                    lblMsg.Text = "Succesfull Registration";
                }
            }
            
            else
            {
                lblMsg.ForeColor = Color.DarkRed;
                lblMsg.Text = "Please fill all areas.";
            }
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

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
