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
    public partial class LoginPage : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userIDBox.Text == "")
                {
                    MessageBox.Show("Please enter your ID.");
                }
                else if (passwordBox.Text == "")
                {
                    MessageBox.Show("Please enter your password.");
                }
                else
                {
                    this.Sql = @"SELECT * FROM users WHERE userId = '" + this.userIDBox.Text + "' AND password = '" + this.passwordBox.Text + "';";

                    Ds = Da.ExecuteQuery(this.Sql);

                    if (Ds.Tables[0].Rows.Count == 1)
                    {
                        if (Ds.Tables[0].Rows[0][4].ToString() == "Unblocked")
                        {
                            MessageBox.Show("Login successful.");
                            if (Ds.Tables[0].Rows[0][3].ToString() == "Manager")
                            {
                                ManagerPage mp = new ManagerPage(Ds.Tables[0].Rows[0][2].ToString());

                                LoggedUser.role = "Manager";
                                mp.Show();
                                this.Hide();
                            }
                            else if (Ds.Tables[0].Rows[0][3].ToString() == "Employee")
                            {
                                EmployeePage ep = new EmployeePage(Ds.Tables[0].Rows[0][2].ToString());
                                LoggedUser.role = "Employee";
                                ep.Show();
                                this.Hide();
                            }
                            else
                            {
                                OwnerPage op = new OwnerPage(Ds.Tables[0].Rows[0][2].ToString());
                                LoggedUser.role = "Owner";
                                op.Show();
                                this.Hide();
                            }
                        }
                        else if (Ds.Tables[0].Rows[0][4].ToString() == "Blocked")
                        {
                            MessageBox.Show("Your account is blocked.");
                        }
                        else if (Ds.Tables[0].Rows[0][4].ToString() == "Fired")
                        {
                            MessageBox.Show("You're fired from the job.");
                        }
                        else
                        {
                            MessageBox.Show("Login Error.");
                        }

                        LoggedUser.id = Ds.Tables[0].Rows[0][0].ToString();
                        LoggedUser.name = Ds.Tables[0].Rows[0][2].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Sorry you enter wrong id and password, Please try again!");
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
