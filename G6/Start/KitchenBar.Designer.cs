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
            System.Windows.Forms.ListViewItem listViewItem71 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem72 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem73 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem74 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem75 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem76 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem77 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem78 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem79 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem80 = new System.Windows.Forms.ListViewItem(new string[] {
            "click",
            "click"}, -1);
            this.PanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.recallpanel = new System.Windows.Forms.Panel();
            this.listViewrecall = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.PanelOrders.Location = new System.Drawing.Point(32, 12);
            this.PanelOrders.Name = "PanelOrders";
            this.PanelOrders.Size = new System.Drawing.Size(1958, 936);
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
            this.recallpanel.Location = new System.Drawing.Point(484, 229);
            this.recallpanel.Name = "recallpanel";
            this.recallpanel.Size = new System.Drawing.Size(926, 462);
            this.recallpanel.TabIndex = 1;
            // 
            // listViewrecall
            // 
            this.listViewrecall.CausesValidation = false;
            this.listViewrecall.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewrecall.HideSelection = false;
            this.listViewrecall.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem71,
            listViewItem72,
            listViewItem73,
            listViewItem74,
            listViewItem75,
            listViewItem76,
            listViewItem77,
            listViewItem78,
            listViewItem79,
            listViewItem80});
            this.listViewrecall.Location = new System.Drawing.Point(-2, -2);
            this.listViewrecall.Name = "listViewrecall";
            this.listViewrecall.Size = new System.Drawing.Size(921, 457);
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
            this.timee.Location = new System.Drawing.Point(1684, 942);
            this.timee.Name = "timee";
            this.timee.Size = new System.Drawing.Size(81, 37);
            this.timee.TabIndex = 7;
            this.timee.Text = "time";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Home.Location = new System.Drawing.Point(32, 926);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(186, 69);
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
            this.recall.Location = new System.Drawing.Point(859, 926);
            this.recall.Name = "recall";
            this.recall.Size = new System.Drawing.Size(186, 69);
            this.recall.TabIndex = 5;
            this.recall.Text = "Recall";
            this.recall.UseVisualStyleBackColor = false;
            this.recall.Click += new System.EventHandler(this.recall_Click_1);
            // 
            // KitchenBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1912, 1024);
            this.Controls.Add(this.recall);
            this.Controls.Add(this.recallpanel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.timee);
            this.Controls.Add(this.PanelOrders);
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}