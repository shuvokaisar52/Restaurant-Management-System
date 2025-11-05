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
    public partial class ManagerPage : Form
    {
        public ManagerPage(string name)
        {
            InitializeComponent();
            typeLabel.Text = name;

            employeeList.Visible = false;
            orderHistory.Visible = false;
            productList.Visible = false;
            paymentHistory.Visible = false;
            addCatagory.Visible = false;

        }
        private void buttonClickColor(Button b1,Button b2,Button b3, Button b4, Button b5, Button b6, Button b7)
        {
            b1.BackColor = Color.FromArgb(255, 128, 128);
            b2.BackColor = Color.Transparent;
            b3.BackColor = Color.Transparent;
            b4.BackColor = Color.Transparent;
            b5.BackColor = Color.Transparent;
            b6.BackColor = Color.Transparent;
            b7.BackColor = Color.Transparent;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            buttonClickColor(dashboardBtn, employeBtn, orderBtn, categoryBtn, productBtn, logoutBtn, paymentBtn);
            dashboard.Visible = true;
            employeeList.Visible = false;
            orderHistory.Visible = false;
            productList.Visible = false;
            paymentHistory.Visible = false;
            addCatagory.Visible = false;
        }

        

        private void EmployeBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(employeBtn, dashboardBtn, orderBtn, categoryBtn, productBtn, logoutBtn, paymentBtn);
            dashboard.Visible = false;
            employeeList.Visible = true;
            orderHistory.Visible = false;
            productList.Visible = false;
            paymentHistory.Visible = false;
            addCatagory.Visible = false;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(orderBtn, employeBtn, dashboardBtn, categoryBtn, productBtn, logoutBtn, paymentBtn);
            dashboard.Visible = false;
            employeeList.Visible = false;
            orderHistory.Visible = true;
            productList.Visible = false;
            paymentHistory.Visible = false;
            addCatagory.Visible = false;
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(categoryBtn, employeBtn, dashboardBtn, orderBtn, productBtn, logoutBtn, paymentBtn);
            
            dashboard.Visible = false;
            employeeList.Visible = false;
            orderHistory.Visible = false;
            productList.Visible = false;
            paymentHistory.Visible = false;
            addCatagory.Visible = true;
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(productBtn, employeBtn, dashboardBtn, orderBtn, categoryBtn, logoutBtn, paymentBtn);
            dashboard.Visible = false;
            productList.Visible = true;
            employeeList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            addCatagory.Visible = false;
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(paymentBtn, employeBtn, dashboardBtn, orderBtn, productBtn, logoutBtn, categoryBtn);
            dashboard.Visible = false;
            employeeList.Visible = false;
            orderHistory.Visible = false;
            productList.Visible = false;
            paymentHistory.Visible = true;
            addCatagory.Visible = false;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(logoutBtn, employeBtn, dashboardBtn, orderBtn, productBtn, categoryBtn, paymentBtn);
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }
    }
}
