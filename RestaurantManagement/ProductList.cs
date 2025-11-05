using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantManagement
{
    public partial class ProductList: UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        public ProductList()
        {
            InitializeComponent();
            Da = new DataAccess();
            showCategory();
            getData();
            preferenceAddPanel.Visible = false;
        }

        public void getData()
        {
            GenerateProductID();
            this.Sql = @"SELECT * FROM products";

            Dt = Da.ExecuteQueryTable(this.Sql);
            productsGrid.DataSource = Dt;
        }
        private void showCategory()
        {
            this.Sql = @"SELECT * FROM categorys";

            Ds = Da.ExecuteQuery(this.Sql);
            CategoryBox.Items.Clear();
            foreach (DataRow row in Ds.Tables[0].Rows)
            {
                CategoryBox.Items.Add(row["categoryName"].ToString());
            }
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text;
                string name = NameBox.Text;
                float price = float.Parse(priceBox.Text);
                int tax = int.Parse(taxBox.Text);
                int stock = int.Parse(stockBox.Text);
                string category = CategoryBox.Text;
                string preferences = preferenceBox.Text;
                string status = statusBox.Text;
                string images = pictureBox1.ImageLocation;
                this.Sql = @"INSERT INTO products(productId, productName,productPrice,productTax, productStock, productCategory, productImage, productStatus, productPreferences) " +
                  "VALUES('" + id + "', '" + name + "', '" + price + "', '" + tax + "', '" + stock + "', '" + category + "', '" + images + "', '" + status + "', '" + preferences + "')";

                Da.ExecuteUpdateQuery(this.Sql);

                string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") add new product " + name + " (" + id + ").";
                this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                Da.ExecuteUpdateQuery(this.Sql);
                MessageBox.Show("New product " + ProductName + " added successfully.");

                ClearAll();
                getData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text;
                string name = NameBox.Text;
                float price = float.Parse(priceBox.Text);
                int tax = int.Parse(taxBox.Text);
                int stock = int.Parse(stockBox.Text);
                string category = CategoryBox.Text;
                string preferences = preferenceBox.Text;
                string status = statusBox.Text;
                string images = pictureBox1.ImageLocation;
                this.Sql = "UPDATE products SET productName='" + name + "', productPrice='" + price + "', productTax='" + tax + "', productStock='" + stock + "', productCategory='" + category + "', productImage='" + images + "', productStatus='" + status + "', productPreferences='" + preferences + "' WHERE productId='" + id + "'";

                Da.ExecuteUpdateQuery(this.Sql);

                string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") update product " + name + " (" + id + ").";
                this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                Da.ExecuteUpdateQuery(this.Sql);
                MessageBox.Show("product details updated.");

                getData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void Addimagebtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                string path = "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    path = open.FileName;
                    pictureBox1.ImageLocation = path;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsGrid.CurrentRow != null)
            {
                try
                {
                    this.idBox.Text = productsGrid.CurrentRow.Cells["productId"].Value?.ToString();
                    this.NameBox.Text = productsGrid.CurrentRow.Cells["productName"].Value?.ToString();
                    this.priceBox.Text = productsGrid.CurrentRow.Cells["productPrice"].Value?.ToString();
                    this.taxBox.Text = productsGrid.CurrentRow.Cells["productTax"].Value?.ToString();
                    this.stockBox.Text = productsGrid.CurrentRow.Cells["productStock"].Value?.ToString();
                    this.CategoryBox.Text = productsGrid.CurrentRow.Cells["productCategory"].Value?.ToString();
                    this.preferenceBox.Text = productsGrid.CurrentRow.Cells["productPreferences"].Value?.ToString();
                    this.pictureBox1.Text = productsGrid.CurrentRow.Cells["productImage"].Value?.ToString();
                    pictureBox1.ImageLocation = pictureBox1.Text;
                    this.statusBox.Text = productsGrid.CurrentRow.Cells["productStatus"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error details: " + ex.Message);
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.productsGrid.CurrentRow.Cells["productId"].Value.ToString();
                string name = this.productsGrid.CurrentRow.Cells["productName"].Value.ToString();

                this.Sql = @"delete from products where productId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("product data has been deleted.");

                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") delete product " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";
                    Da.ExecuteUpdateQuery(this.Sql);
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
                }
                this.ClearAll();
                this.getData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }
        private void ClearAll()
        {
            idBox.Text = "";
            NameBox.Text = "";
            priceBox.Text = "";
            taxBox.Text = "";
            stockBox.Text = "";
            CategoryBox.Text = "";
            preferenceBox.Text = "";
            statusBox.Text = "";
            pictureBox1.ImageLocation = "";
            searchBox.Text = "";
            GenerateProductID();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void GenerateProductID()
        {
            this.Sql = "select * from products order by productId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string productId = Dt.Rows[0]["productId"].ToString();
            string[] str = productId.Split('P');
            int n = Convert.ToInt32(str[1]);
            string newId = "P" + (++n).ToString("d3");
            idBox.Text = newId;
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            showCategory();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            preferenceAddPanel.Visible = false;
            preferencesListGrid.Rows.Clear();
        }

        private void AddPreference_Click(object sender, EventArgs e)
        {
            preferencesListGrid.Rows.Add(sizeLabelBox.Text, newPriceBox.Text);
        }

        private void SavePreference_Click(object sender, EventArgs e)
        {
            string preferences = "";
            for(int i=0; i<preferencesListGrid.Rows.Count; i++)
            {
                string size = preferencesListGrid.Rows[i].Cells[0].Value.ToString();
                string price = preferencesListGrid.Rows[i].Cells[1].Value.ToString();
                preferences += (size + " " + price)+",";
            }
            preferenceBox.Text = preferences;
            preferenceAddPanel.Visible = false;
            preferencesListGrid.Rows.Clear();
        }

        private void AddPreferencesBtn_Click(object sender, EventArgs e)
        {
            string[] allpreferences = preferenceBox.Text.Split(',');
            foreach (string item in allpreferences)
            {
                string[] part = item.Split(' ');
                if (part.Length == 2)
                {
                    preferencesListGrid.Rows.Add(part[0], part[1]);
                }
            }
            preferenceAddPanel.Visible = true;
        }
    }
}
