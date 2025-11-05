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
    public partial class OrderDetails : UserControl
    {
        private DataAccess Da { get; set; }
        private DataTable Dt { get; set; }
        private string Sql { get; set; }
        public OrderDetails()
        {
            InitializeComponent();
            Da = new DataAccess();
        }

        internal void showDetials(string orderid,string payId,string orderby,string date)
        {
            
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        
    }
}
