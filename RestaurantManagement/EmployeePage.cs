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
    public partial class EmployeePage : Form
    {
        private void buttonClickColor(Button b1, Button b2, Button b3, Button b4, Button b5/*, Button b6, Button b7*/)
        {
            b1.BackColor = Color.CornflowerBlue;
            b1.ForeColor = Color.Snow;
            b2.BackColor = Color.Transparent;
            b2.ForeColor = Color.Black;
            b3.BackColor = Color.Transparent;
            b3.ForeColor = Color.Black;
            b4.BackColor = Color.Transparent;
            b4.ForeColor = Color.Black;
            b5.BackColor = Color.Transparent;
            b5.ForeColor = Color.Black;
            //b6.BackColor = Color.Transparent;
            //b7.BackColor = Color.Transparent;
        }
        public EmployeePage(string name)
        {
            InitializeComponent();
            typeLabel.Text = name;
            allProductShow.Visible = true;
            showCategory.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
        }
       
        public void clickedCategory()
        {
            showCategory.Visible = false;
            allProductShow.Visible = true;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(categoryBtn, orderBtn, productBtn, logoutBtn,paymentBtn);
            allProductShow.Visible = false;
            showCategory.Visible = true;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(productBtn, orderBtn, categoryBtn, logoutBtn, paymentBtn);
            allProductShow.Visible = true;
            showCategory.Visible = false;
            paymentHistory.Visible = false;
            orderHistory.Visible = false;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(orderBtn, productBtn, categoryBtn, logoutBtn, paymentBtn);
            allProductShow.Visible = false;
            showCategory.Visible = false;
            orderHistory.Visible = true;
            paymentHistory.Visible = false;
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(paymentBtn, productBtn, categoryBtn, logoutBtn, orderBtn);
            allProductShow.Visible = false;
            showCategory.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = true;
        }
    }
}
