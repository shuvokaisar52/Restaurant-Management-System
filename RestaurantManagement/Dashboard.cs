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
    public partial class Dashboard : UserControl
    {
        private DataAccess Da { get; set; }
        private DataTable Dt { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            this.Da= new DataAccess();
            totalEmployee();
            totalProducts();
            totalCategory();
            totalOrderAmountLabel.Text = totalOrder();
            totalSalesAmountLabel.Text = totalSales();
            todaySales();
            controlsBox.Visible = false;
            controlsLabel.Visible = false;
        }
        private void totalEmployee()
        {
            Dt = Da.ExecuteQueryTable(@"SELECT * FROM employees;");
            totalEmployeeAmountLabel.Text = Dt.Rows.Count.ToString();
        }
        private void totalProducts()
        {
            Dt = Da.ExecuteQueryTable(@"SELECT * FROM products;");
            totalProductAmountLabel.Text = Dt.Rows.Count.ToString();
        }
        private void totalCategory()
        {
            Dt = Da.ExecuteQueryTable(@"SELECT * FROM categorys;");
            totalCategoryAmountLabel.Text = Dt.Rows.Count.ToString();
        }
        private string totalOrder(string sql= @"SELECT * FROM orders;")
        {
            Dt = Da.ExecuteQueryTable(sql);
            return Dt.Rows.Count.ToString();
        }
        private void todaySales()
        {
            try
            {
                this.Sql = @"SELECT payAmount,payTime FROM payments;";

                this.Ds = Da.ExecuteQuery(Sql);
                double todaysales = 0;

                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    DateTime date = DateTime.Today;
                    if (Convert.ToDateTime(row["payTime"]).Date == date)
                    {
                        double sale = Convert.ToDouble(row["payAmount"]);
                        todaysales += sale;
                    }
                }
                todaysSalesLabel.Text = todaysales.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        private string totalSales(string sql= @"SELECT payAmount FROM payments;")
        {
            try
            {
                Ds = Da.ExecuteQuery(sql);
                double totalSales = 0;

                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    double sale = Convert.ToDouble(row["payAmount"]);
                    totalSales += sale;
                }
                return totalSales.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
            return "0";
        }
        private string workingDays(string id)
        {
            try
            {
                DateTime today = DateTime.Today;
                this.Sql = @"SELECT eJoinDate,eFireDate FROM employees WHERE eId='" + id + "'";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (Ds.Tables[0].Rows[0]["eFireDate"] == "")
                {
                    if (Ds != null && Ds.Tables[0].Rows.Count > 0)
                    {
                        DateTime date = Convert.ToDateTime(Ds.Tables[0].Rows[0]["eJoinDate"]);

                        return (today - date).Days.ToString();
                    }
                }
                else
                {
                    DateTime date = Convert.ToDateTime(Ds.Tables[0].Rows[0]["eJoinDate"]);
                    return (today - date).Days.ToString() + "(Fired)";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
            return "0";
        }
        private void historyLoad()
        {
            try
            {
                this.Sql = @"SELECT employeeId,payAmount FROM payments;";
                this.Ds = Da.ExecuteQuery(Sql);
                double totoalsales = 0;
                int orders = 0;
                string emp = Ds.Tables[0].Rows[0]["employeeId"].ToString();

                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    if (row["employeeId"].ToString() == emp)
                    {
                        double sale = Convert.ToDouble(row["payAmount"]);
                        totoalsales += sale;
                        orders++;
                    }
                    else
                    {
                        dgvEmployeeHistory.Rows.Add(emp, totoalsales, orders, (workingDays(emp) + " Days"));
                        emp = row["employeeId"].ToString();
                        totoalsales = Convert.ToDouble(row["payAmount"]);
                        orders = 1;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void loadDataHistory(string sql= @"SELECT * from controls;")
        {
            try
            {
                Dt = Da.ExecuteQueryTable(sql);
                int serial = 1;
                foreach (DataRow row in Dt.Rows)
                {
                    this.controlsBox.Text += serial.ToString() + ". " + row["history"] + "\n";
                    serial++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            loadDataHistory();
            historyLoad();
            if (LoggedUser.role == "Owner")
            {
                dgvEmployeeHistory.Size = new System.Drawing.Size(380, 200);
                controlsBox.Location = new System.Drawing.Point(419, 308);
                controlsBox.Visible = true;
                controlsLabel.Visible = true;
            }
        }
    }
}
