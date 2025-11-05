using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RestaurantManagement
{
    public partial class AllProductShow : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        private Product p;

        public AllProductShow()
        {
            InitializeComponent();
            Da = new DataAccess();
            getAllProduct();
            givediscountCodeBtn.Visible = false;
            discountAmountBox.Visible = false;
        }

        private void addProduct(string id, string name, string price,int tax, int stock, string category, string img, string status)
        {
            try
            {
                p = new Product()
                {
                    proId = id,
                    proName = name,
                    proPrice = price,
                    proStock = stock,
                    proCategory = category,
                    proImage = img,
                    proStatus = status,
                };

                showProductFlowLayout.Controls.Add(p);

                p.selected += (sender, args) =>
                {
                    Product selectedProduct = (Product)sender;
                    string sql = @"SELECT * FROM products WHERE productName = '" + selectedProduct.proName + "';";

                    Ds = Da.ExecuteQuery(sql);
                    if (selectedProduct.proQuantity != 0)
                    {
                        if (Convert.ToInt32(Ds.Tables[0].Rows[0][4]) >= selectedProduct.proQuantity)
                        {
                            float total = selectedProduct.proQuantity * float.Parse(selectedProduct.proPrice);

                            bool flag = false;

                            foreach (DataGridViewRow row in dgvCart.Rows)
                            {
                                if (row.Cells["productId"].Value != null &&
                                    row.Cells["productId"].Value.ToString() == selectedProduct.proId)
                                {
                                    row.Cells["productId"].Value = selectedProduct.proId;
                                    row.Cells["productName"].Value = selectedProduct.proName;
                                    row.Cells["Quantity"].Value = selectedProduct.proQuantity;
                                    row.Cells["productPreferences"].Value = selectedProduct.proPreferences;
                                    row.Cells["Total"].Value = total;
                                    flag = true;
                                }
                            }

                            if (!flag)
                            {
                                dgvCart.Rows.Add(selectedProduct.proId, selectedProduct.proName, selectedProduct.proQuantity, selectedProduct.proPreferences, total);
                            }
                            updateSemiPrice();
                            updateTotalPrice();

                        }
                        else
                        {
                            MessageBox.Show("You have limited stock.\n" + "Stock: " + Ds.Tables[0].Rows[0][4]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select valid number of item");
                    }
                };
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }

        }
        private void updateProductStock()
        {
            try
            {
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells["productId"].Value != null)
                    {
                        string proName = row.Cells["productName"].Value.ToString();
                        string proId = row.Cells["productId"].Value.ToString();

                        this.Sql = @"SELECT * FROM products WHERE productName = '" + proName + "';";

                        DataSet Ds = Da.ExecuteQuery(this.Sql);

                        int value = Convert.ToInt32(row.Cells["Quantity"].Value);
                        int newStock = Convert.ToInt32(Ds.Tables[0].Rows[0]["productStock"]) - value;

                        string updatesql = @"UPDATE products SET productStock='" + newStock + "'" +
                                        "WHERE productId='" + proId + "'";
                        Da.ExecuteUpdateQuery(updatesql);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }

        }

        private void updateSemiPrice()
        {
            double totalprice = 0;
            foreach(DataGridViewRow row in dgvCart.Rows)
            {
                double price = Convert.ToDouble(row.Cells["Total"].Value);
                totalprice += price;
            }
            semiTotalBox.Text = totalprice.ToString();
        }
        private void updateTotalPrice()
        {
            double semiprice = Convert.ToDouble(semiTotalBox.Text);
            double discount;
      
            discount = Convert.ToDouble(discountAmountBox.Text);
            double tax = Convert.ToDouble(totalTaxBox.Text);

            double total = (semiprice + tax) - discount;
            totalAmountBox.Text = total.ToString();
        }
        private void updateTax()
        {
            try
            {
                double totalTax = 0;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;
                    string proId = row.Cells["productId"].Value.ToString();

                    string sql = @"SELECT * FROM products WHERE productId = '" + proId + "';";

                    Ds = Da.ExecuteQuery(sql);

                    int total = Convert.ToInt32(row.Cells["Total"].Value);
                    double tax = (Convert.ToDouble(Ds.Tables[0].Rows[0]["productTax"]) / 100.0) * total;

                    totalTax += tax;

                    totalTaxBox.Text = totalTax.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        public void getAllProduct(string sql = @"SELECT * FROM products WHERE productStatus='Available'")
        {
            try
            {
                Dt = Da.ExecuteQueryTable(sql); ;
                if (showProductFlowLayout == null)
                {
                    MessageBox.Show("FlowLayoutPanel is not initialized.");
                    return;
                }

                showProductFlowLayout.Controls.Clear();
                foreach (DataRow r in Dt.Rows)
                {
                    string id = r["productId"].ToString();
                    string name = r["productName"].ToString();
                    string price = r["productPrice"].ToString();
                    int tax = int.Parse(r["productTax"].ToString());
                    int stock = int.Parse(r["productStock"].ToString());
                    string category = r["productCategory"].ToString();
                    string img = r["productImage"].ToString();
                    string status = r["productStatus"].ToString();

                    addProduct(id, name, price, tax, stock, category, img, status);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
       
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from products where productName like '" + this.searchBox.Text + "%';";
            this.getAllProduct(this.Sql);
        }

        private void clearAll()
        {
            semiTotalBox.Text = "0";
            totalAmountBox.Text = "0";
            totalTaxBox.Text = "0";
            givediscountCodeBtn.Visible = false;
            discountBtn.Visible = true;
            dicountCodeBox.Visible = true;
            discountAmountBox.Visible = false;
            ClaimedDiscount.id = "";
            dgvCart.Rows.Clear();
            getAllProduct();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearAll();  
        }
        private void DicountOparation()
        {
            try
            {
                string code = dicountCodeBox.Text.ToUpper();
                this.Sql = @"SELECT * FROM discounts WHERE disCode = '" + code + "';";

                Ds = Da.ExecuteQuery(this.Sql);

                if (Ds.Tables[0].Rows.Count == 1)
                {
                    DateTime today = DateTime.Now;
                    DateTime endDate = DateTime.Parse(Ds.Tables[0].Rows[0][8].ToString());

                    if (endDate > today)
                    {
                        if (Convert.ToInt32(Ds.Tables[0].Rows[0][4]) > 0)
                        {
                            decimal total = Convert.ToDecimal(semiTotalBox.Text);
                            if (total >= Convert.ToDecimal(Ds.Tables[0].Rows[0][6]))
                            {
                                decimal discount = total * (Convert.ToDecimal(Ds.Tables[0].Rows[0][3]) / 100);
                                if (discount > Convert.ToDecimal(Ds.Tables[0].Rows[0][5]))
                                {
                                    discountAmountBox.Text = Convert.ToDecimal(Ds.Tables[0].Rows[0][5]).ToString();
                                }
                                else
                                {
                                    discountAmountBox.Text = discount.ToString();
                                }
                                ClaimedDiscount.id = (Ds.Tables[0].Rows[0][0]).ToString();
                                ClaimedDiscount.limit = Convert.ToInt32(Ds.Tables[0].Rows[0][4]);
                                discountAmountBox.Visible = true;
                                discountBtn.Visible = false;
                                dicountCodeBox.Visible = false;
                                givediscountCodeBtn.Visible = true;
                                updateTotalPrice();
                            }
                            else
                            {
                                updateSemiPrice();
                                discountAmountBox.Visible = false;
                                discountAmountBox.Text = "0";
                                dicountCodeBox.Visible = true;
                                discountBtn.Visible = true;
                                givediscountCodeBtn.Visible = false;
                                MessageBox.Show("For grab the coupon code. Buy " + (Convert.ToInt32(Ds.Tables[0].Rows[0][6]) - total) + " BDT.");

                            }
                        }
                        else
                        {
                            MessageBox.Show("This offer reached the maximum limit.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Offer time is end.");
                    }
                }
                else
                {
                    MessageBox.Show("Coupon code is expired.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            DicountOparation();
        }

        private void GivediscountCodeBtn_Click(object sender, EventArgs e)
        {
            float value = float.Parse(discountAmountBox.Text);
            float total = float.Parse(totalAmountBox.Text) + float.Parse(discountAmountBox.Text);
            totalAmountBox.Text = total.ToString();
            discountAmountBox.Visible = false;
            dicountCodeBox.Visible = true;
            discountBtn.Visible = true;
            givediscountCodeBtn.Visible = false;
            ClaimedDiscount.id = "";
        }

        private string GenerateOrderID()
        {
            this.Sql = "select * from orders order by orderId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string orderId = Dt.Rows[0]["orderId"].ToString();
            string[] str = orderId.Split('O');
            int n = Convert.ToInt32(str[1]);
            string neworderId = "O" + (++n).ToString("d3");
            return neworderId;
        }
        private string GeneratePaymentID()
        {
            this.Sql = "select * from payments order by payId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string paymentId = Dt.Rows[0]["payId"].ToString();
            string[] str = paymentId.Split('A');
            int n = Convert.ToInt32(str[1]);
            string newpaymentId = "PA" + (++n).ToString("d3");
            return newpaymentId;
        }
        private string getAllproductID()
        {
            string result = "";

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                result += row.Cells[0].Value + "," + row.Cells[1].Value + "," + row.Cells[2].Value + "," + row.Cells[3].Value + "," + row.Cells[4].Value + "\n";
            }
            return result;
        }

        private void GoBuyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Confirm Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string amount = totalAmountBox.Text;
                    OrderCompletePage oc = new OrderCompletePage(amount);
                    oc.Show();

                    oc.paymentCompleted += (send, args) =>
                    {
                        updateProductStock();

                        this.Sql = @"INSERT INTO orders(orderId,orderDate,productId,paymentId,employeeId) " +
                                        "VALUES('" + GenerateOrderID() + "','" + DateTime.Now + "','" + getAllproductID() + "','" + GeneratePaymentID() + "','" + LoggedUser.id + "')";

                        Da.ExecuteUpdateQuery(this.Sql);

                        this.Sql = @"INSERT INTO payments(payId,payAmount,payType,orderId,employeeId,payTime) " +
                                        "VALUES('" + GeneratePaymentID() + "','" + float.Parse(amount) + "','" + SelectedPaymentMethod.method + "','" + GenerateOrderID() + "','" + LoggedUser.id + "','" + DateTime.Now + "')";

                        Da.ExecuteUpdateQuery(this.Sql);



                        if (ClaimedDiscount.id != "")
                        {
                            if (ClaimedDiscount.limit != 0 || ClaimedDiscount.limit != null)
                            {
                                int limit = (--ClaimedDiscount.limit);
                                this.Sql = @"UPDATE discounts SET disLimit='" + limit + "'" + "WHERE disId='" + ClaimedDiscount.id + "'";
                                Da.ExecuteUpdateQuery(this.Sql);
                                ClaimedDiscount.id = "";
                            }
                        }

                        clearAll();
                    };


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void DgvCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updateTax();
        }

        private void DgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateTax();
        }

        private void DgvCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updateTax();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.SelectedRows.Count == 1)
                {
                    dgvCart.Rows.Remove(dgvCart.CurrentRow);
                    updateSemiPrice();
                    if (dicountCodeBox.Visible == false)
                    {
                        DicountOparation();
                    }
                    updateTotalPrice();
                    updateTax();
                }
                else
                {
                    MessageBox.Show("Select row for delete.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
    }
}
