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
    public partial class Category : UserControl
    {
        public string catId
        {
            set; get;
        }
        public string catName
        {
            set { name.Text = value; }
            get { return name.Text; }
        }
        public string catStatus
        {
            set; get;
        }
        public string catImage
        {
            set { img.ImageLocation = value; }
            get { return img.ImageLocation; }
        }
        public Category()
        {
            InitializeComponent();
        }
        public event EventHandler categorySelected = null;
        private void Img_Click(object sender, EventArgs e)
        {
            categorySelected?.Invoke(this, EventArgs.Empty);
        }

        private void Name_Click(object sender, EventArgs e)
        {
            
        }
    }
}
