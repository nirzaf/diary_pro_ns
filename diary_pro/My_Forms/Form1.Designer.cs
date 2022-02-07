namespace diary_pro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.user_name_label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.music_comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cal_day_in_weeklabel8 = new System.Windows.Forms.Label();
            this.cal_day_in_monthlabel7 = new System.Windows.Forms.Label();
            this.cal_month_namelabel6 = new System.Windows.Forms.Label();
            this.cal_year_numlabel5 = new System.Windows.Forms.Label();
            this.timer_label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.back_comboBox1 = new System.Windows.Forms.ComboBox();
            this.version_label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.sett_toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_toolStripButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lock_cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.lock_cm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.timer_label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 772);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.user_name_label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.user_pictureBox1);
            this.panel5.Location = new System.Drawing.Point(4, 389);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 158);
            this.panel5.TabIndex = 7;
            // 
            // user_name_label5
            // 
            this.user_name_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.user_name_label5.ForeColor = System.Drawing.Color.DarkRed;
            this.user_name_label5.Location = new System.Drawing.Point(64, 113);
            this.user_name_label5.Name = "user_name_label5";
            this.user_name_label5.Size = new System.Drawing.Size(115, 26);
            this.user_name_label5.TabIndex = 4;
            this.user_name_label5.Text = "-";
            this.user_name_label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name:";
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.Location = new System.Drawing.Point(25, 3);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(119, 101);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox1.TabIndex = 2;
            this.user_pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.music_comboBox1);
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Location = new System.Drawing.Point(2, 561);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 166);
            this.panel4.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Load";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Music:";
            // 
            // music_comboBox1
            // 
            this.music_comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.music_comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.music_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.music_comboBox1.FormattingEnabled = true;
            this.music_comboBox1.Location = new System.Drawing.Point(43, 137);
            this.music_comboBox1.Name = "music_comboBox1";
            this.music_comboBox1.Size = new System.Drawing.Size(75, 21);
            this.music_comboBox1.TabIndex = 9;
            this.music_comboBox1.SelectedIndexChanged += new System.EventHandler(this.music_comboBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::diary_pro.Properties.Resources.calander;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cal_day_in_weeklabel8);
            this.panel3.Controls.Add(this.cal_day_in_monthlabel7);
            this.panel3.Controls.Add(this.cal_month_namelabel6);
            this.panel3.Controls.Add(this.cal_year_numlabel5);
            this.panel3.Location = new System.Drawing.Point(2, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 189);
            this.panel3.TabIndex = 6;
            // 
            // cal_day_in_weeklabel8
            // 
            this.cal_day_in_weeklabel8.BackColor = System.Drawing.Color.Transparent;
            this.cal_day_in_weeklabel8.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_day_in_weeklabel8.ForeColor = System.Drawing.Color.Black;
            this.cal_day_in_weeklabel8.Location = new System.Drawing.Point(13, 133);
            this.cal_day_in_weeklabel8.Name = "cal_day_in_weeklabel8";
            this.cal_day_in_weeklabel8.Size = new System.Drawing.Size(150, 43);
            this.cal_day_in_weeklabel8.TabIndex = 14;
            this.cal_day_in_weeklabel8.Text = "Sunday";
            this.cal_day_in_weeklabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cal_day_in_monthlabel7
            // 
            this.cal_day_in_monthlabel7.BackColor = System.Drawing.Color.Transparent;
            this.cal_day_in_monthlabel7.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_day_in_monthlabel7.ForeColor = System.Drawing.Color.Black;
            this.cal_day_in_monthlabel7.Location = new System.Drawing.Point(34, 85);
            this.cal_day_in_monthlabel7.Name = "cal_day_in_monthlabel7";
            this.cal_day_in_monthlabel7.Size = new System.Drawing.Size(105, 43);
            this.cal_day_in_monthlabel7.TabIndex = 13;
            this.cal_day_in_monthlabel7.Text = "27";
            this.cal_day_in_monthlabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cal_month_namelabel6
            // 
            this.cal_month_namelabel6.BackColor = System.Drawing.Color.Transparent;
            this.cal_month_namelabel6.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_month_namelabel6.ForeColor = System.Drawing.Color.White;
            this.cal_month_namelabel6.Location = new System.Drawing.Point(65, 44);
            this.cal_month_namelabel6.Name = "cal_month_namelabel6";
            this.cal_month_namelabel6.Size = new System.Drawing.Size(98, 27);
            this.cal_month_namelabel6.TabIndex = 12;
            this.cal_month_namelabel6.Text = "June";
            this.cal_month_namelabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cal_year_numlabel5
            // 
            this.cal_year_numlabel5.AutoSize = true;
            this.cal_year_numlabel5.BackColor = System.Drawing.Color.Transparent;
            this.cal_year_numlabel5.Font = new System.Drawing.Font("Microsoft PhagsPa", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_year_numlabel5.ForeColor = System.Drawing.Color.White;
            this.cal_year_numlabel5.Location = new System.Drawing.Point(9, 45);
            this.cal_year_numlabel5.Name = "cal_year_numlabel5";
            this.cal_year_numlabel5.Size = new System.Drawing.Size(50, 22);
            this.cal_year_numlabel5.TabIndex = 11;
            this.cal_year_numlabel5.Text = "2019";
            // 
            // timer_label1
            // 
            this.timer_label1.BackColor = System.Drawing.Color.Black;
            this.timer_label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.timer_label1.ForeColor = System.Drawing.Color.White;
            this.timer_label1.Location = new System.Drawing.Point(-1, 61);
            this.timer_label1.Name = "timer_label1";
            this.timer_label1.Size = new System.Drawing.Size(179, 45);
            this.timer_label1.TabIndex = 5;
            this.timer_label1.Text = "12:33:20";
            this.timer_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::diary_pro.Properties.Resources.desktop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(1, 739);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show Desktop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.back_comboBox1);
            this.panel2.Controls.Add(this.version_label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(179, 740);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 32);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Background:";
            // 
            // back_comboBox1
            // 
            this.back_comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.back_comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.back_comboBox1.FormattingEnabled = true;
            this.back_comboBox1.Location = new System.Drawing.Point(590, 5);
            this.back_comboBox1.Name = "back_comboBox1";
            this.back_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.back_comboBox1.TabIndex = 7;
            this.back_comboBox1.SelectedIndexChanged += new System.EventHandler(this.back_comboBox1_SelectedIndexChanged);
            // 
            // version_label2
            // 
            this.version_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.version_label2.Location = new System.Drawing.Point(66, 4);
            this.version_label2.Name = "version_label2";
            this.version_label2.Size = new System.Drawing.Size(211, 22);
            this.version_label2.TabIndex = 6;
            this.version_label2.Text = "-";
            this.version_label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.sett_toolStripButton3,
            this.tools_toolStripButton4,
            this.about_toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(179, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(716, 62);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::diary_pro.Properties.Resources.add_memo;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(110, 53);
            this.toolStripButton1.Text = "Add Memo F2";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::diary_pro.Properties.Resources.search_memo;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(110, 53);
            this.toolStripButton2.Text = "Search Memo F3";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // sett_toolStripButton3
            // 
            this.sett_toolStripButton3.AutoSize = false;
            this.sett_toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.sett_toolStripButton3.Image = global::diary_pro.Properties.Resources.settings_alt_32;
            this.sett_toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sett_toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sett_toolStripButton3.Name = "sett_toolStripButton3";
            this.sett_toolStripButton3.Size = new System.Drawing.Size(110, 53);
            this.sett_toolStripButton3.Text = "Settings F4";
            this.sett_toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sett_toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::diary_pro.Properties.Resources.settings_alt_32;
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tools_toolStripButton4
            // 
            this.tools_toolStripButton4.AutoSize = false;
            this.tools_toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.tools_toolStripButton4.Image = global::diary_pro.Properties.Resources.tools;
            this.tools_toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tools_toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_toolStripButton4.Name = "tools_toolStripButton4";
            this.tools_toolStripButton4.Size = new System.Drawing.Size(110, 53);
            this.tools_toolStripButton4.Text = "Tools F5";
            this.tools_toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::diary_pro.Properties.Resources.tools;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // about_toolStripButton5
            // 
            this.about_toolStripButton5.AutoSize = false;
            this.about_toolStripButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.about_toolStripButton5.Image = global::diary_pro.Properties.Resources.about;
            this.about_toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.about_toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.about_toolStripButton5.Name = "about_toolStripButton5";
            this.about_toolStripButton5.Size = new System.Drawing.Size(110, 53);
            this.about_toolStripButton5.Text = "About F6";
            this.about_toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Image = global::diary_pro.Properties.Resources.about;
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(196, 38);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lock_cm
            // 
            this.lock_cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockApplicationToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.lock_cm.Name = "lock_cm";
            this.lock_cm.Size = new System.Drawing.Size(164, 48);
            // 
            // lockApplicationToolStripMenuItem
            // 
            this.lockApplicationToolStripMenuItem.Name = "lockApplicationToolStripMenuItem";
            this.lockApplicationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lockApplicationToolStripMenuItem.Text = "Lock Application";
            this.lockApplicationToolStripMenuItem.Click += new System.EventHandler(this.lockApplicationToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::diary_pro.Properties.Resources.Minimize_butt;
            this.button2.Location = new System.Drawing.Point(844, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::diary_pro.Properties.Resources.Close_butt;
            this.button1.Location = new System.Drawing.Point(869, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(171, 128);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 772);
            this.ContextMenuStrip = this.lock_cm;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kamisha Diary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.lock_cm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton sett_toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tools_toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton about_toolStripButton5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label timer_label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cal_day_in_weeklabel8;
        private System.Windows.Forms.Label cal_day_in_monthlabel7;
        private System.Windows.Forms.Label cal_month_namelabel6;
        private System.Windows.Forms.Label cal_year_numlabel5;
        private System.Windows.Forms.Label version_label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox back_comboBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox music_comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox user_pictureBox1;
        private System.Windows.Forms.Label user_name_label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip lock_cm;
        private System.Windows.Forms.ToolStripMenuItem lockApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

