﻿namespace Start
{
    partial class login_form
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
            this.chapeau = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_chapeau = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.btn_signin = new System.Windows.Forms.Button();
            this.btn_forgotpass = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chapeau
            // 
            this.chapeau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chapeau.BackColor = System.Drawing.SystemColors.Menu;
            this.chapeau.Enabled = false;
            this.chapeau.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapeau.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chapeau.ImeMode = System.Windows.Forms.ImeMode.On;
            this.chapeau.Location = new System.Drawing.Point(70, 53);
            this.chapeau.MaxLength = 1;
            this.chapeau.Multiline = true;
            this.chapeau.Name = "chapeau";
            this.chapeau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chapeau.Size = new System.Drawing.Size(66, 311);
            this.chapeau.TabIndex = 0;
            this.chapeau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(225, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 311);
            this.textBox1.TabIndex = 1;
            // 
            // signin
            // 
            this.signin.AutoSize = true;
            this.signin.BackColor = System.Drawing.SystemColors.Menu;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(375, 69);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(123, 31);
            this.signin.TabIndex = 2;
            this.signin.Text = "SIGN IN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "USERNAME / ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD";
            // 
            // lbl_chapeau
            // 
            this.lbl_chapeau.AutoSize = true;
            this.lbl_chapeau.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl_chapeau.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chapeau.Location = new System.Drawing.Point(83, 69);
            this.lbl_chapeau.Name = "lbl_chapeau";
            this.lbl_chapeau.Size = new System.Drawing.Size(42, 273);
            this.lbl_chapeau.TabIndex = 5;
            this.lbl_chapeau.Text = "C\r\nH\r\nA\r\nP\r\nE\r\nA\r\nU";
            this.lbl_chapeau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.username.BackColor = System.Drawing.SystemColors.Window;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(293, 143);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(284, 25);
            this.username.TabIndex = 6;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password.BackColor = System.Drawing.SystemColors.Window;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(293, 199);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(284, 25);
            this.password.TabIndex = 7;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.Location = new System.Drawing.Point(293, 243);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(284, 47);
            this.btn_signin.TabIndex = 8;
            this.btn_signin.Text = "SIGN IN";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // btn_forgotpass
            // 
            this.btn_forgotpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_forgotpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forgotpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_forgotpass.Location = new System.Drawing.Point(438, 296);
            this.btn_forgotpass.Name = "btn_forgotpass";
            this.btn_forgotpass.Size = new System.Drawing.Size(139, 23);
            this.btn_forgotpass.TabIndex = 9;
            this.btn_forgotpass.Text = "FORGOT PASSWORD?";
            this.btn_forgotpass.UseVisualStyleBackColor = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(678, 379);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 39);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "just temporarly hehe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_forgotpass);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lbl_chapeau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chapeau);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlaceHolderMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chapeau;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label signin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_chapeau;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Button btn_forgotpass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
    }
}
