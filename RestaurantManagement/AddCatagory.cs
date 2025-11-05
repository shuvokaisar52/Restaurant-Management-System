using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Windows.Controls.Primitives;


namespace RestaurantManagement
{
    public partial class AddCatagory: UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }
        private OpenFileDialog open { set; get; }
        private string Sql { get; set; }
        public AddCatagory()
        {
            InitializeComponent();
            Da= new DataAccess();
            getData();
        }
        private void GenerateCategoryID()
        {
            this.Sql = "select * from categorys order by categoryId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string catId = Dt.Rows[0]["categoryId"].ToString();
            string[] str = catId.Split('C');
            int n = Convert.ToInt32(str[1]);
            string neweId = "C" + (++n).ToString("d3");
            categoryidBox.Text = neweId;
        }
        private void getData(string sql = @"SELECT * FROM categorys")
        {
            Dt = Da.ExecuteQueryTable(sql);
            categorysGrid.DataSource = Dt;
            GenerateCategoryID();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = categoryidBox.Text;
                string name = nameBox.Text;
                string status = categoryStatusBox.Text;
                string images = categorypicbox.ImageLocation;
                this.Sql = @"INSERT INTO categorys(categoryId, categoryName, categoryStatus, categoryImg) " +
                  "VALUES('" + id + "', '" + name + "', '" + status + "', '" + images + "')";

                Da.ExecuteUpdateQuery(this.Sql);
                MessageBox.Show("New " + name + " category added successfully.");
                getData();

                string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") add new category " + name + " (" + id + ").";
                this.Sql = @"INSERT INTO controls(history) " +
                  "VALUES('" + createHistory + "')";

                Da.ExecuteUpdateQuery(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = categoryidBox.Text;
                string name = nameBox.Text;
                string status = categoryStatusBox.Text;
                string images = categorypicbox.ImageLocation;
                this.Sql = "UPDATE categorys SET categoryName='" + name + "', categoryStatus='" + status + "', categoryImg='" + images + "' WHERE categoryId='" + id + "'";

                Da.ExecuteUpdateQuery(this.Sql);
                string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") update category " + name + " (" + id + ").";
                this.Sql = @"INSERT INTO controls(history) " +
                  "VALUES('" + createHistory + "')";

                Da.ExecuteUpdateQuery(this.Sql);
                MessageBox.Show("category details updated.");

                getData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void addImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                open = new OpenFileDialog();
                open.Filter = "Image Files (*.jpg,*.png|*.jpg;*.png)";
                string path = "";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    path = open.FileName;
                    categorypicbox.ImageLocation = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAll()
        {
            categoryidBox.Text = "";
            nameBox.Text = "";
            categoryStatusBox.SelectedIndex = -1;
            categorypicbox.ImageLocation = "";
            searchBox.Text = "";
            GenerateCategoryID();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.categorysGrid.CurrentRow.Cells["categoryName"].Value.ToString();
                string id = this.categorysGrid.CurrentRow.Cells["categoryId"].Value.ToString();

                this.Sql = @"delete from categorys where categoryId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Category data has been deleted.");
                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") delete category " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " +
                      "VALUES('" + createHistory + "')";

                    Da.ExecuteUpdateQuery(this.Sql);
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
                }
                this.getData();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void categorysGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (categorysGrid.CurrentRow != null)
            {
                try
                {
                    this.categoryidBox.Text = categorysGrid.CurrentRow.Cells["categoryId"].Value?.ToString();
                    this.nameBox.Text = categorysGrid.CurrentRow.Cells["categoryName"].Value?.ToString();
                    this.categorypicbox.Text = categorysGrid.CurrentRow.Cells["categoryImg"].Value?.ToString();
                    categorypicbox.ImageLocation = categorypicbox.Text;
                    this.categoryStatusBox.Text = categorysGrid.CurrentRow.Cells["categoryStatus"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading category details: " + ex.Message);
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from categorys where categoryName like '" + this.searchBox.Text + "%';";
            this.getData(sql);
        }
    }
}
