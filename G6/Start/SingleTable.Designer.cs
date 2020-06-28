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
            this.btn_ready = new System.Windows.Forms.Button();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_occupied = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.BackColor = System.Drawing.Color.Salmon;
            this.btn_AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOrder.ForeColor = System.Drawing.Color.White;
            this.btn_AddOrder.Location = new System.Drawing.Point(628, 52);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(160, 60);
            this.btn_AddOrder.TabIndex = 0;
            this.btn_AddOrder.Text = "Take Order";
            this.btn_AddOrder.UseVisualStyleBackColor = false;
            this.btn_AddOrder.Click += new System.EventHandler(this.Btn_AddOrder_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Salmon;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(628, 382);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(160, 56);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Lst_TableOrders
            // 
            this.Lst_TableOrders.FullRowSelect = true;
            this.Lst_TableOrders.GridLines = true;
            this.Lst_TableOrders.HideSelection = false;
            this.Lst_TableOrders.Location = new System.Drawing.Point(6, 52);
            this.Lst_TableOrders.Name = "Lst_TableOrders";
            this.Lst_TableOrders.Size = new System.Drawing.Size(616, 386);
            this.Lst_TableOrders.TabIndex = 3;
            this.Lst_TableOrders.UseCompatibleStateImageBehavior = false;
            this.Lst_TableOrders.View = System.Windows.Forms.View.Details;
            // 
            // Lbl_Table
            // 
            this.Lbl_Table.AutoSize = true;
            this.Lbl_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Table.Location = new System.Drawing.Point(12, 13);
            this.Lbl_Table.Name = "Lbl_Table";
            this.Lbl_Table.Size = new System.Drawing.Size(44, 16);
            this.Lbl_Table.TabIndex = 4;
            this.Lbl_Table.Text = "Table";
            // 
            // Lbl_TableNum
            // 
            this.Lbl_TableNum.AutoSize = true;
            this.Lbl_TableNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TableNum.Location = new System.Drawing.Point(62, 13);
            this.Lbl_TableNum.Name = "Lbl_TableNum";
            this.Lbl_TableNum.Size = new System.Drawing.Size(17, 16);
            this.Lbl_TableNum.TabIndex = 5;
            this.Lbl_TableNum.Text = "...";
            // 
            // btn_ready
            // 
            this.btn_ready.BackColor = System.Drawing.Color.Salmon;
            this.btn_ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ready.ForeColor = System.Drawing.Color.White;
            this.btn_ready.Location = new System.Drawing.Point(628, 118);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(160, 60);
            this.btn_ready.TabIndex = 6;
            this.btn_ready.Text = "Serve";
            this.btn_ready.UseVisualStyleBackColor = false;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // btn_reserve
            // 
            this.btn_reserve.BackColor = System.Drawing.Color.Salmon;
            this.btn_reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserve.ForeColor = System.Drawing.Color.White;
            this.btn_reserve.Location = new System.Drawing.Point(628, 250);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(160, 60);
            this.btn_reserve.TabIndex = 7;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.UseVisualStyleBackColor = false;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Salmon;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(628, 316);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(160, 60);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(124, 13);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(48, 16);
            this.status.TabIndex = 9;
            this.status.Text = "Status:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(169, 13);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(17, 16);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "...";
            // 
            // btn_occupied
            // 
            this.btn_occupied.BackColor = System.Drawing.Color.Salmon;
            this.btn_occupied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_occupied.ForeColor = System.Drawing.Color.White;
            this.btn_occupied.Location = new System.Drawing.Point(628, 184);
            this.btn_occupied.Name = "btn_occupied";
            this.btn_occupied.Size = new System.Drawing.Size(160, 60);
            this.btn_occupied.TabIndex = 11;
            this.btn_occupied.Text = "Occupy";
            this.btn_occupied.UseVisualStyleBackColor = false;
            this.btn_occupied.Click += new System.EventHandler(this.btn_occupied_Click);
            // 
            // SingleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_occupied);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.btn_ready);
            this.Controls.Add(this.Lbl_TableNum);
            this.Controls.Add(this.Lbl_Table);
            this.Controls.Add(this.Lst_TableOrders);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_AddOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btn_ready;
        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_occupied;
    }
}