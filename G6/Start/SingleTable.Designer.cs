namespace Start
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
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.Lst_TableOrders = new System.Windows.Forms.ListView();
            this.Lbl_Table = new System.Windows.Forms.Label();
            this.Lbl_TableNum = new System.Windows.Forms.Label();
            this.order_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.staff_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.table_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(616, 52);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(172, 85);
            this.btn_AddOrder.TabIndex = 0;
            this.btn_AddOrder.Text = "Add Order";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.Btn_AddOrder_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(616, 353);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(172, 85);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Lst_TableOrders
            // 
            this.Lst_TableOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.order_id,
            this.staff_id,
            this.table_id,
            this.time,
            this.status});
            this.Lst_TableOrders.FullRowSelect = true;
            this.Lst_TableOrders.GridLines = true;
            this.Lst_TableOrders.HideSelection = false;
            this.Lst_TableOrders.Location = new System.Drawing.Point(12, 52);
            this.Lst_TableOrders.Name = "Lst_TableOrders";
            this.Lst_TableOrders.Size = new System.Drawing.Size(598, 386);
            this.Lst_TableOrders.TabIndex = 3;
            this.Lst_TableOrders.UseCompatibleStateImageBehavior = false;
            this.Lst_TableOrders.View = System.Windows.Forms.View.Details;
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
            // order_id
            // 
            this.order_id.Text = "Order ID";
            this.order_id.Width = 110;
            // 
            // staff_id
            // 
            this.staff_id.Text = "Staff ID";
            this.staff_id.Width = 120;
            // 
            // table_id
            // 
            this.table_id.Text = "Table ID";
            this.table_id.Width = 120;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 120;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 120;
            // 
            // SingleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_TableNum);
            this.Controls.Add(this.Lbl_Table);
            this.Controls.Add(this.Lst_TableOrders);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_AddOrder);
            this.Name = "SingleTable";
            this.Text = "SingleTable";
            this.Load += new System.EventHandler(this.SingleTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListView Lst_TableOrders;
        private System.Windows.Forms.Label Lbl_Table;
        private System.Windows.Forms.Label Lbl_TableNum;
        private System.Windows.Forms.ColumnHeader order_id;
        private System.Windows.Forms.ColumnHeader staff_id;
        private System.Windows.Forms.ColumnHeader table_id;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader status;
    }
}