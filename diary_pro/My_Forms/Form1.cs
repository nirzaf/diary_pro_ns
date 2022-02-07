using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if ( MessageBox.Show("Do you want to exit?","Exit",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                 this.Close();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            get_time(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //------------------------------------
               diary_pro.My_Forms.login_form lg_form = new My_Forms.login_form();
                lg_form.ShowDialog();
                //------------------------------------
               get_time();
               //------get the date of system--------
               get_cal();
               //------------------------------------
               this.version_label2.Text = Application.ProductVersion;
               //-----------Load my background images-------------------------
               Int32 si;
               si = diary_pro.Properties.Settings.Default.selected_back_image_index;
               back_image_loader(si);
              //-------------------------------------------------------------
               background_combo_loader();
               this.back_comboBox1.SelectedIndex = si;
              //----------load items to music combobox-------------------------
               music_combo_loader();
              //---------------------------------------------------------------
              //-----------Load my music -------------------------
              Int32 sm;
              sm = diary_pro.Properties.Settings.Default.selected_music_index;
              this.music_comboBox1.SelectedIndex = sm;
              //-------------------------------------------------------------
              //------------ load user info -----------------
              user_info_loader();
              //---------------------------------------------
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

        public void background_combo_loader()
        {
            Int32 i;

            for (  i = 1; i <= 8; i++)
            {
                this.back_comboBox1.Items.Add("Image "+ i.ToString());
            }
        }

        public void music_combo_loader()
        {
            Int32 i;

            for (i = 1; i <= 2; i++)
            {
                this.music_comboBox1.Items.Add("Music " + i.ToString());
            }
        }


        public void back_image_loader(Int32 combo_index)
        {
            string fn;
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\data\\pics\\"+ combo_index.ToString()+".jpg";
            this.BackgroundImage = Image.FromFile(fn);
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }


        public void get_time()
        {
             this.timer_label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        public void get_cal()
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();
            this.cal_year_numlabel5.Text = g.GetYear(DateTime.Now).ToString();
            // this.month_textBox2.Text = g.GetMonth(DateTime.Now).ToString();
            this.cal_day_in_monthlabel7.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            this.cal_day_in_weeklabel8.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            //------------------------------------
            Int32 m;
            string mnum;
            mnum = g.GetMonth(DateTime.Now).ToString();
            Int32.TryParse(mnum, out m);
            //------------------------------------
            this.cal_month_namelabel6.Text = month_num_to_name(m);
        }

        public string month_num_to_name(Int32 month_num)
        {
            string mn;

            switch (month_num)
            {

                case 1:
                    mn = "January";
                    break;

                case 2:
                    mn = "February";
                    break;

                case 3:
                    mn = "March";
                    break;

                case 4:
                    mn = "April";
                    break;

                case 5:
                    mn = "May";
                    break;

                case 6:
                    mn = "June";
                    break;

                case 7:
                    mn = "July";
                    break;

                case 8:
                    mn = "August";
                    break;

                case 9:
                    mn = "September";
                    break;

                case 10:
                    mn = "October";
                    break;

                case 11:
                    mn = "November";
                    break;

                case 12:
                    mn = "December";
                    break;

                default:
                    mn = "Unknown";
                    break;
            }

            return mn;
        }

        private void back_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 si;
            si = this.back_comboBox1.SelectedIndex;
            back_image_loader(si);
            //----------- save the selected image index ------------------
            diary_pro.Properties.Settings.Default.selected_back_image_index = this.back_comboBox1.SelectedIndex;
            diary_pro.Properties.Settings.Default.Save();
            //------------------------------------------------------------
        }

        private void music_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public void music_loader(Int32 combo_index)
        {
             string fn;
            combo_index = combo_index + 1;
            fn = Application.StartupPath + "\\data\\music\\" + combo_index.ToString()+".mp3";
            this.axWindowsMediaPlayer1.URL = fn;
        }

        private void button4_Click(object sender, EventArgs e)
        {
               music_loader(this.music_comboBox1.SelectedIndex);
            diary_pro.Properties.Settings.Default.selected_music_index = this.music_comboBox1.SelectedIndex;
            diary_pro.Properties.Settings.Default.Save();
         }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.about_us ab_form = new  diary_pro.My_Forms.about_us();
            ab_form.MdiParent = this;
            ab_form.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.users_mang us_form = new My_Forms.users_mang();
            us_form.MdiParent = this;
            us_form.Show();
        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //------------------------------------
            diary_pro.My_Forms.login_form lg_form = new My_Forms.login_form();
            lg_form.ShowDialog();
            //------------------------------------
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.memo_form mf;
            mf= new My_Forms.memo_form();
            mf.MdiParent = this;
            mf.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.search_memo sf = new My_Forms.search_memo();
            sf.MdiParent = this;
            sf.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            //---------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            //---------------------------
            if (e.KeyCode == Keys.F4)
            {
                this.sett_toolStripButton3.ShowDropDown();
            }
            //---------------------------
            if (e.KeyCode == Keys.F5)
            {
                this.tools_toolStripButton4.ShowDropDown();
            }
            //---------------------------
            if (e.KeyCode == Keys.F6)
            {
                this.about_toolStripButton5.ShowDropDown();
            }
            //---------------------------
            if (e.KeyCode == Keys.Escape)
            {
                button1_Click(sender, e);
            }
            //---------------------------
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
