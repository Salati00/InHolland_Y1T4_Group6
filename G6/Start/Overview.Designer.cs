namespace Start
{
    partial class Overview
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tables = new System.Windows.Forms.Button();
            this.btn_bar = new System.Windows.Forms.Button();
            this.btn_signout = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_kitchen = new System.Windows.Forms.Button();
            this.lbl_role = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME,";
            // 
            // btn_tables
            // 
            this.btn_tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tables.Location = new System.Drawing.Point(43, 97);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Size = new System.Drawing.Size(188, 95);
            this.btn_tables.TabIndex = 1;
            this.btn_tables.Text = "TABLES";
            this.btn_tables.UseVisualStyleBackColor = true;
            this.btn_tables.Click += new System.EventHandler(this.btn_tables_Click);
            // 
            // btn_bar
            // 
            this.btn_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bar.Location = new System.Drawing.Point(43, 240);
            this.btn_bar.Name = "btn_bar";
            this.btn_bar.Size = new System.Drawing.Size(188, 95);
            this.btn_bar.TabIndex = 4;
            this.btn_bar.Text = "BAR";
            this.btn_bar.UseVisualStyleBackColor = true;
            this.btn_bar.Click += new System.EventHandler(this.btn_bar_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.Location = new System.Drawing.Point(554, 168);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(188, 95);
            this.btn_signout.TabIndex = 6;
            this.btn_signout.Text = "SIGN OUT";
            this.btn_signout.UseVisualStyleBackColor = true;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.Location = new System.Drawing.Point(298, 97);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(188, 95);
            this.btn_orders.TabIndex = 7;
            this.btn_orders.Text = "ORDERS";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_kitchen
            // 
            this.btn_kitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kitchen.Location = new System.Drawing.Point(298, 240);
            this.btn_kitchen.Name = "btn_kitchen";
            this.btn_kitchen.Size = new System.Drawing.Size(188, 95);
            this.btn_kitchen.TabIndex = 8;
            this.btn_kitchen.Text = "KITCHEN";
            this.btn_kitchen.UseVisualStyleBackColor = true;
            this.btn_kitchen.Click += new System.EventHandler(this.btn_kitchen_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(427, 361);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(0, 13);
            this.lbl_role.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "You are logged in as a";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(383, 32);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 29);
            this.lbl_name.TabIndex = 11;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.btn_kitchen);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.btn_bar);
            this.Controls.Add(this.btn_tables);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Overview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overview_FormClosing);
            this.Load += new System.EventHandler(this.Overview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tables;
        private System.Windows.Forms.Button btn_bar;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_kitchen;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
    }
}