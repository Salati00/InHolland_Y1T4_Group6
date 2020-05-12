namespace Start
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Kitchen = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ordering";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kitchen
            // 
            this.Kitchen.Location = new System.Drawing.Point(12, 131);
            this.Kitchen.Name = "Kitchen";
            this.Kitchen.Size = new System.Drawing.Size(198, 48);
            this.Kitchen.TabIndex = 2;
            this.Kitchen.Text = "Kitchen";
            this.Kitchen.UseVisualStyleBackColor = true;
            this.Kitchen.Click += new System.EventHandler(this.Kitchen_Click);
            // 
            // Bar
            // 
            this.Bar.Location = new System.Drawing.Point(12, 195);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(198, 48);
            this.Bar.TabIndex = 3;
            this.Bar.Text = "Bar";
            this.Bar.UseVisualStyleBackColor = true;
            this.Bar.Click += new System.EventHandler(this.Bar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 634);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.Kitchen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PlaceHolderMenu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Kitchen;
        private System.Windows.Forms.Button Bar;
    }
}

