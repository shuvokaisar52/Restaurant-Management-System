using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class OrderCompletePage : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string total { set; get; }
        public OrderCompletePage(string amount)
        {
            InitializeComponent();
            Da = new DataAccess();
            this.total = amount;
            showMethods();
        }
        private void showMethods()
        {
            try
            {
                this.Sql = @"SELECT * FROM methods Where methodStatus='ON'";

                Ds = Da.ExecuteQuery(this.Sql);
                methodBox.Items.Clear();
                foreach (DataRow row in Ds.Tables[0].Rows)
                {
                    methodBox.Items.Add(row["methodName"].ToString());
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        public event EventHandler paymentCompleted = null;
        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                float totalAmount = float.Parse(this.total);
                float change = float.Parse(changeBox.Text);

                if (change >= totalAmount)
                {
                    if (methodBox.Text != "Select Method")
                    {
                        SelectedPaymentMethod.method = methodBox.Text;
                        MessageBox.Show("You have to give change: " + (change - totalAmount));
                        paymentCompleted?.Invoke(this, EventArgs.Empty);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Select Payment Method.");
                    }

                }
                else if (!(change is float))
                {
                    MessageBox.Show("Enter only valid number.");
                }
                else
                {
                    MessageBox.Show("Your payment is not complete.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
