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
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class Login : Form
    {
        public static int EmployeeID;
        Register r = null;
        public Login()
        {
            InitializeComponent();
        }
        private void BTRegister_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            if (r == null)
            {
                r = new Register();
            }
            r.Closed += (s, args) => this.Close();
            r.StartPosition = FormStartPosition.Manual;
            r.Location =new Point(this.Location.X, this.Location.Y);
            r.Show();
            
        }

        private void BTLogin_Click(object sender, EventArgs e)
        { 
            try
            {
                var em = new Employee();
                SQLiteConnection conc = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
                
                if (em.Login(TBMail.Text.Trim(),TBPass.Text.Trim())==1)
                {
                    this.Hide();
                    var m = new newMainScreen();
                    m.Closed += (s, args) => this.Close();
                    m.StartPosition = FormStartPosition.CenterScreen;
                    m.Location = new Point(this.Location.X, this.Location.Y);
                    m.Show();
                    
                }
                else if(em.Login(TBMail.Text.Trim(), TBPass.Text.Trim()) == 2)
                {
                    this.Hide();
                    var m = new ManagerScreen();
                    m.Closed += (s, args) => this.Close();
                    m.StartPosition = FormStartPosition.CenterScreen;
                    m.Location = new Point(this.Location.X, this.Location.Y);
                    m.Show();
                }
                else
                {
                    lblMsg.ForeColor = Color.DarkRed;
                    lblMsg.Text = "Email or Password is WRONG!";
                }

                SQLiteCommand cm = new SQLiteCommand("Select ID from Employee where Email = '" + TBMail.Text.Trim() + "' AND Password = '" + TBPass.Text.Trim() + "'", conc);
                conc.Open();
                SQLiteDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    EmployeeID = dr.GetInt32(0);
                }
                dr.Close();
                conc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void TBMail_Click(object sender, EventArgs e)
        {
            TBMail.Clear();
        }

        private void TBPass_Click(object sender, EventArgs e)
        {
            TBPass.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
