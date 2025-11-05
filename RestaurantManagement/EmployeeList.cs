using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RestaurantManagement
{
    public partial class EmployeeList : UserControl
    {
        private DataAccess Da { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        public EmployeeList()
        {
            InitializeComponent();
            Da = new DataAccess();
            getData();
            roleBox.SelectedIndex = 0;
            
        }
        private void getData(string sql= @"SELECT * FROM employees")
        {
            GenerateEmployeeID();
            Dt = Da.ExecuteQueryTable(sql);
            this.dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = Dt;
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
            searchBox.Text = "";
        }
        private void GenerateEmployeeID()
        {
            this.Sql = "select * from employees order by eId desc;";
            Dt = Da.ExecuteQueryTable(this.Sql);
            string eId = Dt.Rows[0]["eId"].ToString();
            string[] str = eId.Split('E');
            int n = Convert.ToInt32(str[1]);
            string neweId = "E" + (++n).ToString("d3");
            idBox.Text = neweId;
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = dataGridView.CurrentRow.Cells["eStatus"].Value?.ToString();
            if (LoggedUser.role == "Manager")
            {
                if (status == "Fired")
                {
                    MessageBox.Show("The Employee has been fired.");
                }
            }
            else
            {
                if (dataGridView.CurrentRow != null)
                {
                    try
                    {
                        this.idBox.Text = dataGridView.CurrentRow.Cells["eId"].Value?.ToString();
                        this.passwordBox.Text = dataGridView.CurrentRow.Cells["ePassword"].Value?.ToString();
                        this.nameBox.Text = dataGridView.CurrentRow.Cells["eName"].Value?.ToString();
                        this.emailBox.Text = dataGridView.CurrentRow.Cells["eEmail"].Value?.ToString();
                        this.salaryBox.Text = dataGridView.CurrentRow.Cells["eSalary"].Value?.ToString();
                        this.genderBox.Text = dataGridView.CurrentRow.Cells["eGender"].Value?.ToString();
                        this.joindateBox.Text = dataGridView.CurrentRow.Cells["eJoinDate"].Value?.ToString();
                        this.roleBox.Text = dataGridView.CurrentRow.Cells["eRole"].Value?.ToString();
                        this.statusBox.Text = dataGridView.CurrentRow.Cells["eStatus"].Value?.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            if (LoggedUser.role == "Manager")
            {
                firedBtn.Visible = false;
                statusBox.Items.AddRange(new string[] { "Unblocked", "Blocked" });
                salaryBox.ReadOnly = true;

            }
            else
            {
                firedBtn.Visible = true;
                statusBox.Items.AddRange(new string[] { "Unblocked", "Blocked","Fired" });
                salaryBox.ReadOnly = false;

            }
        }

        private void FiredBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dataGridView.CurrentRow.Cells["eId"].Value.ToString();
                string name = this.dataGridView.CurrentRow.Cells["eName"].Value.ToString();
                string date = DateTime.Now.ToString();

                this.Sql = "UPDATE employees SET eFireDate='"+date+"', eStatus='" + "Fired" + "' WHERE eId='" + id + "'";
                int added = Da.ExecuteUpdateQuery(this.Sql);

                if (added == 1)
                {
                    MessageBox.Show(name + " has been fired");
                    this.Sql = @"UPDATE users SET status='" + "Fired" + "'" + "WHERE userId='" + id + "'";
                    Da.ExecuteUpdateQuery(this.Sql);

                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") fired " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                    Da.ExecuteUpdateQuery(this.Sql);
                }
                else
                {
                    MessageBox.Show("Employee Fired failed");
                }
                getData();
                ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
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
                    this.Sql = "INSERT INTO employees(eId, ePassword, eName, eEmail, eSalary, eGender, eJoinDate, eFireDate, eRole, eStatus) " +
                    "VALUES('" + id + "','" + pass + "','" + name + "','" + email + "','" + salary + "','" + gender + "','" + date + "','" + "" + "','" + role + "','" + status + "')";
                    int added = Da.ExecuteUpdateQuery(this.Sql);

                    if (added == 1)
                    {
                        MessageBox.Show("New Employee added successfully.");
                        this.Sql = @"INSERT INTO users(userId,password,name,role,status) " + "VALUES('" + id + "','" + pass + "','" + name + "','" + role + "','" + status + "')";
                        Da.ExecuteUpdateQuery(this.Sql);


                        string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") add new " + name + " (" + id + ").";
                        this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                        Da.ExecuteUpdateQuery(this.Sql);
                    }
                    else
                    {
                        MessageBox.Show("Employee data insertion failed");
                    }

                    getData();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.dataGridView.CurrentRow.Cells["eName"].Value.ToString();
                string id = this.dataGridView.CurrentRow.Cells["eId"].Value.ToString();

                this.Sql = @"delete from employees where eId='" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    this.Sql = @"delete from users where userId = '" + id + "';";
                    this.Da.ExecuteUpdateQuery(this.Sql);
                    MessageBox.Show("Employee data has been deleted.");

                    string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") remove " + name + " (" + id + ").";
                    this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";

                    Da.ExecuteUpdateQuery(this.Sql);
                }
                else
                {
                    MessageBox.Show("Data deletion failed");
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
                    this.Sql = "UPDATE employees SET ePassword='" + pass + "', eName='" + name + "', eEmail='" + email + "', eSalary='" + salary + "', eGender='" + gender + "', eJoinDate='" + date + "', eFireDate='', eRole='" + role + "', eStatus='" + status + "' WHERE eId='" + id + "'";
                    int added = Da.ExecuteUpdateQuery(this.Sql);
                    if (added == 1)
                    {
                        MessageBox.Show("Employee details updated.");
                        this.Sql = @"UPDATE users SET password='" + pass + "',name='" + name + "',role='" + role + "',status='" + status + "'" + "WHERE userId='" + id + "'";
                        Da.ExecuteUpdateQuery(this.Sql);

                        string createHistory = LoggedUser.role + " " + LoggedUser.name + " (" + LoggedUser.id + ") update data of " + name + " (" + id + ").";
                        this.Sql = @"INSERT INTO controls(history) " + "VALUES('" + createHistory + "')";
                        Da.ExecuteUpdateQuery(this.Sql);
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

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            ClearAll();

            GenerateEmployeeID();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            this.Sql = "select * from employees where eName like '" + this.searchBox.Text + "%';";
            this.getData(this.Sql);
        }
    }
}
