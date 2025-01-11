namespace Fitness_T
{
    partial class SignUp
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
            this.check_con = new System.Windows.Forms.CheckBox();
            this.check_pass = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_con_pass = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // check_con
            // 
            this.check_con.AutoSize = true;
            this.check_con.Location = new System.Drawing.Point(270, 276);
            this.check_con.Name = "check_con";
            this.check_con.Size = new System.Drawing.Size(53, 17);
            this.check_con.TabIndex = 26;
            this.check_con.Text = "Show";
            this.check_con.UseVisualStyleBackColor = true;
            this.check_con.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // check_pass
            // 
            this.check_pass.AutoSize = true;
            this.check_pass.Location = new System.Drawing.Point(270, 211);
            this.check_pass.Name = "check_pass";
            this.check_pass.Size = new System.Drawing.Size(53, 17);
            this.check_pass.TabIndex = 25;
            this.check_pass.Text = "Show";
            this.check_pass.UseVisualStyleBackColor = true;
            this.check_pass.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(50, 330);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(273, 27);
            this.btn_submit.TabIndex = 24;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rewrite Password";
            // 
            // txt_con_pass
            // 
            this.txt_con_pass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_con_pass.Location = new System.Drawing.Point(50, 274);
            this.txt_con_pass.Name = "txt_con_pass";
            this.txt_con_pass.PasswordChar = '*';
            this.txt_con_pass.Size = new System.Drawing.Size(183, 20);
            this.txt_con_pass.TabIndex = 22;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(673, 414);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Return Back To Login ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username";
            // 
            // txt_pass
            // 
            this.txt_pass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_pass.Location = new System.Drawing.Point(50, 208);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(183, 20);
            this.txt_pass.TabIndex = 18;
            // 
            // txt_name
            // 
            this.txt_name.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_name.Location = new System.Drawing.Point(50, 137);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(183, 20);
            this.txt_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Create An Account to Start ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fitness_T.Properties.Resources.exercise;
            this.pictureBox1.Location = new System.Drawing.Point(457, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_con);
            this.Controls.Add(this.check_pass);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_con_pass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_con;
        private System.Windows.Forms.CheckBox check_pass;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_con_pass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}