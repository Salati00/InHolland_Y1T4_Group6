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
            this.components = new System.ComponentModel.Container();
            this.PanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.recallpanel = new System.Windows.Forms.Panel();
            this.timeLable = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.recall = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pagelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOrders
            // 
            this.PanelOrders.BackColor = System.Drawing.Color.Transparent;
            this.PanelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelOrders.Location = new System.Drawing.Point(32, 45);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.Size = new System.Drawing.Size(1950, 935);
            this.PanelOrders.TabIndex = 0;
            this.PanelOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOrders_Paint);
            // 
            // recallpanel
            // 
            this.recallpanel.BackColor = System.Drawing.Color.Maroon;
            this.recallpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recallpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recallpanel.ForeColor = System.Drawing.Color.White;
            this.recallpanel.Location = new System.Drawing.Point(484, 229);
            this.recallpanel.Name = "recallpanel";
            this.recallpanel.Size = new System.Drawing.Size(940, 442);
            this.recallpanel.TabIndex = 1;
            // 
            // timeLable
            // 
            this.timeLable.AutoSize = true;
            this.timeLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLable.Location = new System.Drawing.Point(1704, 12);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(81, 37);
            this.timeLable.TabIndex = 7;
            this.timeLable.Text = "time";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(26, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(186, 57);
            this.Home.TabIndex = 6;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // recall
            // 
            this.recall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recall.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.recall.Location = new System.Drawing.Point(872, 3);
            this.recall.Name = "recall";
            this.recall.Size = new System.Drawing.Size(186, 57);
            this.recall.TabIndex = 5;
            this.recall.Text = "Recall";
            this.recall.UseVisualStyleBackColor = false;
            this.recall.Click += new System.EventHandler(this.recall_Click_1);
            // 
            // left
            // 
            this.left.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.left.BackColor = System.Drawing.Color.Transparent;
            this.left.FlatAppearance.BorderSize = 0;
            this.left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.Location = new System.Drawing.Point(783, 3);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(82, 74);
            this.left.TabIndex = 8;
            this.left.Text = "<";
            this.left.UseCompatibleTextRendering = true;
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // right
            // 
            this.right.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.right.BackColor = System.Drawing.Color.Transparent;
            this.right.FlatAppearance.BorderSize = 0;
            this.right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.right.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Microsoft Tai Le", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.Location = new System.Drawing.Point(1064, 3);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(92, 74);
            this.right.TabIndex = 9;
            this.right.Text = ">";
            this.right.UseCompatibleTextRendering = true;
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.right);
            this.panel1.Controls.Add(this.left);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.timeLable);
            this.panel1.Controls.Add(this.recall);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 937);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 91);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, -928);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1894, 1028);
            this.panel2.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pagelbl
            // 
            this.pagelbl.AutoSize = true;
            this.pagelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagelbl.Location = new System.Drawing.Point(32, 9);
            this.pagelbl.Name = "pagelbl";
            this.pagelbl.Size = new System.Drawing.Size(70, 25);
            this.pagelbl.TabIndex = 0;
            this.pagelbl.Text = "label1";
            this.pagelbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KitchenBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1912, 1026);
            this.Controls.Add(this.pagelbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recallpanel);
            this.Controls.Add(this.PanelOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitchenBar";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chapeau Kitchen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelOrders;
        private System.Windows.Forms.Panel recallpanel;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button recall;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pagelbl;
        private System.Windows.Forms.Panel panel2;
    }
}