using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantManagement
{
    public partial class DiscountList : UserControl
    {
        private DataAccess Da { get; set; }
        private DataTable Dt { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public DiscountList()
        {
            InitializeComponent();
            Da = new DataAccess();
            GenerateDiscountID();
            getData();
        }
        private void getData(string sql = @"SELECT * FROM discounts")
        {
            this.Dt = Da.ExecuteQueryTable(sql);
            this.dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = Dt;
        }
        private bool boxEmpty()
        {
            string id = idBox.Text;
            string name = nameBox.Text;
            string code = couponCodeBox.Text;
            float percentage = float.Parse(parcentageBox.Text);
            int limit = int.Parse(limitBox.Text);
            int minimum = int.Parse(minimumDiscountBox.Text);
            int maximum = int.Parse(maximumDiscountBox.Text);
            string startDate = startDateBox.Text;
            string endDate = endDateBox.Text;
            if (name == "" || couponCodeBox.Text == "" || startDate == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearAll()
        {
            idBox.Text="";
            nameBox.Text="";
            couponCodeBox.Text="";
            parcentageBox.Text = "";
            limitBox.Text="";
            minimumDiscountBox.Text="";
            maximumDiscountBox.Text="";
            startDateBox.Text="";
            endDateBox.Text="";
            searchBox.Text = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void GenerateDiscountID()
        {
            this.Sql = "select * from discounts order by disId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string disId = Dt.Rows[0]["disId"].ToString();
            string[] str = disId.Split('D');
            int n = Convert.ToInt32(str[1]);
            string newdisId = "D" + (++n).ToString("d3");
            idBox.Text = newdisId;
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text;
                string name = nameBox.Text;
                string code = couponCodeBox.Text.ToUpper();
                float percentage = float.Parse(parcentageBox.Text);
                int limit = int.Parse(limitBox.Text);
                int minimum = int.Parse(minimumDiscountBox.Text);
                int maximum = int.Parse(maximumDiscountBox.Text);
                string startDate = startDateBox.Text;
                string endDate = endDateBox.Text;

                if (boxEmpty())
                {
                    MessageBox.Show("Enter all details.");
                }
                else
                {
                    this.Sql = "INSERT INTO discounts(disId, disName,disCode, disParcentage,disLimit, disMax, disMin, disStart, disEnd) " +
                    "VALUES('" + id + "','" + name + "','" + code + "','" + percentage + "','" + limit + "','" + maximum + "','" + minimum + "','" + startDate + "','" + endDate + "')";
                    int added = Da.ExecuteUpdateQuery(this.Sql);

                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") add new discount package " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                    Da.ExecuteUpdateQuery(this.Sql);
                    if (added == 1)
                    {
                        MessageBox.Show("New discount package added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Discount package insertion failed");
                    }

                    getData();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.dataGridView.CurrentRow.Cells["disName"].Value.ToString();
                string id = this.dataGridView.CurrentRow.Cells["disId"].Value.ToString();

                this.Sql = @"delete from discounts where disId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Discount Package data has been deleted.");

                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") delete discount package " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                    Da.ExecuteUpdateQuery(this.Sql);
                }
                else
                {
                    MessageBox.Show("Discount Package data deletion failed");
                }
                this.getData();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text;
                string name = nameBox.Text;
                string code = couponCodeBox.Text.ToUpper();
                float percentage = float.Parse(parcentageBox.Text);
                int limit = int.Parse(limitBox.Text);
                int minimum = int.Parse(minimumDiscountBox.Text);
                int maximum = int.Parse(maximumDiscountBox.Text);
                string startDate = startDateBox.Text;
                string endDate = endDateBox.Text;

                if (boxEmpty())
                {
                    MessageBox.Show("Enter all details.");
                }
                else
                {
                    DataAccess da = new DataAccess();
                    string sql = "UPDATE discounts SET disName='" + name + "',disCode='" + code + "', disParcentage='" + percentage + "', disLimit='" + limit + "', disMax='" + maximum + "', disMin='" + minimum + "', disStart='" + startDate + "', disEnd='" + endDate + "' WHERE disId='" + id + "'";
                    int added = da.ExecuteUpdateQuery(sql);
                    if (added == 1)
                    {
                        MessageBox.Show("Discount Package added.");
                        string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") update category package " + name + " (" + id + ").";
                        this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                        Da.ExecuteUpdateQuery(this.Sql);
                    }
                    ClearAll();
                    getData();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from discounts where disName like '" + this.searchBox.Text + "%';";
            this.getData(this.Sql);
        }

        private void DataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                try
                {
                    this.idBox.Text = dataGridView.CurrentRow.Cells["disId"].Value?.ToString();
                    this.nameBox.Text = dataGridView.CurrentRow.Cells["disName"].Value?.ToString();
                    this.couponCodeBox.Text = dataGridView.CurrentRow.Cells["disCode"].Value?.ToString();
                    this.parcentageBox.Text = dataGridView.CurrentRow.Cells["disParcentage"].Value?.ToString();
                    this.maximumDiscountBox.Text = dataGridView.CurrentRow.Cells["disMax"].Value?.ToString();
                    this.minimumDiscountBox.Text = dataGridView.CurrentRow.Cells["disMin"].Value?.ToString();
                    this.limitBox.Text = dataGridView.CurrentRow.Cells["disLimit"].Value?.ToString();
                    this.startDateBox.Text = dataGridView.CurrentRow.Cells["disStart"].Value?.ToString();
                    this.endDateBox.Text = dataGridView.CurrentRow.Cells["disEnd"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading discount package details: " + ex.Message);
                }
            }
        }
    }
}
