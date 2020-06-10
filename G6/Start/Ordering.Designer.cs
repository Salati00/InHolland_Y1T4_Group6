namespace Start
{
    partial class Ordering
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
            this.Dgv_OrdrMenu = new System.Windows.Forms.DataGridView();
            this.Dgv_OrderList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tab_Ordering = new System.Windows.Forms.TabControl();
            this.TPag_Food = new System.Windows.Forms.TabPage();
            this.Btn_LunchBites = new System.Windows.Forms.Button();
            this.Btn_LunchSpecial = new System.Windows.Forms.Button();
            this.Btn_LunchMain = new System.Windows.Forms.Button();
            this.Rdb_Dinner = new System.Windows.Forms.RadioButton();
            this.Rdb_Lunch = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_DinksWines = new System.Windows.Forms.Button();
            this.Btn_DrinksBeers = new System.Windows.Forms.Button();
            this.Btn_DrinksHot = new System.Windows.Forms.Button();
            this.Btn_DrinksMain = new System.Windows.Forms.Button();
            this.Cmb_TableSelection = new System.Windows.Forms.ComboBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_SendClose = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrdrMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.Tab_Ordering.SuspendLayout();
            this.TPag_Food.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_OrdrMenu
            // 
            this.Dgv_OrdrMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_OrdrMenu.Location = new System.Drawing.Point(12, 12);
            this.Dgv_OrdrMenu.Name = "Dgv_OrdrMenu";
            this.Dgv_OrdrMenu.Size = new System.Drawing.Size(616, 314);
            this.Dgv_OrdrMenu.TabIndex = 0;
            // 
            // Dgv_OrderList
            // 
            this.Dgv_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_OrderList.Location = new System.Drawing.Point(634, 12);
            this.Dgv_OrderList.Name = "Dgv_OrderList";
            this.Dgv_OrderList.Size = new System.Drawing.Size(362, 314);
            this.Dgv_OrderList.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tab_Ordering);
            this.panel1.Location = new System.Drawing.Point(12, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 193);
            this.panel1.TabIndex = 4;
            // 
            // Tab_Ordering
            // 
            this.Tab_Ordering.Controls.Add(this.TPag_Food);
            this.Tab_Ordering.Controls.Add(this.tabPage2);
            this.Tab_Ordering.Location = new System.Drawing.Point(4, 4);
            this.Tab_Ordering.Name = "Tab_Ordering";
            this.Tab_Ordering.SelectedIndex = 0;
            this.Tab_Ordering.Size = new System.Drawing.Size(609, 186);
            this.Tab_Ordering.TabIndex = 0;
            // 
            // TPag_Food
            // 
            this.TPag_Food.Controls.Add(this.Btn_LunchBites);
            this.TPag_Food.Controls.Add(this.Btn_LunchSpecial);
            this.TPag_Food.Controls.Add(this.Btn_LunchMain);
            this.TPag_Food.Controls.Add(this.Rdb_Dinner);
            this.TPag_Food.Controls.Add(this.Rdb_Lunch);
            this.TPag_Food.Location = new System.Drawing.Point(4, 22);
            this.TPag_Food.Name = "TPag_Food";
            this.TPag_Food.Padding = new System.Windows.Forms.Padding(3);
            this.TPag_Food.Size = new System.Drawing.Size(601, 160);
            this.TPag_Food.TabIndex = 0;
            this.TPag_Food.Text = "Food";
            this.TPag_Food.UseVisualStyleBackColor = true;
            // 
            // Btn_LunchBites
            // 
            this.Btn_LunchBites.Location = new System.Drawing.Point(475, 36);
            this.Btn_LunchBites.Name = "Btn_LunchBites";
            this.Btn_LunchBites.Size = new System.Drawing.Size(84, 84);
            this.Btn_LunchBites.TabIndex = 4;
            this.Btn_LunchBites.Text = "Bites";
            this.Btn_LunchBites.UseVisualStyleBackColor = true;
            this.Btn_LunchBites.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_LunchSpecial
            // 
            this.Btn_LunchSpecial.Location = new System.Drawing.Point(314, 36);
            this.Btn_LunchSpecial.Name = "Btn_LunchSpecial";
            this.Btn_LunchSpecial.Size = new System.Drawing.Size(84, 84);
            this.Btn_LunchSpecial.TabIndex = 3;
            this.Btn_LunchSpecial.Text = "Specials";
            this.Btn_LunchSpecial.UseVisualStyleBackColor = true;
            this.Btn_LunchSpecial.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_LunchMain
            // 
            this.Btn_LunchMain.Location = new System.Drawing.Point(144, 36);
            this.Btn_LunchMain.Name = "Btn_LunchMain";
            this.Btn_LunchMain.Size = new System.Drawing.Size(84, 84);
            this.Btn_LunchMain.TabIndex = 2;
            this.Btn_LunchMain.Text = "Main";
            this.Btn_LunchMain.UseVisualStyleBackColor = true;
            this.Btn_LunchMain.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Rdb_Dinner
            // 
            this.Rdb_Dinner.AutoSize = true;
            this.Rdb_Dinner.Location = new System.Drawing.Point(20, 90);
            this.Rdb_Dinner.Name = "Rdb_Dinner";
            this.Rdb_Dinner.Size = new System.Drawing.Size(56, 17);
            this.Rdb_Dinner.TabIndex = 1;
            this.Rdb_Dinner.TabStop = true;
            this.Rdb_Dinner.Text = "Dinner";
            this.Rdb_Dinner.UseVisualStyleBackColor = true;
            // 
            // Rdb_Lunch
            // 
            this.Rdb_Lunch.AutoSize = true;
            this.Rdb_Lunch.Location = new System.Drawing.Point(20, 53);
            this.Rdb_Lunch.Name = "Rdb_Lunch";
            this.Rdb_Lunch.Size = new System.Drawing.Size(55, 17);
            this.Rdb_Lunch.TabIndex = 0;
            this.Rdb_Lunch.TabStop = true;
            this.Rdb_Lunch.Text = "Lunch";
            this.Rdb_Lunch.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_DinksWines);
            this.tabPage2.Controls.Add(this.Btn_DrinksBeers);
            this.tabPage2.Controls.Add(this.Btn_DrinksHot);
            this.tabPage2.Controls.Add(this.Btn_DrinksMain);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Drinks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_DinksWines
            // 
            this.Btn_DinksWines.Location = new System.Drawing.Point(473, 37);
            this.Btn_DinksWines.Name = "Btn_DinksWines";
            this.Btn_DinksWines.Size = new System.Drawing.Size(84, 84);
            this.Btn_DinksWines.TabIndex = 8;
            this.Btn_DinksWines.Text = "Wines";
            this.Btn_DinksWines.UseVisualStyleBackColor = true;
            this.Btn_DinksWines.Click += new System.EventHandler(this.Btn_DrinkCategory_Click);
            // 
            // Btn_DrinksBeers
            // 
            this.Btn_DrinksBeers.Location = new System.Drawing.Point(333, 37);
            this.Btn_DrinksBeers.Name = "Btn_DrinksBeers";
            this.Btn_DrinksBeers.Size = new System.Drawing.Size(84, 84);
            this.Btn_DrinksBeers.TabIndex = 7;
            this.Btn_DrinksBeers.Text = "Beers";
            this.Btn_DrinksBeers.UseVisualStyleBackColor = true;
            this.Btn_DrinksBeers.Click += new System.EventHandler(this.Btn_DrinkCategory_Click);
            // 
            // Btn_DrinksHot
            // 
            this.Btn_DrinksHot.Location = new System.Drawing.Point(191, 37);
            this.Btn_DrinksHot.Name = "Btn_DrinksHot";
            this.Btn_DrinksHot.Size = new System.Drawing.Size(84, 84);
            this.Btn_DrinksHot.TabIndex = 6;
            this.Btn_DrinksHot.Text = "Hot";
            this.Btn_DrinksHot.UseVisualStyleBackColor = true;
            this.Btn_DrinksHot.Click += new System.EventHandler(this.Btn_DrinkCategory_Click);
            // 
            // Btn_DrinksMain
            // 
            this.Btn_DrinksMain.Location = new System.Drawing.Point(54, 37);
            this.Btn_DrinksMain.Name = "Btn_DrinksMain";
            this.Btn_DrinksMain.Size = new System.Drawing.Size(84, 84);
            this.Btn_DrinksMain.TabIndex = 5;
            this.Btn_DrinksMain.Text = "Main";
            this.Btn_DrinksMain.UseVisualStyleBackColor = true;
            this.Btn_DrinksMain.Click += new System.EventHandler(this.Btn_DrinkCategory_Click);
            // 
            // Cmb_TableSelection
            // 
            this.Cmb_TableSelection.FormattingEnabled = true;
            this.Cmb_TableSelection.Location = new System.Drawing.Point(662, 358);
            this.Cmb_TableSelection.Name = "Cmb_TableSelection";
            this.Cmb_TableSelection.Size = new System.Drawing.Size(312, 21);
            this.Cmb_TableSelection.TabIndex = 5;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(662, 385);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(312, 67);
            this.Btn_Send.TabIndex = 6;
            this.Btn_Send.Text = "Send Order";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_SendClose
            // 
            this.Btn_SendClose.Location = new System.Drawing.Point(662, 458);
            this.Btn_SendClose.Name = "Btn_SendClose";
            this.Btn_SendClose.Size = new System.Drawing.Size(312, 27);
            this.Btn_SendClose.TabIndex = 7;
            this.Btn_SendClose.Text = "Send and close Order";
            this.Btn_SendClose.UseVisualStyleBackColor = true;
            this.Btn_SendClose.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Quit
            // 
            this.Btn_Quit.Location = new System.Drawing.Point(662, 498);
            this.Btn_Quit.Name = "Btn_Quit";
            this.Btn_Quit.Size = new System.Drawing.Size(312, 27);
            this.Btn_Quit.TabIndex = 8;
            this.Btn_Quit.Text = "Close";
            this.Btn_Quit.UseVisualStyleBackColor = true;
            this.Btn_Quit.Click += new System.EventHandler(this.Btn_Quit_Click);
            // 
            // Ordering
            // 
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Btn_SendClose);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Cmb_TableSelection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_OrderList);
            this.Controls.Add(this.Dgv_OrdrMenu);
            this.Name = "Ordering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordering";
            this.Load += new System.EventHandler(this.Ordering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrdrMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_OrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Tab_Ordering.ResumeLayout(false);
            this.TPag_Food.ResumeLayout(false);
            this.TPag_Food.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_OrdrMenu;
        private System.Windows.Forms.DataGridView Dgv_OrderList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Tab_Ordering;
        private System.Windows.Forms.TabPage TPag_Food;
        private System.Windows.Forms.Button Btn_LunchBites;
        private System.Windows.Forms.Button Btn_LunchSpecial;
        private System.Windows.Forms.Button Btn_LunchMain;
        private System.Windows.Forms.RadioButton Rdb_Dinner;
        private System.Windows.Forms.RadioButton Rdb_Lunch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_DinksWines;
        private System.Windows.Forms.Button Btn_DrinksBeers;
        private System.Windows.Forms.Button Btn_DrinksHot;
        private System.Windows.Forms.Button Btn_DrinksMain;
        private System.Windows.Forms.ComboBox Cmb_TableSelection;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_SendClose;
        private System.Windows.Forms.Button Btn_Quit;
    }
}