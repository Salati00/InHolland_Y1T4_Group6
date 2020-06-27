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
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.Lbl_Notes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Reduce
            // 
            this.Btn_Reduce.Location = new System.Drawing.Point(201, 9);
            this.Btn_Reduce.Name = "Btn_Reduce";
            this.Btn_Reduce.Size = new System.Drawing.Size(30, 20);
            this.Btn_Reduce.TabIndex = 0;
            this.Btn_Reduce.Text = "-";
            this.Btn_Reduce.UseVisualStyleBackColor = true;
            this.Btn_Reduce.Click += new System.EventHandler(this.Btn_Reduce_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(256, 9);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(30, 20);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "+";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(308, 4);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(30, 30);
            this.Btn_Remove.TabIndex = 2;
            this.Btn_Remove.Text = "x";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(15, 13);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Name.TabIndex = 3;
            this.Lbl_Name.Text = "Name";
            // 
            // Lbl_Amount
            // 
            this.Lbl_Amount.AutoSize = true;
            this.Lbl_Amount.Location = new System.Drawing.Point(237, 13);
            this.Lbl_Amount.Name = "Lbl_Amount";
            this.Lbl_Amount.Size = new System.Drawing.Size(13, 13);
            this.Lbl_Amount.TabIndex = 4;
            this.Lbl_Amount.Text = "1";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Location = new System.Drawing.Point(102, 39);
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(236, 20);
            this.Txt_Notes.TabIndex = 5;
            this.Txt_Notes.TextChanged += new System.EventHandler(this.Txt_Notes_TextChanged);
            // 
            // Lbl_Notes
            // 
            this.Lbl_Notes.AutoSize = true;
            this.Lbl_Notes.Location = new System.Drawing.Point(15, 42);
            this.Lbl_Notes.Name = "Lbl_Notes";
            this.Lbl_Notes.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Notes.TabIndex = 6;
            this.Lbl_Notes.Text = "Notes";
            // 
            // OrderListRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Lbl_Notes);
            this.Controls.Add(this.Txt_Notes);
            this.Controls.Add(this.Lbl_Amount);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Btn_Reduce);
            this.Name = "OrderListRow";
            this.Size = new System.Drawing.Size(350, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Reduce;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.Label Lbl_Amount;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Label Lbl_Notes;
    }
}
