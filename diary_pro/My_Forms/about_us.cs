using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary_pro.My_Forms
{
    public partial class about_us : Form
    {
        public about_us()
        {
            InitializeComponent();
        }

        private void about_us_Load(object sender, EventArgs e)
        {
            this.co_name_label1.Text = Application.CompanyName;
            this.product_name_label2.Text = "Product Name:" + Application.ProductName;
            this.version_label3.Text = "Version: " + Application.ProductVersion;
            //-------------------load from settings--------------
            this.site_label6.Text = diary_pro.Properties.Settings.Default.company_site_url;
            this.programmer_label7.Text = "Programmer: " +diary_pro.Properties.Settings.Default.Programmer_name;
            this.year_label5.Text = diary_pro.Properties.Settings.Default.Production_year;
            //---------------------------------------------------
        }
    }
}
