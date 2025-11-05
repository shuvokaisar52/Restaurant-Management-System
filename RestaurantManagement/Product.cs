using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RestaurantManagement
{
    public partial class Product : UserControl
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public string proId
        {
            set; get;
        }
        public string proName
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
        public string proCategory
        {
            set; get;
        }
        public string proPrice
        {
            get { return price.Text; }
            set { price.Text = value; }
        }
        public string proStatus
        {
            set; get;
        }
        public string proImage
        {
            get { return img.ImageLocation; }
            set { img.ImageLocation = value; }
        }
        public int proTax
        {
            set; get;
        }
        public int proStock
        {
            set; get;
        }

        public int proQuantity
        {
            get { return int.Parse(quantityBox.Text); }
            set { quantityBox.Text = value.ToString(); }
        }
        public string proPreferences
        {
            get { return preferenceBox.Text; }
            set { preferenceBox.Text = value; }
        }
        public Product()
        {
            InitializeComponent();
            Da = new DataAccess();
            getPreferencs();


        }
        public event EventHandler selected = null;
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            selected?.Invoke(this, EventArgs.Empty);
        }

        internal void getPreferencs()
        {
            try
            {
                this.Sql = @"SELECT productPreferences FROM products WHERE productName = '" + name.Text + "';";
                Ds = Da.ExecuteQuery(this.Sql);

                preferenceBox.Items.Clear();

                if (Ds != null && Ds.Tables[0].Rows.Count > 0)
                {
                    string prefs = Ds.Tables[0].Rows[0]["productPreferences"].ToString();
                    string[] data = prefs.Split(',');
                    foreach (string pref in data)
                    {
                        string selectedPref = proPreferences;
                        string[] part = pref.Split(' ');
                        if (part.Length > 1)
                        {
                            preferenceBox.Items.Add(part[0]);
                        }
                        
                    }
                    if (preferenceBox.Items.Count > 0)
                    {
                        preferenceBox.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void updatePrice()
        {
            try
            {
                this.Sql = @"SELECT productPreferences FROM products WHERE productName = '" + name.Text + "';";
                Ds = Da.ExecuteQuery(this.Sql);

                string selectedPref = preferenceBox.SelectedItem.ToString();

                if (Ds != null && Ds.Tables[0].Rows.Count > 0)
                {
                    string prefs = Ds.Tables[0].Rows[0]["productPreferences"].ToString();
                    string[] data = prefs.Split(',');
                    foreach (string pref in data)
                    {
                        string[] part = pref.Split(' ');
                        if (part[0] == selectedPref)
                        {
                            this.proPrice = part[1];
                            break;
                        }

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void Product_Load(object sender, EventArgs e)
        {
            getPreferencs();
            updatePrice();
        }

        private void PreferenceBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updatePrice();
        }
    }
}
