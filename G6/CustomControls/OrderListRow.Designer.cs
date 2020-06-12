namespace CustomControls
{
    partial class OrderListRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Reduce = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Reduce
            // 
            this.Btn_Reduce.Location = new System.Drawing.Point(210, 9);
            this.Btn_Reduce.Name = "Btn_Reduce";
            this.Btn_Reduce.Size = new System.Drawing.Size(30, 20);
            this.Btn_Reduce.TabIndex = 0;
            this.Btn_Reduce.Text = "-";
            this.Btn_Reduce.UseVisualStyleBackColor = true;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(265, 9);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(30, 20);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(317, 4);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove.TabIndex = 2;
            this.Btn_Remove.Text = "x";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(21, 13);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Name.TabIndex = 3;
            this.Lbl_Name.Text = "Name";
            // 
            // Lbl_Amount
            // 
            this.Lbl_Amount.AutoSize = true;
            this.Lbl_Amount.Location = new System.Drawing.Point(246, 14);
            this.Lbl_Amount.Name = "Lbl_Amount";
            this.Lbl_Amount.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Amount.TabIndex = 4;
            this.Lbl_Amount.Text = "1";
            // 
            // OrderListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Amount);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Reduce);
            this.Name = "OrderListRow";
            this.Size = new System.Drawing.Size(350, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Reduce;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Amount;
    }
}
