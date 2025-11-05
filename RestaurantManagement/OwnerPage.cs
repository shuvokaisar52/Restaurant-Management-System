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
    public partial class OwnerPage : Form
    {
        private bool isDropDown { set; get; }
        public OwnerPage(string name)
        {
            InitializeComponent();
            typeLabel.Text = name;
            employeeList.Visible = false;
            managerList.Visible = false;
            discountList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = false;
            addCatagory.Visible = false;
            paymentMethodsList.Visible = false;
       }
        private void buttonClickColor(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6, Button b7)
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
            b6.BackColor = Color.Transparent;
            b6.ForeColor = Color.Black;
            b7.BackColor = Color.Transparent;
            b7.ForeColor = Color.Black;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isDropDown)
            {
                buttonPanel.Visible = true;
                buttonPanel.Height += 25;
                if (buttonPanel.Size == buttonPanel.MaximumSize)
                {
                    timer1.Stop();
                    isDropDown = false;
                }
            }
            else
            {
                buttonPanel.Height -= 25;
                if (buttonPanel.Size == buttonPanel.MinimumSize)
                {
                    timer1.Stop();
                    isDropDown = true;
                    buttonPanel.Visible = false;
                }
            }
        }

        private void ControlsBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            buttonClickColor(controlsBtn, managerBtn, productBtn, employeBtn, categoryBtn,dashboardBtn,discountBtn);
            orderHistory.Visible = false;
            paymentHistory.Visible = true;
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(dashboardBtn,controlsBtn, managerBtn, productBtn, employeBtn, categoryBtn, discountBtn);
            discountList.Visible = false;
            managerList.Visible = false;
            employeeList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = false;
            dashboard1.Visible = true;
            addCatagory.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(managerBtn,controlsBtn, productBtn, employeBtn, categoryBtn, dashboardBtn, discountBtn);
            managerList.Visible = true;
            employeeList.Visible = false;
            discountList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = false;
            dashboard1.Visible = false;
            addCatagory.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void EmployeBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(employeBtn,controlsBtn, managerBtn, productBtn, categoryBtn, dashboardBtn, discountBtn);
            employeeList.Visible = true;
            managerList.Visible = false;
            discountList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = false;
            dashboard1.Visible = false;
            addCatagory.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(productBtn, controlsBtn, managerBtn, employeBtn, categoryBtn, dashboardBtn, discountBtn);
            discountList.Visible = false;
            managerList.Visible = false;
            employeeList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = true;
            dashboard1.Visible = false;
            addCatagory.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(categoryBtn, controlsBtn, managerBtn, productBtn, employeBtn,dashboardBtn, discountBtn);
            discountList.Visible = false;
            managerList.Visible = false;
            employeeList.Visible = false;
            paymentHistory.Visible = false;
            orderHistory.Visible = false;
            productList.Visible = false;
            dashboard1.Visible = false;
            addCatagory.Visible = true;
            paymentMethodsList.Visible = false;
        }

        

        private void DiscountBtn_Click(object sender, EventArgs e)
        {
            buttonClickColor(discountBtn, controlsBtn, managerBtn, productBtn, employeBtn, dashboardBtn,categoryBtn);
            discountList.Visible = true;
            employeeList.Visible = false;
            managerList.Visible = false;
            orderHistory.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = false;
            addCatagory.Visible = false;
            dashboard1.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        private void OrderHistoryBtn_Click(object sender, EventArgs e)
        {
            orderHistory.Visible = true;
            discountList.Visible = false;
            employeeList.Visible = false;
            managerList.Visible = false;
            paymentHistory.Visible = false;
            productList.Visible = false;
            dashboard1.Visible = false;
            addCatagory.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void PaymentHistoryBtn_Click(object sender, EventArgs e)
        {
            paymentHistory.Visible = true;
            orderHistory.Visible = false;
            discountList.Visible = false;
            employeeList.Visible = false;
            managerList.Visible = false;
            productList.Visible = false;
            addCatagory.Visible = false;
            dashboard1.Visible = false;
            paymentMethodsList.Visible = false;
        }

        private void paymentMethodBtn_Click(object sender, EventArgs e)
        {
            paymentMethodsList.Visible = true;
            paymentHistory.Visible = false;
            orderHistory.Visible = false;
            discountList.Visible = false;
            employeeList.Visible = false;
            managerList.Visible = false;
            productList.Visible = false;
            addCatagory.Visible = false;
            dashboard1.Visible = false;
        }
    }
}
