﻿namespace Start
{
    partial class SingleTable
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
            this.Btn_AddOrder = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Lst_TableOrders = new System.Windows.Forms.ListView();
            this.Lbl_Table = new System.Windows.Forms.Label();
            this.Lbl_TableNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_AddOrder
            // 
            this.Btn_AddOrder.Location = new System.Drawing.Point(616, 52);
            this.Btn_AddOrder.Name = "Btn_AddOrder";
            this.Btn_AddOrder.Size = new System.Drawing.Size(172, 85);
            this.Btn_AddOrder.TabIndex = 0;
            this.Btn_AddOrder.Text = "Add Order";
            this.Btn_AddOrder.UseVisualStyleBackColor = true;
            this.Btn_AddOrder.Click += new System.EventHandler(this.Btn_AddOrder_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(616, 353);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(172, 85);
            this.Btn_Back.TabIndex = 2;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Lst_TableOrders
            // 
            this.Lst_TableOrders.HideSelection = false;
            this.Lst_TableOrders.Location = new System.Drawing.Point(12, 52);
            this.Lst_TableOrders.Name = "Lst_TableOrders";
            this.Lst_TableOrders.Size = new System.Drawing.Size(598, 386);
            this.Lst_TableOrders.TabIndex = 3;
            this.Lst_TableOrders.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_Table
            // 
            this.Lbl_Table.AutoSize = true;
            this.Lbl_Table.Location = new System.Drawing.Point(12, 13);
            this.Lbl_Table.Name = "Lbl_Table";
            this.Lbl_Table.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Table.TabIndex = 4;
            this.Lbl_Table.Text = "Table";
            // 
            // Lbl_TableNum
            // 
            this.Lbl_TableNum.AutoSize = true;
            this.Lbl_TableNum.Location = new System.Drawing.Point(52, 13);
            this.Lbl_TableNum.Name = "Lbl_TableNum";
            this.Lbl_TableNum.Size = new System.Drawing.Size(16, 13);
            this.Lbl_TableNum.TabIndex = 5;
            this.Lbl_TableNum.Text = "...";
            // 
            // SingleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_TableNum);
            this.Controls.Add(this.Lbl_Table);
            this.Controls.Add(this.Lst_TableOrders);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_AddOrder);
            this.Name = "SingleTable";
            this.Text = "SingleTable";
            this.Load += new System.EventHandler(this.SingleTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddOrder;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.ListView Lst_TableOrders;
        private System.Windows.Forms.Label Lbl_Table;
        private System.Windows.Forms.Label Lbl_TableNum;
    }
}