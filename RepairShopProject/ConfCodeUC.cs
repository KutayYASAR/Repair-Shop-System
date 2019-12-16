using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class ConfCodeUC : UserControl
    {
        string cardCode;
        public ConfCodeUC()
        {
            InitializeComponent();
        }

        private void ConfCodeUC_Load(object sender, EventArgs e)
        {
            var m = new Manager();
            m.loadconf(DGConf);
            var g = new GiftCard();
            g.loadData(DGGift);
        }

        private void BTCAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new Manager();
                m.addConf(TBConf.Text.Trim());
                m.loadconf(DGConf);
            }
            catch (Exception)
            {

                MessageBox.Show("Fill al areas");
            }
        }

        private void BTCRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var m = new Manager();
                m.removeConf(TBConf.Text.Trim());
                m.loadconf(DGConf);
            }
            catch (Exception)
            {

                MessageBox.Show("Fill al areas");
            }
        }

        private void DGConf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBConf.Text = DGConf.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void GiftAdd_Click(object sender, EventArgs e)
        {
            var g = new GiftCard();
            g.addCard(int.Parse(TBBalance.Text.Trim()));
            g.loadData(DGGift);
        }

        private void GiftRemove_Click(object sender, EventArgs e)
        {
            var g = new GiftCard();
            try
            {
                g.removeCard(cardCode);
                g.loadData(DGGift);
            }
            catch (Exception)
            {
                MessageBox.Show("Choose the card.");
            }
            
        }

        private void EditGift_Click(object sender, EventArgs e)
        {
            var g = new GiftCard();
            try
            {
                g.editBalance(int.Parse(TBBalance.Text.Trim()), cardCode);
                g.loadData(DGGift);
            }
            catch (Exception)
            {
                MessageBox.Show("Choose the card.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBBalance.Text = "";
            TBConf.Text = "";
        }

        private void DGGift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var g = new GiftCard();
            cardCode = DGGift.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBBalance.Text = g.showBalance(cardCode).ToString();
        }
    }
}
