using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairShopProject.Classes;

namespace RepairShopProject
{
    public partial class PaymentUC : UserControl
    {
        
        int id;
        string DiscountType;
        string Texttoprint;
        int BPrice;
        public PaymentUC()
        {
            InitializeComponent();
            
        }
        private void textforprint()
        {
            try
            {
                
                var p = new Payment();
                StreamReader reader = new StreamReader(@"C:\Users\Kutay\Desktop\invoice.txt");
                string text = reader.ReadToEnd();
                string name = DGCustomer.Rows[0].Cells[1].Value.ToString();
                string surmane = DGCustomer.Rows[0].Cells[2].Value.ToString();
                string total = TBPTotal.Text.Trim() + " TL";
                

                Texttoprint = string.Format(text, name, surmane, total);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            

        }
        private void PaymentUC_Load(object sender, EventArgs e)
        {
            var t = new Ticket();
            var p = new Payment();
            var p2 = new Payment();
            string txtQuery = "SELECT ID,CustomerID,Info FROM Tickets";
            p.loadData(DGPM, "SELECT * FROM PaymentM");
            t.loadData(DGTicket, txtQuery);
            p2.loadData(DGPD, "Select * FROM PaymentD");
        }

        private void TBPCSearch_TextChanged(object sender, EventArgs e)
        {
            
                var t = new Ticket();
            t.searchTicketOutside(TBPCSearch.Text.Trim(), DGTicket);
            
        }

        private void DGTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                var c = new Customer();
                var t = new Ticket();
                var p = new Payment();
                c.searchCustomerOutside(DGTicket.Rows[e.RowIndex].Cells[1].Value.ToString(), DGCustomer);
                t.used(int.Parse(DGTicket.Rows[e.RowIndex].Cells[0].Value.ToString()), DGUsed);
                TBPTotal.Text = p.totalPrice(int.Parse(DGTicket.Rows[e.RowIndex].Cells[0].Value.ToString())).ToString();
                id = int.Parse(DGTicket.Rows[e.RowIndex].Cells[0].Value.ToString());
                BPrice = p.totalBPrice(int.Parse(DGTicket.Rows[e.RowIndex].Cells[0].Value.ToString()));
                Console.WriteLine(BPrice);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void BTPayClear_Click(object sender, EventArgs e)
        {
            TBPCSearch.Text = "";
            TBPDis.Text = "0";
            TBPDisam.Text = "";
            TBPGift.Text = "";
            TBPMethod.Text = "";
            TBPTotal.Text = "";
            DGCustomer.DataSource = null;
            DGUsed.DataSource = null;
            var t = new Ticket();
            string txtQuery = "SELECT ID,CustomerID,Info FROM Tickets";
            t.loadData(DGTicket, txtQuery);

        }

        private void DGPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBPMethod.Text = DGPM.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void DGPD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            TBPDisam.Text = DGPD.Rows[e.RowIndex].Cells[0].Value.ToString();
            DiscountType = TBPDisam.Text;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            textforprint();
            e.Graphics.DrawString(Texttoprint,new Font("Times New Roman",14,FontStyle.Bold),Brushes.Black,new PointF(100,100));
        }

        private void BTPPay_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TBPMethod.Text == "") || (TBPMethod.Text.Contains(" ")))
                {
                    MessageBox.Show("Choose the payment method.");
                }
                else if((TBPMethod.Text == "GiftCard") || (TBPMethod.Text.Contains("Gift")))
                {
                    var g = new GiftCard();
                    try
                    {
                        int balance = g.showBalance(TBPGift.Text.Trim());
                        if (balance <int.Parse(TBPTotal.Text.Trim()))
                        {
                            MessageBox.Show("Not enough balance or wrong Code!");
                        }
                        else
                        {
                            g.editBalance((balance - int.Parse(TBPTotal.Text.Trim())), TBPGift.Text.Trim());
                            var p = new Payment();

                            p.addPayment(DateTime.Now.ToString("yyyy-MM-dd"), Login.EmployeeID,
                                int.Parse(DGCustomer.Rows[0].Cells[0].Value.ToString()), id, BPrice,
                                int.Parse(TBPTotal.Text.Trim()), (int.Parse(TBPTotal.Text.Trim()) - BPrice), TBPMethod.Text);
                            var t = new Ticket();
                            var p1 = new Payment();
                            var p2 = new Payment();
                            string txtQuery = "SELECT ID,CustomerID,Info FROM Tickets";
                            p1.loadData(DGPM, "SELECT * FROM PaymentM");
                            t.loadData(DGTicket, txtQuery);
                            p2.loadData(DGPD, "Select * FROM PaymentD");


                            printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                            Random random = new Random();
                            int r = random.Next(0, 9999);
                            string file = DGCustomer.Rows[0].Cells[1].Value.ToString() + DGCustomer.Rows[0].Cells[2].Value.ToString() + r.ToString();
                            string directory = @"C:\Users\Kutay\Desktop\Reciepts";
                            printDocument1.PrinterSettings.PrintToFile = true;
                            printDocument1.PrinterSettings.PrintFileName = Path.Combine(directory, file + ".pdf");
                            printDocument1.Print();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wrong giftcard");
                    }
                     
                }
                else
                {
                    var p = new Payment();
                    
                    p.addPayment(DateTime.Now.ToString("yyyy-MM-dd"), Login.EmployeeID,
                        int.Parse(DGCustomer.Rows[0].Cells[0].Value.ToString()), id,BPrice,
                        int.Parse(TBPTotal.Text.Trim()), (int.Parse(TBPTotal.Text.Trim())-BPrice), TBPMethod.Text);
                    var t = new Ticket();
                    var p1 = new Payment();
                    var p2 = new Payment();
                    string txtQuery = "SELECT ID,CustomerID,Info FROM Tickets";
                    p1.loadData(DGPM, "SELECT * FROM PaymentM");
                    t.loadData(DGTicket, txtQuery);
                    p2.loadData(DGPD, "Select * FROM PaymentD");


                    printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    Random random = new Random();
                    int r = random.Next(0, 9999);
                    string file = DGCustomer.Rows[0].Cells[1].Value.ToString() + DGCustomer.Rows[0].Cells[2].Value.ToString() + r.ToString() ;
                    string directory = @"C:\Users\Kutay\Desktop\Reciepts";
                    printDocument1.PrinterSettings.PrintToFile = true;
                    printDocument1.PrinterSettings.PrintFileName = Path.Combine(directory, file + ".pdf");
                    printDocument1.Print();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void TBPDis_TextChanged(object sender, EventArgs e)
        {
            var p = new Payment();
            if ((TBPDis.Text != "") && !(TBPDis.Text.Contains(" ")))
                {
                int newTotal = p.applyDiscount(int.Parse(TBPDis.Text), id, DiscountType);
                TBPTotal.Text = newTotal.ToString(); 
                }
            else
            {
                MessageBox.Show("Choose discount type please");
            }
        }
    }
}
