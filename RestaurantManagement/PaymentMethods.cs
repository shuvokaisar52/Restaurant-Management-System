using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml;

namespace RestaurantManagement
{
    public partial class PaymentMethods : UserControl
    {
        public string methodName
        {
            get { return methodNameLabel.Text; }
            set { methodNameLabel.Text = value; }
        }
        public string methodStatus
        {
            get { return methodStatusBox.Text; }
            set { methodStatusBox.Text = value; }
        }
        public PaymentMethods()
        {
            InitializeComponent();
        }

        public event EventHandler saveClicked = null;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
