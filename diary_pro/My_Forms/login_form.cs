using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary_pro.My_Forms
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            try
            {
                 user_info_loader();
            }
            catch (Exception ex)
            {
                comm_class.my_err_msg(ex.ToString());

            }
           
        }

        public void user_info_loader()
        {

            this.user_name_label5.Text = diary_pro.Properties.Settings.Default.User_name;
            //------------ load user pic -------
            string df;
            df = Application.StartupPath + "\\data\\user_pic\\1.jpg";
            this.user_pictureBox1.Load(df);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a Nice Day Dude!!!");
            Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             //------------------------------------------
            if (this.pass_textBox1.Text == "")
            {
                MessageBox.Show("Password is empty!!!");
                return;
            }
            //------------------------------------------
            if (this.pass_textBox1.Text == diary_pro.Properties.Settings.Default.User_pass)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Your password is not correct.Please try again!");
            }
            }
            catch (Exception ex)
            {
                comm_class.my_err_msg(ex.ToString());

            }
          
        }
    }
}
