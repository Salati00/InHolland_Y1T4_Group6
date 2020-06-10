namespace Start
{
    partial class RowElement
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
            this.Lbl_ItemName = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ItemName
            // 
            this.Lbl_ItemName.AutoSize = true;
            this.Lbl_ItemName.Location = new System.Drawing.Point(16, 9);
            this.Lbl_ItemName.Name = "Lbl_ItemName";
            this.Lbl_ItemName.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ItemName.TabIndex = 0;
            this.Lbl_ItemName.Text = "Name";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(222, 5);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 20);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // RowElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lbl_ItemName);
            this.Name = "RowElement";
            this.Size = new System.Drawing.Size(302, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ItemName;
        private System.Windows.Forms.Button Btn_Add;
    }
}
