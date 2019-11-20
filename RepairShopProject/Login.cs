﻿using System;
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
    public partial class Login : Form
    {
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
                SQLiteConnection conc = new SQLiteConnection(@"data source = C:\Users\Kutay\Desktop\RepairShop.db");
                SQLiteCommand cmd = new SQLiteCommand("SELECT `Email`, `Password` FROM `Employee` WHERE `Email` = '" + TBMail.Text.Trim() + "' AND `Password` = '" + TBPass.Text.Trim() + "'", conc);
                conc.Open();
                SQLiteDataReader dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if(count == 1)
                {
                    this.Hide();
                    var m = new MainScreen();
                    m.Closed += (s, args) => this.Close();
                    m.StartPosition = FormStartPosition.Manual;
                    m.Location = new Point(this.Location.X, this.Location.Y);
                    m.Show();
                }
                else if (count == 0)
                {
                    lblMsg.ForeColor = Color.DarkRed;
                    lblMsg.Text = "Email or Password is WRONG!";
                }
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
    }
}
