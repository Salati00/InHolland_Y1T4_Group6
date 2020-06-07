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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "click",
            "click"}, -1);
            this.PanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.recallpanel = new System.Windows.Forms.Panel();
            this.listViewrecall = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timee = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.recall = new System.Windows.Forms.Button();
            this.recallpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOrders
            // 
            this.PanelOrders.BackColor = System.Drawing.Color.Transparent;
            this.PanelOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelOrders.Location = new System.Drawing.Point(21, 8);
            this.PanelOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.Size = new System.Drawing.Size(1305, 608);
            this.PanelOrders.TabIndex = 0;
            this.PanelOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOrders_Paint);
            // 
            // recallpanel
            // 
            this.recallpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recallpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recallpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recallpanel.Controls.Add(this.listViewrecall);
            this.recallpanel.ForeColor = System.Drawing.Color.White;
            this.recallpanel.Location = new System.Drawing.Point(323, 149);
            this.recallpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recallpanel.Name = "recallpanel";
            this.recallpanel.Size = new System.Drawing.Size(619, 302);
            this.recallpanel.TabIndex = 1;
            // 
            // listViewrecall
            // 
            this.listViewrecall.CausesValidation = false;
            this.listViewrecall.HideSelection = false;
            this.listViewrecall.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listViewrecall.Location = new System.Drawing.Point(-1, -1);
            this.listViewrecall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewrecall.Name = "listViewrecall";
            this.listViewrecall.Size = new System.Drawing.Size(615, 298);
            this.listViewrecall.TabIndex = 0;
            this.listViewrecall.UseCompatibleStateImageBehavior = false;
            this.listViewrecall.View = System.Windows.Forms.View.Details;
            this.listViewrecall.SelectedIndexChanged += new System.EventHandler(this.listViewrecall_SelectedIndexChanged);
            this.listViewrecall.MouseHover += new System.EventHandler(this.listViewrecall_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timee
            // 
            this.timee.AutoSize = true;
            this.timee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timee.Location = new System.Drawing.Point(1123, 612);
            this.timee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timee.Name = "timee";
            this.timee.Size = new System.Drawing.Size(58, 26);
            this.timee.TabIndex = 7;
            this.timee.Text = "time";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(21, 602);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(124, 45);
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
            this.recall.Location = new System.Drawing.Point(573, 602);
            this.recall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.recall.Name = "recall";
            this.recall.Size = new System.Drawing.Size(124, 45);
            this.recall.TabIndex = 5;
            this.recall.Text = "Recall";
            this.recall.UseVisualStyleBackColor = false;
            this.recall.Click += new System.EventHandler(this.recall_Click_1);
            // 
            // KitchenBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1275, 666);
            this.Controls.Add(this.recall);
            this.Controls.Add(this.recallpanel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.timee);
            this.Controls.Add(this.PanelOrders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KitchenBar";
            this.Text = "Kitchen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KitchenBar_Load);
            this.recallpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelOrders;
        private System.Windows.Forms.Panel recallpanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timee;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button recall;
        private System.Windows.Forms.ListView listViewrecall;
    }
}