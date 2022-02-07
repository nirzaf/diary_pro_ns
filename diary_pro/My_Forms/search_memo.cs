using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diary_pro.My_Forms
{
    public partial class search_memo : Form
    {
        public search_memo()
        {
            InitializeComponent();
        }

        private void search_memo_Load(object sender, EventArgs e)
        {
            //-----------------------------------
            Int32 ic;
            ic = diary_pro.Properties.Settings.Default.last_memo_id  ;


            Int32 i;
            for (  i = 1; i <= ic; i++)
            {
                this.listBox1.Items.Add(i.ToString());
            }
            //----------------------------------
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diary_pro.My_Forms.memo_form mf;
            mf = new My_Forms.memo_form();
            
            mf.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
              //-------------------------------
              string fn;
              string fn_title;
              string fn_date;
              Int32 last_id;
             Int32.TryParse(this.listBox1.Text, out last_id);
              //------------------------------------------------
              fn = Application.StartupPath + "\\data\\docs\\" + last_id.ToString() + ".rtf";
             fn_title = Application.StartupPath + "\\data\\docs\\title_" + last_id.ToString() + ".txt";
             fn_date = Application.StartupPath + "\\data\\docs\\date_" + last_id.ToString() + ".txt";
            //------------------------------------------------.
            this.richTextBox1.LoadFile(fn);
            this.title_textBox1.Text = System.IO.File.ReadAllText(fn_title, Encoding.UTF8);
            this.date_textBox2 .Text = System.IO.File.ReadAllText(fn_date, Encoding.UTF8);
            this.id_textBox1.Text = last_id.ToString();
            //------------------------------------------------
            }
            catch (Exception ex)
            {
                comm_class.my_err_msg(ex.ToString());

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
               Int32 i;
               i = this.listBox1.FindStringExact(this.search_textBox1.Text);
               this.listBox1.SelectedIndex = i;
            }
            catch (Exception ex)
            {
                comm_class.my_err_msg(ex.ToString());

            }
        }
    }
}
