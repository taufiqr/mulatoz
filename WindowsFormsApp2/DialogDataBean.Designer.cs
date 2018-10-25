namespace WindowsFormsApp2
{
    partial class DialogDataBean
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
            this.dt_harvest = new System.Windows.Forms.DateTimePicker();
            this.cb_process = new System.Windows.Forms.ComboBox();
            this.nud_screenSize = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.tb_vendor = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.tb_region = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tb_beanName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nud_moisture = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_beanType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_screenSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_moisture)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_harvest
            // 
            this.dt_harvest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_harvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dt_harvest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_harvest.Location = new System.Drawing.Point(175, 253);
            this.dt_harvest.Name = "dt_harvest";
            this.dt_harvest.Size = new System.Drawing.Size(241, 31);
            this.dt_harvest.TabIndex = 100;
            // 
            // cb_process
            // 
            this.cb_process.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_process.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cb_process.FormattingEnabled = true;
            this.cb_process.Location = new System.Drawing.Point(175, 215);
            this.cb_process.Name = "cb_process";
            this.cb_process.Size = new System.Drawing.Size(241, 33);
            this.cb_process.TabIndex = 99;
            // 
            // nud_screenSize
            // 
            this.nud_screenSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_screenSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nud_screenSize.Location = new System.Drawing.Point(175, 290);
            this.nud_screenSize.Name = "nud_screenSize";
            this.nud_screenSize.Size = new System.Drawing.Size(241, 31);
            this.nud_screenSize.TabIndex = 98;
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Location = new System.Drawing.Point(20, 364);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(88, 28);
            this.label64.TabIndex = 97;
            this.label64.Text = "Vendor";
            // 
            // tb_vendor
            // 
            this.tb_vendor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vendor.Location = new System.Drawing.Point(175, 364);
            this.tb_vendor.Name = "tb_vendor";
            this.tb_vendor.Size = new System.Drawing.Size(241, 31);
            this.tb_vendor.TabIndex = 96;
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(20, 327);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(104, 28);
            this.label55.TabIndex = 95;
            this.label55.Text = "Moisture";
            // 
            // label63
            // 
            this.label63.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(20, 290);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(128, 28);
            this.label63.TabIndex = 93;
            this.label63.Text = "Sceen Size";
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Location = new System.Drawing.Point(20, 253);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(151, 28);
            this.label61.TabIndex = 92;
            this.label61.Text = "Harvest Date";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(137, 15);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(153, 35);
            this.label60.TabIndex = 91;
            this.label60.Text = "Bean Data";
            // 
            // button18
            // 
            this.button18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(115, 413);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(241, 41);
            this.button18.TabIndex = 90;
            this.button18.Text = "Save";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Location = new System.Drawing.Point(20, 216);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(93, 28);
            this.label56.TabIndex = 89;
            this.label56.Text = "Process";
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Location = new System.Drawing.Point(20, 179);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(86, 28);
            this.label57.TabIndex = 88;
            this.label57.Text = "Region";
            // 
            // tb_region
            // 
            this.tb_region.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_region.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_region.Location = new System.Drawing.Point(175, 179);
            this.tb_region.Name = "tb_region";
            this.tb_region.Size = new System.Drawing.Size(241, 31);
            this.tb_region.TabIndex = 87;
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(20, 142);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(97, 28);
            this.label58.TabIndex = 86;
            this.label58.Text = "Country";
            // 
            // tb_country
            // 
            this.tb_country.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_country.Location = new System.Drawing.Point(175, 143);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(241, 31);
            this.tb_country.TabIndex = 85;
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Location = new System.Drawing.Point(20, 69);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(137, 28);
            this.label59.TabIndex = 84;
            this.label59.Text = "Bean Name";
            // 
            // tb_beanName
            // 
            this.tb_beanName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_beanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_beanName.Location = new System.Drawing.Point(175, 69);
            this.tb_beanName.Name = "tb_beanName";
            this.tb_beanName.Size = new System.Drawing.Size(241, 31);
            this.tb_beanName.TabIndex = 83;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 101;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_moisture
            // 
            this.nud_moisture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_moisture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nud_moisture.Location = new System.Drawing.Point(175, 327);
            this.nud_moisture.Name = "nud_moisture";
            this.nud_moisture.Size = new System.Drawing.Size(241, 31);
            this.nud_moisture.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 104;
            this.label1.Text = "Bean Type";
            // 
            // cb_beanType
            // 
            this.cb_beanType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_beanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cb_beanType.FormattingEnabled = true;
            this.cb_beanType.Items.AddRange(new object[] {
            "Arabica",
            "Robusta"});
            this.cb_beanType.Location = new System.Drawing.Point(175, 105);
            this.cb_beanType.Name = "cb_beanType";
            this.cb_beanType.Size = new System.Drawing.Size(241, 33);
            this.cb_beanType.TabIndex = 105;
            // 
            // DialogDataBean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(456, 481);
            this.Controls.Add(this.cb_beanType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_moisture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt_harvest);
            this.Controls.Add(this.cb_process);
            this.Controls.Add(this.nud_screenSize);
            this.Controls.Add(this.label64);
            this.Controls.Add(this.tb_vendor);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.label63);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.label57);
            this.Controls.Add(this.tb_region);
            this.Controls.Add(this.label58);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.tb_beanName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogDataBean";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogDataBean";
            ((System.ComponentModel.ISupportInitialize)(this.nud_screenSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_moisture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_harvest;
        private System.Windows.Forms.ComboBox cb_process;
        private System.Windows.Forms.NumericUpDown nud_screenSize;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tb_vendor;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tb_region;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tb_beanName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_moisture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_beanType;
    }
}