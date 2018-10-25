namespace WindowsFormsApp2
{
    partial class DialogProfile
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
            this.cb_bean = new System.Windows.Forms.ComboBox();
            this.nud_batch = new System.Windows.Forms.NumericUpDown();
            this.label69 = new System.Windows.Forms.Label();
            this.tb_operator = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.tb_profile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nud_weightLoss = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_batch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_weightLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_bean
            // 
            this.cb_bean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.cb_bean.FormattingEnabled = true;
            this.cb_bean.Location = new System.Drawing.Point(181, 114);
            this.cb_bean.Name = "cb_bean";
            this.cb_bean.Size = new System.Drawing.Size(241, 33);
            this.cb_bean.TabIndex = 105;
            // 
            // nud_batch
            // 
            this.nud_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nud_batch.Location = new System.Drawing.Point(181, 152);
            this.nud_batch.Name = "nud_batch";
            this.nud_batch.Size = new System.Drawing.Size(241, 31);
            this.nud_batch.TabIndex = 104;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label69.ForeColor = System.Drawing.Color.White;
            this.label69.Location = new System.Drawing.Point(26, 226);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(107, 28);
            this.label69.TabIndex = 103;
            this.label69.Text = "Operator";
            // 
            // tb_operator
            // 
            this.tb_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_operator.Location = new System.Drawing.Point(181, 226);
            this.tb_operator.Name = "tb_operator";
            this.tb_operator.Size = new System.Drawing.Size(241, 31);
            this.tb_operator.TabIndex = 102;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Meiryo UI", 20F);
            this.label70.ForeColor = System.Drawing.Color.White;
            this.label70.Location = new System.Drawing.Point(173, 23);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(97, 35);
            this.label70.TabIndex = 101;
            this.label70.Text = "Profile";
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(106, 274);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(241, 41);
            this.button19.TabIndex = 100;
            this.button19.Text = "Save";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label71.ForeColor = System.Drawing.Color.White;
            this.label71.Location = new System.Drawing.Point(26, 189);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(141, 28);
            this.label71.TabIndex = 99;
            this.label71.Text = "Weight Loss";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Location = new System.Drawing.Point(26, 152);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(124, 28);
            this.label72.TabIndex = 97;
            this.label72.Text = "Batch Size";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(26, 115);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(124, 28);
            this.label79.TabIndex = 96;
            this.label79.Text = "Bean Data";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Meiryo UI", 16F);
            this.label81.ForeColor = System.Drawing.Color.White;
            this.label81.Location = new System.Drawing.Point(26, 78);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(149, 28);
            this.label81.TabIndex = 95;
            this.label81.Text = "Profile Name";
            // 
            // tb_profile
            // 
            this.tb_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_profile.Location = new System.Drawing.Point(181, 78);
            this.tb_profile.Name = "tb_profile";
            this.tb_profile.Size = new System.Drawing.Size(241, 31);
            this.tb_profile.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(108)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(399, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 32);
            this.button1.TabIndex = 106;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_weightLoss
            // 
            this.nud_weightLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nud_weightLoss.Location = new System.Drawing.Point(181, 189);
            this.nud_weightLoss.Name = "nud_weightLoss";
            this.nud_weightLoss.Size = new System.Drawing.Size(241, 31);
            this.nud_weightLoss.TabIndex = 107;
            // 
            // DialogProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(448, 348);
            this.Controls.Add(this.nud_weightLoss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_bean);
            this.Controls.Add(this.nud_batch);
            this.Controls.Add(this.label69);
            this.Controls.Add(this.tb_operator);
            this.Controls.Add(this.label70);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.label71);
            this.Controls.Add(this.label72);
            this.Controls.Add(this.label79);
            this.Controls.Add(this.label81);
            this.Controls.Add(this.tb_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DialogProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DialogProfile";
            this.Load += new System.EventHandler(this.DialogProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_batch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_weightLoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_bean;
        private System.Windows.Forms.NumericUpDown nud_batch;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox tb_operator;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.TextBox tb_profile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_weightLoss;
    }
}