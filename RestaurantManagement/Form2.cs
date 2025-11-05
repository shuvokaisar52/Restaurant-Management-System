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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label5.Hide();
            passwordBox.Hide();
            submitBtn.Hide();
        }


        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextBtn2_Click(object sender, EventArgs e)
        {
            userIdLabel.Hide();
            userIDBox.Hide();
            forgetEmailLabel.Hide();
            emailBox.Hide();
            nextBtn2.Hide();

            label5.Show();
            passwordBox.Show();
            submitBtn.Show();
        }
    }
}
