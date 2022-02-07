using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary_pro.My_Forms
{
    public partial class users_mang : Form
    {
        public users_mang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //------------------------------------------
            if (this.user_name_textBox1.Text == "")
            {
                MessageBox.Show("User Name is empty!!!");
                return;
            }
            //------------------------------------------
            if (this.pass_textBox1.Text != this.pass_confirm_textBox2.Text)
            {
                MessageBox.Show("You must enter same password in both textboxes!");
                return;
            }
            //------------------------------------------
            diary_pro.Properties.Settings.Default.User_name = this.user_name_textBox1.Text;
            diary_pro.Properties.Settings.Default.User_pass = this.pass_textBox1.Text;
            diary_pro.Properties.Settings.Default.Save();
            //-------------------save user pic------------
            if (this.openFileDialog1.FileName!= "openFileDialog1")
            {
                string fn;
               fn = this.openFileDialog1.FileName;
               //--------
               string df;
               df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
               System.IO.File.Copy(fn, df, true);
            }
          
            //--------------------------------------------
            MessageBox.Show("Done!");
        }

        private void users_mang_Load(object sender, EventArgs e)
        {
            //----------------------------------
            user_info_loader();
        }

        public void user_info_loader()
        {

            this.user_name_textBox1.Text = diary_pro.Properties.Settings.Default.User_name;
            this.pass_textBox1.Text = diary_pro.Properties.Settings.Default.User_pass;
            //------------ load user pic -------
            string df;
            df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
            this.pictureBox1.Load(df);
        } 


        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            this.pictureBox1.Load(fn);
        }
    }
}
