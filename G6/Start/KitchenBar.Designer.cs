namespace Start
{
    partial class KitchenBar
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
            this.PanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.recalled = new System.Windows.Forms.Button();
            this.recallpanel = new System.Windows.Forms.Panel();
            this.recall = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.timee = new System.Windows.Forms.Label();
            this.recallpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOrders
            // 
            this.PanelOrders.Location = new System.Drawing.Point(12, 12);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.Size = new System.Drawing.Size(776, 426);
            this.PanelOrders.TabIndex = 0;
            // 
            // recalled
            // 
            this.recalled.Location = new System.Drawing.Point(0, 0);
            this.recalled.Name = "recalled";
            this.recalled.Size = new System.Drawing.Size(335, 176);
            this.recalled.TabIndex = 0;
            this.recalled.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.recalled.UseVisualStyleBackColor = true;
            this.recalled.Click += new System.EventHandler(this.recalled_Click);
            // 
            // recallpanel
            // 
            this.recallpanel.Controls.Add(this.recalled);
            this.recallpanel.Location = new System.Drawing.Point(213, 122);
            this.recallpanel.Name = "recallpanel";
            this.recallpanel.Size = new System.Drawing.Size(335, 176);
            this.recallpanel.TabIndex = 1;
            // 
            // recall
            // 
            this.recall.Location = new System.Drawing.Point(323, 444);
            this.recall.Name = "recall";
            this.recall.Size = new System.Drawing.Size(120, 36);
            this.recall.TabIndex = 2;
            this.recall.Text = "recall";
            this.recall.UseVisualStyleBackColor = true;
            this.recall.Click += new System.EventHandler(this.recall_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 444);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 36);
            this.back.TabIndex = 3;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // timee
            // 
            this.timee.AutoSize = true;
            this.timee.Location = new System.Drawing.Point(675, 452);
            this.timee.Name = "timee";
            this.timee.Size = new System.Drawing.Size(39, 20);
            this.timee.TabIndex = 4;
            this.timee.Text = "time";
            // 
            // KitchenBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.timee);
            this.Controls.Add(this.back);
            this.Controls.Add(this.recall);
            this.Controls.Add(this.recallpanel);
            this.Controls.Add(this.PanelOrders);
            this.Name = "KitchenBar";
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.KitchenBar_Load);
            this.recallpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelOrders;
        private System.Windows.Forms.Button recalled;
        private System.Windows.Forms.Panel recallpanel;
        private System.Windows.Forms.Button recall;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label timee;
    }
}