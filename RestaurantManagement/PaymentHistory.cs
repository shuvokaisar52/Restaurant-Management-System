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
    public partial class PaymentHistory : UserControl
    {
        public PaymentHistory()
        {
            InitializeComponent();
            getAllData();
        }
        private void getAllData()
        {
            string sql;
            if (LoggedUser.role == "Employee")
            {
                sql = @"SELECT * FROM payments WHERE employeeId='" + LoggedUser.id + "'";
            }
            else
            {
                sql = @"SELECT * FROM payments";
            }
            DataAccess da = new DataAccess();
            DataTable dt = da.ExecuteQueryTable(sql); ;
            orderHistoryGrid.DataSource = dt;
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            getAllData();
        }

        private void PaymentHistory_Load(object sender, EventArgs e)
        {
            getAllData();
        }
    }
}
