using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class OrderHistory : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        public OrderHistory()
        {
            InitializeComponent();
            Da = new DataAccess();
            getAllData();
            orderDetails.Visible = false;
        }

        private void getAllData()
        {
            if (LoggedUser.role == "Employee")
            {
                this.Sql = @"SELECT * FROM orders WHERE employeeId='" + LoggedUser.id + "'";
            }
            else
            {
                this.Sql = @"SELECT * FROM orders";
            }
            Dt = Da.ExecuteQueryTable(this.Sql); ;
            orderHistoryGrid.DataSource = Dt;
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            getAllData();
        }
        private int rowIndex = 0;

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                string id = this.orderHistoryGrid.CurrentRow.Cells["orderId"].Value.ToString();
                string date = this.orderHistoryGrid.CurrentRow.Cells["orderDate"].Value.ToString();
                string emp = this.orderHistoryGrid.CurrentRow.Cells["employeeId"].Value.ToString();
                string pay = this.orderHistoryGrid.CurrentRow.Cells["paymentId"].Value.ToString();
                string product = this.orderHistoryGrid.CurrentRow.Cells["productId"].Value.ToString();


                this.Sql = @"SELECT * FROM payments WHERE payId = '" + pay + "';";
                Dt = Da.ExecuteQueryTable(this.Sql);

                Graphics g = e.Graphics;

                Font titleFont = new Font("Arial", 22, FontStyle.Bold);
                Font headerFont = new Font("Arial", 17, FontStyle.Bold);
                Font bodyFont = new Font("Arial", 14);
                Font footerFont = new Font("Arial", 12, FontStyle.Italic);
                Brush blackBrush = Brushes.Black;

                float x = 50;
                float y = 40;
                float lineHeight = 25;

                // g.DrawImage(Image.FromFile("logo.png"), x, y, 100, 50);
                // y += 60;

                g.DrawString("RECEIPT", titleFont, blackBrush, x, y);
                y += lineHeight + 10;

                g.DrawLine(Pens.Black, x, y, x + 500, y);
                y += 10;

                g.DrawString("Restaurant Management System", headerFont, blackBrush, x, y); y += lineHeight;
                g.DrawString("Kuratoli, Kuril, Dhaka", bodyFont, blackBrush, x, y); y += lineHeight;
                g.DrawString("Phone: +8801885266952", bodyFont, blackBrush, x, y); y += lineHeight + 10;

                g.DrawString("Order ID #: " + id, bodyFont, blackBrush, x, y); y += lineHeight;
                g.DrawString("Payment ID #: " + pay, bodyFont, blackBrush, x, y); y += lineHeight;
                g.DrawString("Order Date #: " + date, bodyFont, blackBrush, x, y); y += lineHeight;
                g.DrawString("Order Taken By #: " + emp, bodyFont, blackBrush, x, y); y += lineHeight;
                g.DrawString("Print Date: " + DateTime.Now.ToString(), bodyFont, blackBrush, x, y); y += lineHeight + 10;

                g.DrawString("Payment Method: " + Dt.Rows[0][2], bodyFont, blackBrush, x, y); y += lineHeight + 10;

                Rectangle box = new Rectangle((int)x, (int)y, 600, 500);
                g.DrawRectangle(Pens.Black, box);
                y += 10;
                g.DrawString("Item: ", bodyFont, blackBrush, x + 10, y); y += lineHeight;
                g.DrawString(showItem(id), bodyFont, blackBrush, x + 10, y); y += lineHeight;

                y = box.Bottom + 20;

                g.DrawString("Total: " + Dt.Rows[0][1], new Font("Arial", 13, FontStyle.Bold), blackBrush, x, y); y += lineHeight;
                g.DrawString("Status: PAID", new Font("Arial", 12, FontStyle.Bold), Brushes.Green, x, y); y += lineHeight + 20;

                g.DrawString("Thank you for your order!", footerFont, blackBrush, x, y); y += lineHeight;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private string showItem(string id)
        {
            string print = "";

            string product = this.orderHistoryGrid.CurrentRow.Cells["productId"].Value.ToString();
            string[] allproduct = product.Split('\n');

            foreach (string item in allproduct) {
                string[] part = item.Split(',');
                if (part.Length == 5)
                {
                    print += part[0] + ",\n";
                    print += ("    Name: "+part[1] + "\n    Qty: " + part[2] + "\n    Size: " + part[3] + "\n    Prices: " + part[4] + "\n");
                }
            }
            
            return print;
        }
        public event EventHandler orderSeclected = null;
        private void OrderHistoryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            orderDetails.Visible = true;
            string id = this.orderHistoryGrid.CurrentRow.Cells["orderId"].Value.ToString();
            string date = this.orderHistoryGrid.CurrentRow.Cells["orderDate"].Value.ToString();
            string emp = this.orderHistoryGrid.CurrentRow.Cells["employeeId"].Value.ToString();
            string pay = this.orderHistoryGrid.CurrentRow.Cells["paymentId"].Value.ToString();
            string product = this.orderHistoryGrid.CurrentRow.Cells["productId"].Value.ToString();

            orderIdBox.Text = id;
            paymentIdBox.Text = pay;
            orderByBox.Text = emp;
            dateBox.Text = date;

            this.Sql = "select payAmount,payType from payments where payId='" + pay + "';";
            Dt = Da.ExecuteQueryTable(this.Sql);
            amountBox.Text = Dt.Rows[0]["payAmount"].ToString();
            payTypeBox.Text = Dt.Rows[0]["payType"].ToString();

            if (pay == "")
            {
                statusBox.Text = "Not Paid";
                statusBox.ForeColor = Color.Red;
            }
            else
            {
                statusBox.Text = "Paid";
                statusBox.ForeColor = Color.Green;
            }


            string[] items = product.Split('\n');

            foreach (string item in items)
            {
                if (item != null)
                {
                    string[] parts = item.Split(',');

                    if (parts.Length == 5)
                    {
                        allProductGrid.Rows.Add(parts[4], parts[3], parts[2], parts[1], parts[0]);
                    }
                }
                
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            allProductGrid.Rows.Clear();
            orderDetails.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            printDocument.PrintController = new StandardPrintController();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}
