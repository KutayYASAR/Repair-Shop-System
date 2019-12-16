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
    public partial class ProfitUC : UserControl
    {
        int saleprice;
        int buyprice;
        int profit;
        int count = 0;
        bool cleared = false;
        public ProfitUC()
        {
            InitializeComponent();
            
        }

        private void DGAppo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var p = new Payment();
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = DTApp.Value.ToString("yyyy-MM-dd");
            p.searchbyDate(date1, date2, DGAppo);
            saleprice = p.returnSale(date1, date2);
            buyprice = p.returnBuy(date1, date2);
            profit = p.returnProfit(date1, date2);
            count = p.returnCount(date1, date2);
            TBSale.Text = count.ToString();
            TBBuyPr.Text = buyprice.ToString();
            TBProfit.Text = profit.ToString();
            TBSalePr.Text = saleprice.ToString();
        }

        private void DTApp_ValueChanged(object sender, EventArgs e)
        {
            var p = new Payment();
            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = DTApp.Value.ToString("yyyy-MM-dd");
            p.searchbyDate(date1, date2, DGAppo);
            saleprice = p.returnSale(date1, date2);
            buyprice = p.returnBuy(date1, date2);
            profit = p.returnProfit(date1, date2);
            count = p.returnCount(date1, date2);
            TBSale.Text = count.ToString();
            TBBuyPr.Text = buyprice.ToString();
            TBProfit.Text = profit.ToString();
            TBSalePr.Text = saleprice.ToString();
        }

        private void ProfitUC_Load(object sender, EventArgs e)
        {
            var p = new Payment();
            p.loadData(DGAppo, "select * from Payments");
            
        }

        private void BTAClear_Click(object sender, EventArgs e)
        {
            var p = new Payment();
            p.loadData(DGAppo, "select * from Payments");
            TBSale.Text = "";
            TBBuyPr.Text = "";
            TBProfit.Text = "";
            TBSalePr.Text = "";
        }
    }
}
