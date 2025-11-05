using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class ShowCategory : UserControl
    {
        private Product p { set; get; }
        private Category c { set; get; }
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        public ShowCategory()
        {
            InitializeComponent();
            Da = new DataAccess();
            getAllCategory();
            showProductFlowLayout.Visible = false;
        }
        private void addCategory(string id, string name, string status,string img)
        {
            try
            {
                c = new Category()
                {
                    catId = id,
                    catName = name,
                    catStatus = status,
                    catImage = img,
                };

                showCategoryFlowLayout.Controls.Add(c);

                c.categorySelected += (sender, args) =>
                {
                    ClickedCategory.name = c.catName;
                    showProductFlowLayout.Visible = true;
                    this.getAllProduct();
                    showCategoryFlowLayout.Visible = false;
                    pictureBox2.Visible = true;
                };
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        private void getAllCategory()
        {
            try
            {
                this.Sql = @"SELECT * FROM categorys WHERE categoryStatus='Available'";

                Dt = Da.ExecuteQueryTable(this.Sql); ;
                showCategoryFlowLayout.Controls.Clear();
                foreach (DataRow r in Dt.Rows)
                {
                    string id = r["categoryId"].ToString();
                    string name = r["categoryName"].ToString();
                    string status = r["categoryStatus"].ToString();
                    string image = r["categoryImg"].ToString();

                    addCategory(id, name, status, image);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        private void addProduct(string id, string name, string price, int tax, int stock, string category, string img, string status)
        {

            try
            {
                p = new Product()
                {
                    proId = id,
                    proName = name,
                    proPrice = price + " BDT",
                    proStock = stock,
                    proCategory = category,
                    proImage = img,
                    proStatus = status,
                };


                showProductFlowLayout.Controls.Add(p);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        private void getAllProduct()
        {
            try
            {
                this.Sql = @"SELECT * FROM products WHERE productStatus='Available' AND productCategory='" + ClickedCategory.name + "'";
                Dt = Da.ExecuteQueryTable(this.Sql); ;
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            showProductFlowLayout.Visible = false;
            showCategoryFlowLayout.Visible = true;
            getAllCategory();
            pictureBox2.Visible = false;
        }

    }


   
}
