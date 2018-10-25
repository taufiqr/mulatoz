namespace WindowsFormsApp2
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "08/06/2018",
            "Barista 1",
            "Arabica Gayo-5KG"}, -1);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Option_Main = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_quit = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.Control_Burner = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Control_AF = new System.Windows.Forms.NumericUpDown();
            this.Control_Suhu = new System.Windows.Forms.NumericUpDown();
            this.Control_Drum = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.lbl_mqttStatus = new System.Windows.Forms.Label();
            this.btn_mqttConnect = new System.Windows.Forms.Button();
            this.tb_brokerIP = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.btn_stopRoast = new System.Windows.Forms.Button();
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.label68 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label62 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_burner = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.cp_burner = new CircularProgressBar.CircularProgressBar();
            this.lbl_drumSpeed = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.cp_drum = new CircularProgressBar.CircularProgressBar();
            this.lbl_airflow = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.cp_airflow = new CircularProgressBar.CircularProgressBar();
            this.lbl_beanTemp = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.cp_temp = new CircularProgressBar.CircularProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_coolend = new System.Windows.Forms.Label();
            this.lbl_drop = new System.Windows.Forms.Label();
            this.lbl_fcend = new System.Windows.Forms.Label();
            this.lbl_fcstart = new System.Windows.Forms.Label();
            this.lbl_dryend = new System.Windows.Forms.Label();
            this.lbl_charge = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.lbl_dev_time = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.lbl_roast_timer = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lv_history = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.lbl_chaff = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.pb_chaff = new System.Windows.Forms.ProgressBar();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.lbl_bearing = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.pb_bearing = new System.Windows.Forms.ProgressBar();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lbl_cooling = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.pb_cooling = new System.Windows.Forms.ProgressBar();
            this.label36 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lbl_chute = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.pb_chute = new System.Windows.Forms.ProgressBar();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.lv_beandata = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_editProfile = new System.Windows.Forms.Button();
            this.lv_profile = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_loadProfile = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.lv_events = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.btn_deluser = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.tb_AUconfirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_AUpass = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tb_AUuser = new System.Windows.Forms.TextBox();
            this.lv_users = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbl_loggedUser = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.Option_Main.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Burner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_AF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Suhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Drum)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.Option_Main);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btn_quit);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 66);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.logo_small;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(6, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 48);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // Option_Main
            // 
            this.Option_Main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Option_Main.Controls.Add(this.button6);
            this.Option_Main.Controls.Add(this.button4);
            this.Option_Main.Controls.Add(this.button5);
            this.Option_Main.Location = new System.Drawing.Point(253, 0);
            this.Option_Main.Name = "Option_Main";
            this.Option_Main.Size = new System.Drawing.Size(784, 53);
            this.Option_Main.TabIndex = 16;
            this.Option_Main.Visible = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(428, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 54);
            this.button6.TabIndex = 15;
            this.button6.Text = "Bean Data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(95, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 54);
            this.button4.TabIndex = 13;
            this.button4.Text = "Roast";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(257, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 54);
            this.button5.TabIndex = 14;
            this.button5.Text = "Monitoring";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(63, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "--/--/----  --:--";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_user.Location = new System.Drawing.Point(63, 3);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(29, 20);
            this.lbl_user.TabIndex = 11;
            this.lbl_user.Text = "----";
            this.lbl_user.TextChanged += new System.EventHandler(this.lbl_user_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.User___0;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1107, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1202, 12);
            this.panel5.TabIndex = 9;
            // 
            // btn_quit
            // 
            this.btn_quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Setting___0;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_quit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quit.Location = new System.Drawing.Point(1154, 6);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(38, 38);
            this.btn_quit.TabIndex = 5;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel7.Controls.Add(this.panel_Control);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Location = new System.Drawing.Point(-1, 585);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1202, 66);
            this.panel7.TabIndex = 2;
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.Control_Burner);
            this.panel_Control.Controls.Add(this.checkBox3);
            this.panel_Control.Controls.Add(this.Control_AF);
            this.panel_Control.Controls.Add(this.Control_Suhu);
            this.panel_Control.Controls.Add(this.Control_Drum);
            this.panel_Control.Controls.Add(this.checkBox2);
            this.panel_Control.Controls.Add(this.panel1);
            this.panel_Control.Controls.Add(this.checkBox1);
            this.panel_Control.Location = new System.Drawing.Point(1, 12);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(850, 55);
            this.panel_Control.TabIndex = 13;
            this.panel_Control.Visible = false;
            // 
            // Control_Burner
            // 
            this.Control_Burner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Burner.Location = new System.Drawing.Point(399, 3);
            this.Control_Burner.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Control_Burner.Name = "Control_Burner";
            this.Control_Burner.Size = new System.Drawing.Size(108, 49);
            this.Control_Burner.TabIndex = 25;
            this.Control_Burner.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Control_Burner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_ValueChanged);
            this.Control_Burner.Move += new System.EventHandler(this.Control_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Drum___1;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox3.FlatAppearance.BorderSize = 0;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(513, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 48);
            this.checkBox3.TabIndex = 69;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);
            // 
            // Control_AF
            // 
            this.Control_AF.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_AF.Location = new System.Drawing.Point(232, 3);
            this.Control_AF.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Control_AF.Name = "Control_AF";
            this.Control_AF.Size = new System.Drawing.Size(108, 49);
            this.Control_AF.TabIndex = 24;
            this.Control_AF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Control_AF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_ValueChanged);
            this.Control_AF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_ValueChanged);
            // 
            // Control_Suhu
            // 
            this.Control_Suhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Suhu.Location = new System.Drawing.Point(66, 3);
            this.Control_Suhu.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Control_Suhu.Name = "Control_Suhu";
            this.Control_Suhu.Size = new System.Drawing.Size(107, 49);
            this.Control_Suhu.TabIndex = 23;
            this.Control_Suhu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Control_Suhu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_ValueChanged);
            this.Control_Suhu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_ValueChanged);
            // 
            // Control_Drum
            // 
            this.Control_Drum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_Drum.Location = new System.Drawing.Point(566, 3);
            this.Control_Drum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Control_Drum.Name = "Control_Drum";
            this.Control_Drum.Size = new System.Drawing.Size(108, 49);
            this.Control_Drum.TabIndex = 22;
            this.Control_Drum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Control_Drum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_ValueChanged);
            this.Control_Drum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_ValueChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Burner___1;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(345, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 48);
            this.checkBox2.TabIndex = 66;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Set_C___0;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 48);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Airflow___1;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(178, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 48);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.History___0;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1107, 18);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 38);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1202, 12);
            this.panel9.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Maintenance___0;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1154, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 38);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage9.Controls.Add(this.checkBox4);
            this.tabPage9.Controls.Add(this.lbl_mqttStatus);
            this.tabPage9.Controls.Add(this.btn_mqttConnect);
            this.tabPage9.Controls.Add(this.tb_brokerIP);
            this.tabPage9.Controls.Add(this.label76);
            this.tabPage9.Controls.Add(this.label7);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1201, 505);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            // 
            // lbl_mqttStatus
            // 
            this.lbl_mqttStatus.AutoSize = true;
            this.lbl_mqttStatus.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_mqttStatus.ForeColor = System.Drawing.Color.White;
            this.lbl_mqttStatus.Location = new System.Drawing.Point(148, 194);
            this.lbl_mqttStatus.Name = "lbl_mqttStatus";
            this.lbl_mqttStatus.Size = new System.Drawing.Size(84, 20);
            this.lbl_mqttStatus.TabIndex = 60;
            this.lbl_mqttStatus.Text = "Status: --";
            // 
            // btn_mqttConnect
            // 
            this.btn_mqttConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.btn_mqttConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mqttConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mqttConnect.Location = new System.Drawing.Point(152, 150);
            this.btn_mqttConnect.Name = "btn_mqttConnect";
            this.btn_mqttConnect.Size = new System.Drawing.Size(241, 41);
            this.btn_mqttConnect.TabIndex = 59;
            this.btn_mqttConnect.Text = "Conncect";
            this.btn_mqttConnect.UseVisualStyleBackColor = false;
            this.btn_mqttConnect.Click += new System.EventHandler(this.btn_mqttConnect_Click);
            // 
            // tb_brokerIP
            // 
            this.tb_brokerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_brokerIP.Location = new System.Drawing.Point(152, 113);
            this.tb_brokerIP.Name = "tb_brokerIP";
            this.tb_brokerIP.Size = new System.Drawing.Size(241, 31);
            this.tb_brokerIP.TabIndex = 49;
            this.tb_brokerIP.Text = "192.168.0.100";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label76.ForeColor = System.Drawing.Color.White;
            this.label76.Location = new System.Drawing.Point(147, 82);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(210, 28);
            this.label76.TabIndex = 52;
            this.label76.Text = "Brower IP Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(551, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 35);
            this.label7.TabIndex = 48;
            this.label7.Text = "Setting";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage8.Controls.Add(this.btn_stopRoast);
            this.tabPage8.Controls.Add(this.plot1);
            this.tabPage8.Controls.Add(this.label68);
            this.tabPage8.Controls.Add(this.numericUpDown3);
            this.tabPage8.Controls.Add(this.numericUpDown4);
            this.tabPage8.Controls.Add(this.label62);
            this.tabPage8.Controls.Add(this.numericUpDown2);
            this.tabPage8.Controls.Add(this.numericUpDown1);
            this.tabPage8.Controls.Add(this.label4);
            this.tabPage8.Controls.Add(this.label3);
            this.tabPage8.Controls.Add(this.label1);
            this.tabPage8.Controls.Add(this.lbl_burner);
            this.tabPage8.Controls.Add(this.label84);
            this.tabPage8.Controls.Add(this.cp_burner);
            this.tabPage8.Controls.Add(this.lbl_drumSpeed);
            this.tabPage8.Controls.Add(this.label86);
            this.tabPage8.Controls.Add(this.cp_drum);
            this.tabPage8.Controls.Add(this.lbl_airflow);
            this.tabPage8.Controls.Add(this.label82);
            this.tabPage8.Controls.Add(this.cp_airflow);
            this.tabPage8.Controls.Add(this.lbl_beanTemp);
            this.tabPage8.Controls.Add(this.label80);
            this.tabPage8.Controls.Add(this.cp_temp);
            this.tabPage8.Controls.Add(this.panel3);
            this.tabPage8.Controls.Add(this.label73);
            this.tabPage8.Controls.Add(this.label74);
            this.tabPage8.Controls.Add(this.label75);
            this.tabPage8.Controls.Add(this.lbl_dev_time);
            this.tabPage8.Controls.Add(this.label77);
            this.tabPage8.Controls.Add(this.lbl_roast_timer);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1201, 505);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            // 
            // btn_stopRoast
            // 
            this.btn_stopRoast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stopRoast.BackColor = System.Drawing.Color.Transparent;
            this.btn_stopRoast.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.stop;
            this.btn_stopRoast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_stopRoast.FlatAppearance.BorderSize = 0;
            this.btn_stopRoast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_stopRoast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_stopRoast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stopRoast.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stopRoast.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_stopRoast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stopRoast.Location = new System.Drawing.Point(903, 44);
            this.btn_stopRoast.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stopRoast.Name = "btn_stopRoast";
            this.btn_stopRoast.Size = new System.Drawing.Size(85, 73);
            this.btn_stopRoast.TabIndex = 17;
            this.btn_stopRoast.UseVisualStyleBackColor = false;
            this.btn_stopRoast.Click += new System.EventHandler(this.btn_stopRoast_Click);
            // 
            // plot1
            // 
            this.plot1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plot1.Location = new System.Drawing.Point(38, 151);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(1010, 262);
            this.plot1.TabIndex = 82;
            this.plot1.Text = "plotView1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Location = new System.Drawing.Point(720, 67);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(81, 28);
            this.label68.TabIndex = 81;
            this.label68.Text = "area 2";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(795, 101);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown3.TabIndex = 80;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(726, 101);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown4.TabIndex = 79;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(719, 10);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(81, 28);
            this.label62.TabIndex = 78;
            this.label62.Text = "area 1";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(794, 44);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 77;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(725, 44);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1110, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "mBar";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1112, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 74;
            this.label3.Text = "RPM";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1110, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "RPM";
            // 
            // lbl_burner
            // 
            this.lbl_burner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_burner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_burner.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.lbl_burner.ForeColor = System.Drawing.Color.White;
            this.lbl_burner.Location = new System.Drawing.Point(1100, 414);
            this.lbl_burner.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_burner.Name = "lbl_burner";
            this.lbl_burner.Size = new System.Drawing.Size(58, 30);
            this.lbl_burner.TabIndex = 72;
            this.lbl_burner.Text = "100";
            this.lbl_burner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_burner.UseWaitCursor = true;
            // 
            // label84
            // 
            this.label84.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label84.ForeColor = System.Drawing.Color.White;
            this.label84.Location = new System.Drawing.Point(1106, 398);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(46, 15);
            this.label84.TabIndex = 71;
            this.label84.Text = "Burner";
            // 
            // cp_burner
            // 
            this.cp_burner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cp_burner.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp_burner.AnimationSpeed = 500;
            this.cp_burner.BackColor = System.Drawing.Color.Transparent;
            this.cp_burner.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_burner.ForeColor = System.Drawing.Color.White;
            this.cp_burner.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.cp_burner.InnerMargin = 2;
            this.cp_burner.InnerWidth = -1;
            this.cp_burner.Location = new System.Drawing.Point(1068, 367);
            this.cp_burner.MarqueeAnimationSpeed = 2000;
            this.cp_burner.Maximum = 5000;
            this.cp_burner.Name = "cp_burner";
            this.cp_burner.OuterColor = System.Drawing.Color.Gray;
            this.cp_burner.OuterMargin = -5;
            this.cp_burner.OuterWidth = 5;
            this.cp_burner.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.cp_burner.ProgressWidth = 5;
            this.cp_burner.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_burner.Size = new System.Drawing.Size(120, 120);
            this.cp_burner.StartAngle = 270;
            this.cp_burner.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_burner.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp_burner.SubscriptText = "";
            this.cp_burner.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_burner.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cp_burner.SuperscriptText = "";
            this.cp_burner.TabIndex = 70;
            this.cp_burner.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cp_burner.Value = 68;
            // 
            // lbl_drumSpeed
            // 
            this.lbl_drumSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_drumSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_drumSpeed.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.lbl_drumSpeed.ForeColor = System.Drawing.Color.White;
            this.lbl_drumSpeed.Location = new System.Drawing.Point(1101, 297);
            this.lbl_drumSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_drumSpeed.Name = "lbl_drumSpeed";
            this.lbl_drumSpeed.Size = new System.Drawing.Size(58, 30);
            this.lbl_drumSpeed.TabIndex = 69;
            this.lbl_drumSpeed.Text = "70";
            this.lbl_drumSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_drumSpeed.UseWaitCursor = true;
            // 
            // label86
            // 
            this.label86.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label86.ForeColor = System.Drawing.Color.White;
            this.label86.Location = new System.Drawing.Point(1091, 282);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(80, 15);
            this.label86.TabIndex = 68;
            this.label86.Text = "Drum Speed";
            // 
            // cp_drum
            // 
            this.cp_drum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cp_drum.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp_drum.AnimationSpeed = 500;
            this.cp_drum.BackColor = System.Drawing.Color.Transparent;
            this.cp_drum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_drum.ForeColor = System.Drawing.Color.White;
            this.cp_drum.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.cp_drum.InnerMargin = 2;
            this.cp_drum.InnerWidth = -1;
            this.cp_drum.Location = new System.Drawing.Point(1068, 248);
            this.cp_drum.MarqueeAnimationSpeed = 2000;
            this.cp_drum.Maximum = 1000;
            this.cp_drum.Name = "cp_drum";
            this.cp_drum.OuterColor = System.Drawing.Color.Gray;
            this.cp_drum.OuterMargin = -5;
            this.cp_drum.OuterWidth = 5;
            this.cp_drum.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.cp_drum.ProgressWidth = 5;
            this.cp_drum.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_drum.Size = new System.Drawing.Size(120, 120);
            this.cp_drum.StartAngle = 270;
            this.cp_drum.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_drum.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp_drum.SubscriptText = "";
            this.cp_drum.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_drum.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cp_drum.SuperscriptText = "";
            this.cp_drum.TabIndex = 67;
            this.cp_drum.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cp_drum.Value = 68;
            // 
            // lbl_airflow
            // 
            this.lbl_airflow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_airflow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_airflow.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.lbl_airflow.ForeColor = System.Drawing.Color.White;
            this.lbl_airflow.Location = new System.Drawing.Point(1100, 174);
            this.lbl_airflow.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_airflow.Name = "lbl_airflow";
            this.lbl_airflow.Size = new System.Drawing.Size(58, 30);
            this.lbl_airflow.TabIndex = 66;
            this.lbl_airflow.Text = "750";
            this.lbl_airflow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_airflow.UseWaitCursor = true;
            // 
            // label82
            // 
            this.label82.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label82.ForeColor = System.Drawing.Color.White;
            this.label82.Location = new System.Drawing.Point(1103, 159);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(54, 15);
            this.label82.TabIndex = 65;
            this.label82.Text = "Air Flow";
            // 
            // cp_airflow
            // 
            this.cp_airflow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cp_airflow.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp_airflow.AnimationSpeed = 500;
            this.cp_airflow.BackColor = System.Drawing.Color.Transparent;
            this.cp_airflow.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_airflow.ForeColor = System.Drawing.Color.White;
            this.cp_airflow.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.cp_airflow.InnerMargin = 2;
            this.cp_airflow.InnerWidth = -1;
            this.cp_airflow.Location = new System.Drawing.Point(1068, 129);
            this.cp_airflow.MarqueeAnimationSpeed = 2000;
            this.cp_airflow.Maximum = 1000;
            this.cp_airflow.Name = "cp_airflow";
            this.cp_airflow.OuterColor = System.Drawing.Color.Gray;
            this.cp_airflow.OuterMargin = -5;
            this.cp_airflow.OuterWidth = 5;
            this.cp_airflow.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.cp_airflow.ProgressWidth = 5;
            this.cp_airflow.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_airflow.Size = new System.Drawing.Size(120, 120);
            this.cp_airflow.StartAngle = 270;
            this.cp_airflow.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_airflow.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp_airflow.SubscriptText = "";
            this.cp_airflow.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_airflow.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cp_airflow.SuperscriptText = "";
            this.cp_airflow.TabIndex = 64;
            this.cp_airflow.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cp_airflow.Value = 68;
            // 
            // lbl_beanTemp
            // 
            this.lbl_beanTemp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_beanTemp.AutoSize = true;
            this.lbl_beanTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_beanTemp.Font = new System.Drawing.Font("Meiryo UI", 18F);
            this.lbl_beanTemp.ForeColor = System.Drawing.Color.White;
            this.lbl_beanTemp.Location = new System.Drawing.Point(1097, 62);
            this.lbl_beanTemp.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_beanTemp.Name = "lbl_beanTemp";
            this.lbl_beanTemp.Size = new System.Drawing.Size(71, 30);
            this.lbl_beanTemp.TabIndex = 63;
            this.lbl_beanTemp.Text = "120°";
            this.lbl_beanTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_beanTemp.UseWaitCursor = true;
            // 
            // label80
            // 
            this.label80.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.label80.ForeColor = System.Drawing.Color.White;
            this.label80.Location = new System.Drawing.Point(1091, 44);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(77, 15);
            this.label80.TabIndex = 62;
            this.label80.Text = "Bean Temp.";
            // 
            // cp_temp
            // 
            this.cp_temp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cp_temp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cp_temp.AnimationSpeed = 500;
            this.cp_temp.BackColor = System.Drawing.Color.Transparent;
            this.cp_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_temp.ForeColor = System.Drawing.Color.White;
            this.cp_temp.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.cp_temp.InnerMargin = 2;
            this.cp_temp.InnerWidth = -1;
            this.cp_temp.Location = new System.Drawing.Point(1068, 10);
            this.cp_temp.MarqueeAnimationSpeed = 2000;
            this.cp_temp.Maximum = 500;
            this.cp_temp.Name = "cp_temp";
            this.cp_temp.OuterColor = System.Drawing.Color.Gray;
            this.cp_temp.OuterMargin = -5;
            this.cp_temp.OuterWidth = 5;
            this.cp_temp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.cp_temp.ProgressWidth = 5;
            this.cp_temp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cp_temp.Size = new System.Drawing.Size(120, 120);
            this.cp_temp.StartAngle = 270;
            this.cp_temp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_temp.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cp_temp.SubscriptText = "";
            this.cp_temp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cp_temp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cp_temp.SuperscriptText = "";
            this.cp_temp.TabIndex = 61;
            this.cp_temp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cp_temp.Value = 68;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.lbl_coolend);
            this.panel3.Controls.Add(this.lbl_drop);
            this.panel3.Controls.Add(this.lbl_fcend);
            this.panel3.Controls.Add(this.lbl_fcstart);
            this.panel3.Controls.Add(this.lbl_dryend);
            this.panel3.Controls.Add(this.lbl_charge);
            this.panel3.Location = new System.Drawing.Point(119, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 44);
            this.panel3.TabIndex = 60;
            // 
            // lbl_coolend
            // 
            this.lbl_coolend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_coolend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.lbl_coolend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_coolend.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_coolend.ForeColor = System.Drawing.Color.White;
            this.lbl_coolend.Location = new System.Drawing.Point(723, 2);
            this.lbl_coolend.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_coolend.Name = "lbl_coolend";
            this.lbl_coolend.Size = new System.Drawing.Size(143, 40);
            this.lbl_coolend.TabIndex = 55;
            this.lbl_coolend.Text = "Cool End: 00:00";
            this.lbl_coolend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_coolend.Click += new System.EventHandler(this.lbl_coolend_Click);
            // 
            // lbl_drop
            // 
            this.lbl_drop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_drop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.lbl_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_drop.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_drop.ForeColor = System.Drawing.Color.White;
            this.lbl_drop.Location = new System.Drawing.Point(579, 2);
            this.lbl_drop.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_drop.Name = "lbl_drop";
            this.lbl_drop.Size = new System.Drawing.Size(143, 40);
            this.lbl_drop.TabIndex = 54;
            this.lbl_drop.Text = "Drop: 00:00";
            this.lbl_drop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_drop.Click += new System.EventHandler(this.lbl_drop_Click);
            // 
            // lbl_fcend
            // 
            this.lbl_fcend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fcend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.lbl_fcend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fcend.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_fcend.ForeColor = System.Drawing.Color.White;
            this.lbl_fcend.Location = new System.Drawing.Point(435, 2);
            this.lbl_fcend.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_fcend.Name = "lbl_fcend";
            this.lbl_fcend.Size = new System.Drawing.Size(143, 40);
            this.lbl_fcend.TabIndex = 53;
            this.lbl_fcend.Text = "FC End: 00:00";
            this.lbl_fcend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fcend.Click += new System.EventHandler(this.lbl_fcend_Click);
            // 
            // lbl_fcstart
            // 
            this.lbl_fcstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fcstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.lbl_fcstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fcstart.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_fcstart.ForeColor = System.Drawing.Color.White;
            this.lbl_fcstart.Location = new System.Drawing.Point(291, 2);
            this.lbl_fcstart.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_fcstart.Name = "lbl_fcstart";
            this.lbl_fcstart.Size = new System.Drawing.Size(143, 40);
            this.lbl_fcstart.TabIndex = 52;
            this.lbl_fcstart.Text = "FC Start: 00:00";
            this.lbl_fcstart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_fcstart.Click += new System.EventHandler(this.lbl_fcstart_Click);
            // 
            // lbl_dryend
            // 
            this.lbl_dryend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dryend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.lbl_dryend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dryend.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_dryend.ForeColor = System.Drawing.Color.White;
            this.lbl_dryend.Location = new System.Drawing.Point(147, 2);
            this.lbl_dryend.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dryend.Name = "lbl_dryend";
            this.lbl_dryend.Size = new System.Drawing.Size(143, 40);
            this.lbl_dryend.TabIndex = 51;
            this.lbl_dryend.Text = "Dry End: 00:00";
            this.lbl_dryend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_dryend.Click += new System.EventHandler(this.lbl_dryend_Click);
            // 
            // lbl_charge
            // 
            this.lbl_charge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_charge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.lbl_charge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_charge.Font = new System.Drawing.Font("Meiryo UI", 12F);
            this.lbl_charge.ForeColor = System.Drawing.Color.White;
            this.lbl_charge.Location = new System.Drawing.Point(3, 2);
            this.lbl_charge.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_charge.Name = "lbl_charge";
            this.lbl_charge.Size = new System.Drawing.Size(143, 40);
            this.lbl_charge.TabIndex = 50;
            this.lbl_charge.Text = "Charge: 00:00";
            this.lbl_charge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_charge.Click += new System.EventHandler(this.lbl_charge_Click);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label73.ForeColor = System.Drawing.Color.White;
            this.label73.Location = new System.Drawing.Point(483, 94);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(112, 35);
            this.label73.TabIndex = 59;
            this.label73.Text = "RoR/30";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label74.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 52F);
            this.label74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label74.Location = new System.Drawing.Point(467, 10);
            this.label74.Margin = new System.Windows.Forms.Padding(0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(123, 70);
            this.label74.TabIndex = 58;
            this.label74.Text = "2.5°";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label75.ForeColor = System.Drawing.Color.White;
            this.label75.Location = new System.Drawing.Point(280, 94);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(147, 35);
            this.label75.TabIndex = 57;
            this.label75.Text = "Dev. Time";
            // 
            // lbl_dev_time
            // 
            this.lbl_dev_time.AutoSize = true;
            this.lbl_dev_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dev_time.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 52F);
            this.lbl_dev_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.lbl_dev_time.Location = new System.Drawing.Point(264, 10);
            this.lbl_dev_time.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_dev_time.Name = "lbl_dev_time";
            this.lbl_dev_time.Size = new System.Drawing.Size(160, 70);
            this.lbl_dev_time.TabIndex = 56;
            this.lbl_dev_time.Text = "00:00";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(73, 94);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(162, 35);
            this.label77.TabIndex = 55;
            this.label77.Text = "Roast Time";
            // 
            // lbl_roast_timer
            // 
            this.lbl_roast_timer.AutoSize = true;
            this.lbl_roast_timer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_roast_timer.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 52F);
            this.lbl_roast_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.lbl_roast_timer.Location = new System.Drawing.Point(57, 10);
            this.lbl_roast_timer.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_roast_timer.Name = "lbl_roast_timer";
            this.lbl_roast_timer.Size = new System.Drawing.Size(160, 70);
            this.lbl_roast_timer.TabIndex = 54;
            this.lbl_roast_timer.Text = "00:00";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage5.Controls.Add(this.lv_history);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1201, 505);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            // 
            // lv_history
            // 
            this.lv_history.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.lv_history.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_history.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.operate,
            this.proName});
            this.lv_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_history.ForeColor = System.Drawing.SystemColors.Window;
            this.lv_history.FullRowSelect = true;
            this.lv_history.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_history.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8});
            this.lv_history.Location = new System.Drawing.Point(210, 11);
            this.lv_history.Name = "lv_history";
            this.lv_history.Size = new System.Drawing.Size(810, 480);
            this.lv_history.TabIndex = 0;
            this.lv_history.UseCompatibleStateImageBehavior = false;
            this.lv_history.View = System.Windows.Forms.View.Details;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 160;
            // 
            // operate
            // 
            this.operate.Text = "Operator";
            this.operate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.operate.Width = 325;
            // 
            // proName
            // 
            this.proName.Text = "Profile Name";
            this.proName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.proName.Width = 325;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.label44);
            this.tabPage4.Controls.Add(this.lbl_chaff);
            this.tabPage4.Controls.Add(this.label46);
            this.tabPage4.Controls.Add(this.label47);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.pb_chaff);
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.label50);
            this.tabPage4.Controls.Add(this.lbl_bearing);
            this.tabPage4.Controls.Add(this.label52);
            this.tabPage4.Controls.Add(this.label53);
            this.tabPage4.Controls.Add(this.label54);
            this.tabPage4.Controls.Add(this.pb_bearing);
            this.tabPage4.Controls.Add(this.label37);
            this.tabPage4.Controls.Add(this.label38);
            this.tabPage4.Controls.Add(this.lbl_cooling);
            this.tabPage4.Controls.Add(this.label40);
            this.tabPage4.Controls.Add(this.label41);
            this.tabPage4.Controls.Add(this.label42);
            this.tabPage4.Controls.Add(this.pb_cooling);
            this.tabPage4.Controls.Add(this.label36);
            this.tabPage4.Controls.Add(this.label34);
            this.tabPage4.Controls.Add(this.lbl_chute);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.pb_chute);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button10);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1201, 505);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label43.AutoSize = true;
            this.label43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label43.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label43.Location = new System.Drawing.Point(640, 336);
            this.label43.Margin = new System.Windows.Forms.Padding(0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(275, 48);
            this.label43.TabIndex = 68;
            this.label43.Text = "Chaff Container";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label44
            // 
            this.label44.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(967, 280);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 35);
            this.label44.TabIndex = 67;
            this.label44.Text = "%";
            // 
            // lbl_chaff
            // 
            this.lbl_chaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_chaff.AutoSize = true;
            this.lbl_chaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_chaff.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.lbl_chaff.Location = new System.Drawing.Point(875, 240);
            this.lbl_chaff.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_chaff.Name = "lbl_chaff";
            this.lbl_chaff.Size = new System.Drawing.Size(115, 81);
            this.lbl_chaff.TabIndex = 66;
            this.lbl_chaff.Text = "70";
            // 
            // label46
            // 
            this.label46.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label46.AutoSize = true;
            this.label46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label46.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label46.ForeColor = System.Drawing.Color.Gray;
            this.label46.Location = new System.Drawing.Point(745, 285);
            this.label46.Margin = new System.Windows.Forms.Padding(0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(76, 35);
            this.label46.TabIndex = 65;
            this.label46.Text = "hour";
            // 
            // label47
            // 
            this.label47.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label47.AutoSize = true;
            this.label47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label47.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label47.Location = new System.Drawing.Point(678, 286);
            this.label47.Margin = new System.Windows.Forms.Padding(0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(58, 35);
            this.label47.TabIndex = 64;
            this.label47.Text = "5.8";
            // 
            // label48
            // 
            this.label48.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label48.AutoSize = true;
            this.label48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label48.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(642, 285);
            this.label48.Margin = new System.Windows.Forms.Padding(0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(44, 35);
            this.label48.TabIndex = 63;
            this.label48.Text = "8/";
            // 
            // pb_chaff
            // 
            this.pb_chaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_chaff.Location = new System.Drawing.Point(648, 323);
            this.pb_chaff.Name = "pb_chaff";
            this.pb_chaff.Size = new System.Drawing.Size(372, 10);
            this.pb_chaff.Step = 1;
            this.pb_chaff.TabIndex = 61;
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label49.AutoSize = true;
            this.label49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label49.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(640, 144);
            this.label49.Margin = new System.Windows.Forms.Padding(0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(241, 48);
            this.label49.TabIndex = 60;
            this.label49.Text = "Front Bearing";
            // 
            // label50
            // 
            this.label50.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(967, 88);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(43, 35);
            this.label50.TabIndex = 59;
            this.label50.Text = "%";
            // 
            // lbl_bearing
            // 
            this.lbl_bearing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_bearing.AutoSize = true;
            this.lbl_bearing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_bearing.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bearing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.lbl_bearing.Location = new System.Drawing.Point(875, 48);
            this.lbl_bearing.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_bearing.Name = "lbl_bearing";
            this.lbl_bearing.Size = new System.Drawing.Size(115, 81);
            this.lbl_bearing.TabIndex = 58;
            this.lbl_bearing.Text = "70";
            // 
            // label52
            // 
            this.label52.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label52.AutoSize = true;
            this.label52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label52.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label52.ForeColor = System.Drawing.Color.Gray;
            this.label52.Location = new System.Drawing.Point(745, 93);
            this.label52.Margin = new System.Windows.Forms.Padding(0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(76, 35);
            this.label52.TabIndex = 57;
            this.label52.Text = "hour";
            // 
            // label53
            // 
            this.label53.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label53.AutoSize = true;
            this.label53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label53.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label53.Location = new System.Drawing.Point(694, 93);
            this.label53.Margin = new System.Windows.Forms.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(49, 35);
            this.label53.TabIndex = 56;
            this.label53.Text = "28";
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label54.AutoSize = true;
            this.label54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label54.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(642, 93);
            this.label54.Margin = new System.Windows.Forms.Padding(0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(61, 35);
            this.label54.TabIndex = 55;
            this.label54.Text = "40/";
            // 
            // pb_bearing
            // 
            this.pb_bearing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_bearing.Location = new System.Drawing.Point(648, 131);
            this.pb_bearing.Name = "pb_bearing";
            this.pb_bearing.Size = new System.Drawing.Size(372, 10);
            this.pb_bearing.Step = 1;
            this.pb_bearing.TabIndex = 53;
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label37.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label37.Location = new System.Drawing.Point(107, 336);
            this.label37.Margin = new System.Windows.Forms.Padding(0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(219, 48);
            this.label37.TabIndex = 52;
            this.label37.Text = "Cooling Unit";
            this.label37.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(434, 280);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(43, 35);
            this.label38.TabIndex = 51;
            this.label38.Text = "%";
            // 
            // lbl_cooling
            // 
            this.lbl_cooling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_cooling.AutoSize = true;
            this.lbl_cooling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cooling.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cooling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.lbl_cooling.Location = new System.Drawing.Point(342, 240);
            this.lbl_cooling.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_cooling.Name = "lbl_cooling";
            this.lbl_cooling.Size = new System.Drawing.Size(115, 81);
            this.lbl_cooling.TabIndex = 50;
            this.lbl_cooling.Text = "70";
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label40.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label40.ForeColor = System.Drawing.Color.Gray;
            this.label40.Location = new System.Drawing.Point(212, 285);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(76, 35);
            this.label40.TabIndex = 49;
            this.label40.Text = "hour";
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label41.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label41.Location = new System.Drawing.Point(145, 286);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(58, 35);
            this.label41.TabIndex = 48;
            this.label41.Text = "5.8";
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label42.AutoSize = true;
            this.label42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label42.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(109, 285);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(44, 35);
            this.label42.TabIndex = 47;
            this.label42.Text = "8/";
            // 
            // pb_cooling
            // 
            this.pb_cooling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_cooling.Location = new System.Drawing.Point(115, 323);
            this.pb_cooling.Name = "pb_cooling";
            this.pb_cooling.Size = new System.Drawing.Size(372, 10);
            this.pb_cooling.Step = 1;
            this.pb_cooling.TabIndex = 45;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label36.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(107, 144);
            this.label36.Margin = new System.Windows.Forms.Padding(0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(208, 48);
            this.label36.TabIndex = 44;
            this.label36.Text = "Input Chute";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(434, 88);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(43, 35);
            this.label34.TabIndex = 43;
            this.label34.Text = "%";
            // 
            // lbl_chute
            // 
            this.lbl_chute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_chute.AutoSize = true;
            this.lbl_chute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_chute.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.lbl_chute.Location = new System.Drawing.Point(342, 48);
            this.lbl_chute.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_chute.Name = "lbl_chute";
            this.lbl_chute.Size = new System.Drawing.Size(115, 81);
            this.lbl_chute.TabIndex = 42;
            this.lbl_chute.Text = "70";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label33.ForeColor = System.Drawing.Color.Gray;
            this.label33.Location = new System.Drawing.Point(212, 93);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 35);
            this.label33.TabIndex = 41;
            this.label33.Text = "hour";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label32.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label32.Location = new System.Drawing.Point(161, 93);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 35);
            this.label32.TabIndex = 40;
            this.label32.Text = "28";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label31.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(109, 93);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(61, 35);
            this.label31.TabIndex = 39;
            this.label31.Text = "40/";
            // 
            // pb_chute
            // 
            this.pb_chute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_chute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.pb_chute.Location = new System.Drawing.Point(115, 131);
            this.pb_chute.Name = "pb_chute";
            this.pb_chute.Size = new System.Drawing.Size(372, 10);
            this.pb_chute.Step = 1;
            this.pb_chute.TabIndex = 0;
            this.pb_chute.Value = 50;
            this.pb_chute.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Reset_hour___0;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(1023, 299);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 57);
            this.button9.TabIndex = 62;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Reset_hour___0;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(1023, 107);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 57);
            this.button10.TabIndex = 54;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Reset_hour___0;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(490, 299);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 57);
            this.button7.TabIndex = 46;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Reset_hour___0;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(490, 107);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 57);
            this.button8.TabIndex = 16;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage3.Controls.Add(this.pictureBox12);
            this.tabPage3.Controls.Add(this.pictureBox11);
            this.tabPage3.Controls.Add(this.pictureBox10);
            this.tabPage3.Controls.Add(this.pictureBox9);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.circularProgressBar3);
            this.tabPage3.Controls.Add(this.circularProgressBar4);
            this.tabPage3.Controls.Add(this.circularProgressBar2);
            this.tabPage3.Controls.Add(this.circularProgressBar1);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1201, 505);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox12.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Burner___1;
            this.pictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox12.Location = new System.Drawing.Point(943, 213);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(40, 52);
            this.pictureBox12.TabIndex = 39;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox11.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Drum___1;
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Location = new System.Drawing.Point(648, 213);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(40, 52);
            this.pictureBox11.TabIndex = 39;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox10.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Airflow___1;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Location = new System.Drawing.Point(345, 213);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(40, 52);
            this.pictureBox10.TabIndex = 39;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox9.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Set_C___0;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox9.Location = new System.Drawing.Point(50, 213);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 52);
            this.pictureBox9.TabIndex = 39;
            this.pictureBox9.TabStop = false;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label28.Location = new System.Drawing.Point(176, 291);
            this.label28.Margin = new System.Windows.Forms.Padding(0);
            this.label28.Name = "label28";
            this.label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label28.Size = new System.Drawing.Size(30, 24);
            this.label28.TabIndex = 31;
            this.label28.Text = "%";
            this.label28.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label29.Location = new System.Drawing.Point(130, 278);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label29.Size = new System.Drawing.Size(58, 41);
            this.label29.TabIndex = 30;
            this.label29.Text = "70";
            this.label29.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label30.Location = new System.Drawing.Point(117, 257);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(81, 20);
            this.label30.TabIndex = 29;
            this.label30.Text = "Set Value";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label25.Location = new System.Drawing.Point(467, 299);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label25.Size = new System.Drawing.Size(30, 24);
            this.label25.TabIndex = 28;
            this.label25.Text = "%";
            this.label25.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label26.Location = new System.Drawing.Point(421, 286);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label26.Size = new System.Drawing.Size(58, 41);
            this.label26.TabIndex = 27;
            this.label26.Text = "70";
            this.label26.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label27.Location = new System.Drawing.Point(408, 265);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(81, 20);
            this.label27.TabIndex = 26;
            this.label27.Text = "Set Value";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label22.Location = new System.Drawing.Point(1064, 295);
            this.label22.Margin = new System.Windows.Forms.Padding(0);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(30, 24);
            this.label22.TabIndex = 25;
            this.label22.Text = "%";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label23.Location = new System.Drawing.Point(1018, 282);
            this.label23.Margin = new System.Windows.Forms.Padding(0);
            this.label23.Name = "label23";
            this.label23.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label23.Size = new System.Drawing.Size(58, 41);
            this.label23.TabIndex = 24;
            this.label23.Text = "70";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label24.Location = new System.Drawing.Point(1005, 261);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 20);
            this.label24.TabIndex = 23;
            this.label24.Text = "Set Value";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Meiryo UI", 14F);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label21.Location = new System.Drawing.Point(770, 299);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label21.Size = new System.Drawing.Size(30, 24);
            this.label21.TabIndex = 22;
            this.label21.Text = "%";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label20.Location = new System.Drawing.Point(724, 286);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(58, 41);
            this.label20.TabIndex = 18;
            this.label20.Text = "70";
            this.label20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.label19.Location = new System.Drawing.Point(711, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 20);
            this.label19.TabIndex = 17;
            this.label19.Text = "Set Value";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1105, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "mBar";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(973, 172);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label17.Size = new System.Drawing.Size(155, 81);
            this.label17.TabIndex = 15;
            this.label17.Text = "100";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1014, 135);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "Burner";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(809, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "RPM";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(691, 172);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(115, 81);
            this.label14.TabIndex = 12;
            this.label14.Text = "70";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(698, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Drum Speed";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(215, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "o";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(514, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "RPM";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(377, 172);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 81);
            this.label9.TabIndex = 8;
            this.label9.Text = "750";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(417, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Air Flow";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(79, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 81);
            this.label8.TabIndex = 5;
            this.label8.Text = "120";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bean Temp.";
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(900, 93);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.OuterMargin = -25;
            this.circularProgressBar3.OuterWidth = 26;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.circularProgressBar3.ProgressWidth = 25;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar3.Size = new System.Drawing.Size(290, 290);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = ".23";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "°C";
            this.circularProgressBar3.TabIndex = 3;
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar3.Value = 68;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar4.AnimationSpeed = 500;
            this.circularProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.circularProgressBar4.InnerMargin = 2;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(604, 93);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar4.OuterMargin = -25;
            this.circularProgressBar4.OuterWidth = 26;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.circularProgressBar4.ProgressWidth = 25;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar4.Size = new System.Drawing.Size(290, 290);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar4.SubscriptText = ".23";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar4.SuperscriptText = "°C";
            this.circularProgressBar4.TabIndex = 2;
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar4.Value = 68;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(308, 93);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar2.Size = new System.Drawing.Size(290, 290);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = ".23";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "°C";
            this.circularProgressBar2.TabIndex = 1;
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(12, 93);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(100)))), ((int)(((byte)(57)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(290, 290);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 0;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Set_C___0;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(50, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 52);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Burner___1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(943, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 52);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Drum___1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(648, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 52);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Airflow___1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(346, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 52);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.lv_beandata);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1201, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // button17
            // 
            this.button17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.Location = new System.Drawing.Point(673, 442);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(119, 52);
            this.button17.TabIndex = 17;
            this.button17.Text = "Delete";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button16.Location = new System.Drawing.Point(548, 442);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(119, 52);
            this.button16.TabIndex = 16;
            this.button16.Text = "Edit";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(423, 442);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(119, 52);
            this.button14.TabIndex = 15;
            this.button14.Text = "Add";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // lv_beandata
            // 
            this.lv_beandata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_beandata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.lv_beandata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_beandata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lv_beandata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_beandata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.lv_beandata.FullRowSelect = true;
            this.lv_beandata.Location = new System.Drawing.Point(41, 37);
            this.lv_beandata.MultiSelect = false;
            this.lv_beandata.Name = "lv_beandata";
            this.lv_beandata.Size = new System.Drawing.Size(1120, 400);
            this.lv_beandata.TabIndex = 3;
            this.lv_beandata.UseCompatibleStateImageBehavior = false;
            this.lv_beandata.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Bean Name";
            this.columnHeader1.Width = 123;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "Bean Type";
            this.columnHeader.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Input Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Country";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Region";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 162;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Process";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 146;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Screen SIze";
            this.columnHeader6.Width = 116;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Moisture";
            this.columnHeader7.Width = 112;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Vendor";
            this.columnHeader8.Width = 95;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage1.Controls.Add(this.btn_editProfile);
            this.tabPage1.Controls.Add(this.lv_profile);
            this.tabPage1.Controls.Add(this.btn_loadProfile);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.lv_events);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1201, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // btn_editProfile
            // 
            this.btn_editProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_editProfile.FlatAppearance.BorderSize = 0;
            this.btn_editProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_editProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_editProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editProfile.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editProfile.Location = new System.Drawing.Point(420, 440);
            this.btn_editProfile.Name = "btn_editProfile";
            this.btn_editProfile.Size = new System.Drawing.Size(200, 54);
            this.btn_editProfile.TabIndex = 20;
            this.btn_editProfile.Text = "Edit Profile";
            this.btn_editProfile.UseVisualStyleBackColor = true;
            this.btn_editProfile.Click += new System.EventHandler(this.btn_editProfile_Click);
            // 
            // lv_profile
            // 
            this.lv_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.lv_profile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_profile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader9});
            this.lv_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.lv_profile.FullRowSelect = true;
            this.lv_profile.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_profile.Location = new System.Drawing.Point(161, 6);
            this.lv_profile.MultiSelect = false;
            this.lv_profile.Name = "lv_profile";
            this.lv_profile.Size = new System.Drawing.Size(411, 430);
            this.lv_profile.TabIndex = 19;
            this.lv_profile.UseCompatibleStateImageBehavior = false;
            this.lv_profile.View = System.Windows.Forms.View.Details;
            this.lv_profile.SelectedIndexChanged += new System.EventHandler(this.lv_profile_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 1;
            this.columnHeader10.Text = "Profile";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 198;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 0;
            this.columnHeader9.Text = "Date";
            this.columnHeader9.Width = 209;
            // 
            // btn_loadProfile
            // 
            this.btn_loadProfile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_loadProfile.FlatAppearance.BorderSize = 0;
            this.btn_loadProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_loadProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.btn_loadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadProfile.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_loadProfile.Location = new System.Drawing.Point(626, 440);
            this.btn_loadProfile.Name = "btn_loadProfile";
            this.btn_loadProfile.Size = new System.Drawing.Size(200, 54);
            this.btn_loadProfile.TabIndex = 18;
            this.btn_loadProfile.Text = "Load Profile";
            this.btn_loadProfile.UseVisualStyleBackColor = true;
            this.btn_loadProfile.Click += new System.EventHandler(this.button20_Click);
            // 
            // button13
            // 
            this.button13.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(832, 440);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(224, 54);
            this.button13.TabIndex = 17;
            this.button13.Text = "Start Roasting";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(192, 440);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(222, 54);
            this.button11.TabIndex = 16;
            this.button11.Text = "New Profile";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // lv_events
            // 
            this.lv_events.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.lv_events.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Temperature,
            this.Event});
            this.lv_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_events.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.lv_events.Location = new System.Drawing.Point(616, 6);
            this.lv_events.Name = "lv_events";
            this.lv_events.Size = new System.Drawing.Size(469, 430);
            this.lv_events.TabIndex = 2;
            this.lv_events.UseCompatibleStateImageBehavior = false;
            this.lv_events.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 123;
            // 
            // Temperature
            // 
            this.Temperature.Text = "Temperature";
            this.Temperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Temperature.Width = 177;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Event.Width = 166;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Location = new System.Drawing.Point(-4, 60);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 534);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage7.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.logo;
            this.tabPage7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1201, 505);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage6.Controls.Add(this.panel13);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1201, 505);
            this.tabPage6.TabIndex = 9;
            this.tabPage6.Text = "tabPage6";
            // 
            // panel13
            // 
            this.panel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel13.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cicrle;
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Controls.Add(this.panel12);
            this.panel13.Controls.Add(this.panel11);
            this.panel13.Controls.Add(this.button25);
            this.panel13.Controls.Add(this.button24);
            this.panel13.Controls.Add(this.tb_password);
            this.panel13.Controls.Add(this.tb_username);
            this.panel13.Location = new System.Drawing.Point(381, 27);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(450, 450);
            this.panel13.TabIndex = 18;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.panel12.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Logout___0;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Location = new System.Drawing.Point(124, 195);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(31, 38);
            this.panel12.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.panel11.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.User___01;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Location = new System.Drawing.Point(124, 151);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(31, 38);
            this.panel11.TabIndex = 1;
            // 
            // button25
            // 
            this.button25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button25.BackColor = System.Drawing.Color.White;
            this.button25.FlatAppearance.BorderSize = 0;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.button25.Location = new System.Drawing.Point(123, 191);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(220, 1);
            this.button25.TabIndex = 17;
            this.button25.Text = "LOGIN";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.button24.FlatAppearance.BorderSize = 0;
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(62)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.button24.Location = new System.Drawing.Point(124, 239);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(219, 41);
            this.button24.TabIndex = 16;
            this.button24.Text = "LOGIN";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.Login);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(155, 199);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(183, 31);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "USERNAME";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.Enter += new System.EventHandler(this.RemovePlaceHolder);
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginFormPressEnter);
            // 
            // tb_username
            // 
            this.tb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(155, 155);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(183, 31);
            this.tb_username.TabIndex = 0;
            this.tb_username.Text = "USERNAME";
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_username.Enter += new System.EventHandler(this.RemovePlaceHolder);
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginFormPressEnter);
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage10.Controls.Add(this.btn_deluser);
            this.tabPage10.Controls.Add(this.btn_adduser);
            this.tabPage10.Controls.Add(this.label60);
            this.tabPage10.Controls.Add(this.tb_AUconfirm);
            this.tabPage10.Controls.Add(this.label2);
            this.tabPage10.Controls.Add(this.tb_AUpass);
            this.tabPage10.Controls.Add(this.label59);
            this.tabPage10.Controls.Add(this.tb_AUuser);
            this.tabPage10.Controls.Add(this.lv_users);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1201, 505);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "tabPage10";
            // 
            // btn_deluser
            // 
            this.btn_deluser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_deluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.btn_deluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deluser.Location = new System.Drawing.Point(712, 422);
            this.btn_deluser.Name = "btn_deluser";
            this.btn_deluser.Size = new System.Drawing.Size(241, 41);
            this.btn_deluser.TabIndex = 96;
            this.btn_deluser.Text = "Delete User";
            this.btn_deluser.UseVisualStyleBackColor = false;
            this.btn_deluser.Click += new System.EventHandler(this.btn_deluser_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.btn_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduser.Location = new System.Drawing.Point(298, 137);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(241, 41);
            this.btn_adduser.TabIndex = 95;
            this.btn_adduser.Text = "Save User";
            this.btn_adduser.UseVisualStyleBackColor = false;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(143, 100);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(97, 28);
            this.label60.TabIndex = 94;
            this.label60.Text = "Confirm";
            // 
            // tb_AUconfirm
            // 
            this.tb_AUconfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_AUconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AUconfirm.Location = new System.Drawing.Point(298, 100);
            this.tb_AUconfirm.Name = "tb_AUconfirm";
            this.tb_AUconfirm.PasswordChar = '*';
            this.tb_AUconfirm.Size = new System.Drawing.Size(241, 31);
            this.tb_AUconfirm.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 92;
            this.label2.Text = "Password";
            // 
            // tb_AUpass
            // 
            this.tb_AUpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_AUpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AUpass.Location = new System.Drawing.Point(298, 63);
            this.tb_AUpass.Name = "tb_AUpass";
            this.tb_AUpass.PasswordChar = '*';
            this.tb_AUpass.Size = new System.Drawing.Size(241, 31);
            this.tb_AUpass.TabIndex = 91;
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(143, 26);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(122, 28);
            this.label59.TabIndex = 90;
            this.label59.Text = "Username";
            // 
            // tb_AUuser
            // 
            this.tb_AUuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_AUuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AUuser.Location = new System.Drawing.Point(298, 27);
            this.tb_AUuser.Name = "tb_AUuser";
            this.tb_AUuser.Size = new System.Drawing.Size(241, 31);
            this.tb_AUuser.TabIndex = 89;
            // 
            // lv_users
            // 
            this.lv_users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lv_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.lv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lv_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.lv_users.FullRowSelect = true;
            this.lv_users.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_users.Location = new System.Drawing.Point(625, 26);
            this.lv_users.MultiSelect = false;
            this.lv_users.Name = "lv_users";
            this.lv_users.Size = new System.Drawing.Size(411, 390);
            this.lv_users.TabIndex = 20;
            this.lv_users.UseCompatibleStateImageBehavior = false;
            this.lv_users.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Username";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 198;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Added On";
            this.columnHeader12.Width = 209;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.tabPage11.Controls.Add(this.panel14);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1201, 505);
            this.tabPage11.TabIndex = 11;
            this.tabPage11.Text = "tabPage11";
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel14.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.cicrle;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel14.Controls.Add(this.lbl_loggedUser);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Location = new System.Drawing.Point(375, 27);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(450, 450);
            this.panel14.TabIndex = 19;
            // 
            // lbl_loggedUser
            // 
            this.lbl_loggedUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_loggedUser.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loggedUser.Font = new System.Drawing.Font("Meiryo UI", 50F);
            this.lbl_loggedUser.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedUser.Location = new System.Drawing.Point(0, 179);
            this.lbl_loggedUser.Name = "lbl_loggedUser";
            this.lbl_loggedUser.Size = new System.Drawing.Size(450, 92);
            this.lbl_loggedUser.TabIndex = 91;
            this.lbl_loggedUser.Text = "Username";
            this.lbl_loggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.panel15.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Logout___0;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel15.Location = new System.Drawing.Point(198, 350);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(50, 50);
            this.panel15.TabIndex = 2;
            this.panel15.Click += new System.EventHandler(this.panel15_Click);
            // 
            // panel16
            // 
            this.panel16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.panel16.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.User___01;
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel16.Location = new System.Drawing.Point(175, 20);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(100, 100);
            this.panel16.TabIndex = 1;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1094, 308);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 23);
            this.checkBox4.TabIndex = 70;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Option_Main.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Control_Burner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_AF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Suhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Control_Drum)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Panel Option_Main;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_mqttStatus;
        private System.Windows.Forms.Button btn_mqttConnect;
        private System.Windows.Forms.TextBox tb_brokerIP;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage8;
        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_burner;
        private System.Windows.Forms.Label label84;
        private CircularProgressBar.CircularProgressBar cp_burner;
        private System.Windows.Forms.Label lbl_drumSpeed;
        private System.Windows.Forms.Label label86;
        private CircularProgressBar.CircularProgressBar cp_drum;
        private System.Windows.Forms.Label lbl_airflow;
        private System.Windows.Forms.Label label82;
        private CircularProgressBar.CircularProgressBar cp_airflow;
        private System.Windows.Forms.Label lbl_beanTemp;
        private System.Windows.Forms.Label label80;
        private CircularProgressBar.CircularProgressBar cp_temp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_coolend;
        private System.Windows.Forms.Label lbl_drop;
        private System.Windows.Forms.Label lbl_fcend;
        private System.Windows.Forms.Label lbl_fcstart;
        private System.Windows.Forms.Label lbl_dryend;
        private System.Windows.Forms.Label lbl_charge;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label lbl_dev_time;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label lbl_roast_timer;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView lv_history;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader operate;
        private System.Windows.Forms.ColumnHeader proName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label lbl_chaff;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ProgressBar pb_chaff;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label lbl_bearing;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ProgressBar pb_bearing;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lbl_cooling;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ProgressBar pb_cooling;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lbl_chute;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ProgressBar pb_chute;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ListView lv_beandata;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_loadProfile;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListView lv_events;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListView lv_profile;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btn_editProfile;
        private System.Windows.Forms.Button btn_stopRoast;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.ListView lv_users;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tb_AUconfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_AUpass;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tb_AUuser;
        private System.Windows.Forms.Button btn_deluser;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.NumericUpDown Control_Drum;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lbl_loggedUser;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.NumericUpDown Control_Burner;
        private System.Windows.Forms.NumericUpDown Control_AF;
        private System.Windows.Forms.NumericUpDown Control_Suhu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

