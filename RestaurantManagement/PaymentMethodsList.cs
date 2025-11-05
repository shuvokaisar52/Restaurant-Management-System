using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantManagement
{
    public partial class PaymentMethodsList : UserControl
    {
        PaymentMethods methods { set; get; }
        private DataAccess Da { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }

        public PaymentMethodsList()
        {
            InitializeComponent();
            Da = new DataAccess();
            getAllMethods();
        }
        private void addMethods(string name, string status)
        {
            try
            {
                methods = new PaymentMethods()
                {
                    methodName = name,
                    methodStatus = status,
                };

                showAllMethodFlow.Controls.Add(methods);

                methods.saveClicked += (sender, args) =>
                {
                    PaymentMethods selected = (PaymentMethods)sender;
                    this.Sql = "UPDATE methods SET methodStatus='" + selected.methodStatus + "' WHERE methodName='" + selected.methodName + "'";

                    int cnt = Da.ExecuteUpdateQuery(this.Sql);
                    if (cnt > 0)
                    {
                        MessageBox.Show("Updated.");
                    }
                };
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
        private void getAllMethods()
        {
            try
            {
                this.Sql = @"SELECT * FROM methods;";
                Dt = Da.ExecuteQueryTable(this.Sql); ;
                showAllMethodFlow.Controls.Clear();
                foreach (DataRow r in Dt.Rows)
                {
                    string name = r["methodName"].ToString();
                    string status = r["methodStatus"].ToString();

                    addMethods(name, status);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            getAllMethods();

        }
    }
}
