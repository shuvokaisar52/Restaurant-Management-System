using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RestaurantManagement
{
    public partial class ManagerList : UserControl
    {
        private DataAccess Da { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        public ManagerList()
        {
            InitializeComponent();
            Da = new DataAccess();
            getData();
            roleBox.SelectedIndex = 0;
        }
        private void getData(string sql = @"SELECT * FROM managers")
        {
            GenerateManagerID();
            Dt = Da.ExecuteQueryTable(sql);
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = Dt;
        }
        private bool boxEmpty()
        {
            string id = idBox.Text;
            string pass = passwordBox.Text;
            string name = nameBox.Text;
            string email = emailBox.Text;
            int salary = int.Parse(salaryBox.Text);
            string gender = genderBox.Text;
            string date = joindateBox.Text;
            string role = roleBox.Text;
            if (name == "" || pass == "" || email == "" || salaryBox.Text == "" || gender == "" || date == "" || role == "")
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
            idBox.Text = "";
            passwordBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            salaryBox.Text = "";
            genderBox.SelectedIndex = -1;
            joindateBox.Text = "";
            roleBox.SelectedIndex = -1;
            statusBox.SelectedIndex = -1;

            GenerateManagerID();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void GenerateManagerID()
        {
            this.Sql = "select * from managers order by mId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string mId = Dt.Rows[0]["mId"].ToString();
            string[] str = mId.Split('M');
            int n = Convert.ToInt32(str[1]);
            string newmId = "M" + (++n).ToString("d3");
            idBox.Text = newmId;
        }


        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.dataGridView2.CurrentRow.Cells["mName"].Value.ToString();
                string id = this.dataGridView2.CurrentRow.Cells["mId"].Value.ToString();

                this.Sql = @"delete from managers where mId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    this.Sql = @"delete from users where userId = '" + id + "';";
                    this.Da.ExecuteUpdateQuery(this.Sql);

                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") removed " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";
                    Da.ExecuteUpdateQuery(this.Sql);

                    MessageBox.Show("Manager data has been deleted.");
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
                }
                this.ClearAll();
                this.getData();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text;
                string pass = passwordBox.Text;
                string name = nameBox.Text;
                string email = emailBox.Text;
                int salary = int.Parse(salaryBox.Text);
                string gender = genderBox.Text;
                string date = joindateBox.Text;
                string role = roleBox.Text;
                string status = statusBox.Text;
                if (boxEmpty())
                {
                    MessageBox.Show("Enter all details.");
                }
                else
                {
                    this.Sql = "INSERT INTO managers(mId, mPassword, mName, mEmail, mSalary, mGender, mJoinDate, mFireDate, mRole, mStatus) " +
                    "VALUES('" + id + "','" + pass + "','" + name + "','" + email + "','" + salary + "','" + gender + "','" + date + "','','" + role + "','" + status + "')";
                    int added = Da.ExecuteUpdateQuery(this.Sql);
                    if (added == 1)
                    {
                        MessageBox.Show("New manager added successfully.");
                        this.Sql = @"INSERT INTO users(userId,password,name,role,status) " + "VALUES('" + id + "','" + pass + "','" + name + "','" + role + "','" + status + "')";
                        Da.ExecuteUpdateQuery(this.Sql);


                        string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") add new manager " + name + " (" + id + ").";
                        this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                        Da.ExecuteUpdateQuery(this.Sql);
                    }
                    else
                    {
                        MessageBox.Show("manager data insertion failed");
                    }

                    getData();
                    ClearAll();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = idBox.Text;
                string pass = passwordBox.Text;
                string name = nameBox.Text;
                string email = emailBox.Text;
                int salary = int.Parse(salaryBox.Text);
                string gender = genderBox.Text;
                string date = joindateBox.Text;
                string role = roleBox.Text;
                string status = statusBox.Text;
                if (boxEmpty())
                {
                    MessageBox.Show("Enter all details.");
                }
                else
                {
                    this.Sql = "UPDATE managers SET mPassword='" + pass + "', mName='" + name + "', mEmail='" + email + "', mSalary='" + salary + "', mGender='" + gender + "', mJoinDate='" + date + "', mFireDate='', mRole='" + role + "', mStatus='" + status + "' WHERE mId='" + id + "'";
                    int added = Da.ExecuteUpdateQuery(this.Sql);
                    if (added == 1)
                    {
                        MessageBox.Show("Manager details updated.");
                        this.Sql = @"UPDATE users SET password='" + pass + "',name='" + name + "',role='" + role + "',status='" + status + "'" + "WHERE userId='" + id + "'";
                        Da.ExecuteUpdateQuery(this.Sql);


                        string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") update data of " + name + " (" + id + ").";
                        this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                        Da.ExecuteUpdateQuery(this.Sql);
                    }
                    getData();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void FiredBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dataGridView2.CurrentRow.Cells["mId"].Value.ToString();
                string name = this.dataGridView2.CurrentRow.Cells["mName"].Value.ToString();
                string date = DateTime.Now.ToString();

                this.Sql = "UPDATE managers SET mFireDate='" + date + "', mStatus='" + "Fired" + "' WHERE mId='" + id + "'";
                int added = Da.ExecuteUpdateQuery(this.Sql);

                if (added == 1)
                {
                    this.Sql = @"UPDATE users SET status='" + "Fired" + "'" + "WHERE userId='" + id + "'";
                    Da.ExecuteUpdateQuery(this.Sql);


                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") fired " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";
                    Da.ExecuteUpdateQuery(this.Sql);

                    MessageBox.Show(name + " has been fired");
                }
                else
                {
                    MessageBox.Show("Manager Fired fail.");
                }
                getData();
                ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from managers where eName like '" + this.searchBox.Text + "%';";
            this.getData(this.Sql);
        }

        private void DataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    this.idBox.Text = dataGridView2.CurrentRow.Cells["mId"].Value?.ToString();
                    this.passwordBox.Text = dataGridView2.CurrentRow.Cells["mPassword"].Value?.ToString();
                    this.nameBox.Text = dataGridView2.CurrentRow.Cells["mName"].Value?.ToString();
                    this.emailBox.Text = dataGridView2.CurrentRow.Cells["mEmail"].Value?.ToString();
                    this.salaryBox.Text = dataGridView2.CurrentRow.Cells["mSalary"].Value?.ToString();
                    this.genderBox.Text = dataGridView2.CurrentRow.Cells["mGender"].Value?.ToString();
                    this.joindateBox.Text = dataGridView2.CurrentRow.Cells["mJoinDate"].Value?.ToString();
                    this.roleBox.Text = dataGridView2.CurrentRow.Cells["mRole"].Value?.ToString();
                    this.statusBox.Text = dataGridView2.CurrentRow.Cells["mStatus"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading details: " + ex.Message);
                }
            }
        }
    }
}
