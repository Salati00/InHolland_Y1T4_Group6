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
            this.Btn_Food3 = new System.Windows.Forms.Button();
            this.Btn_Food2 = new System.Windows.Forms.Button();
            this.Btn_Food1 = new System.Windows.Forms.Button();
            this.Rdb_Dinner = new System.Windows.Forms.RadioButton();
            this.Rdb_Lunch = new System.Windows.Forms.RadioButton();
            this.Btn_DinksWines = new System.Windows.Forms.Button();
            this.Btn_DrinksBeers = new System.Windows.Forms.Button();
            this.Btn_DrinksHot = new System.Windows.Forms.Button();
            this.Btn_DrinksMain = new System.Windows.Forms.Button();
            this.Cmb_TableSelection = new System.Windows.Forms.ComboBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_SendClose = new System.Windows.Forms.Button();
            this.Btn_Quit = new System.Windows.Forms.Button();
            this.Lbl_CurrentCategory = new System.Windows.Forms.Label();
            this.OrderList = new Start.OrderList();
            this.Gpb_Drinks = new System.Windows.Forms.GroupBox();
            this.Gpb_Drinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Food3
            // 
            this.Btn_Food3.Location = new System.Drawing.Point(428, 293);
            this.Btn_Food3.Name = "Btn_Food3";
            this.Btn_Food3.Size = new System.Drawing.Size(100, 60);
            this.Btn_Food3.TabIndex = 4;
            this.Btn_Food3.Tag = "Bites";
            this.Btn_Food3.Text = "Bites";
            this.Btn_Food3.UseVisualStyleBackColor = true;
            this.Btn_Food3.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_Food2
            // 
            this.Btn_Food2.Location = new System.Drawing.Point(293, 293);
            this.Btn_Food2.Name = "Btn_Food2";
            this.Btn_Food2.Size = new System.Drawing.Size(100, 60);
            this.Btn_Food2.TabIndex = 3;
            this.Btn_Food2.Tag = "Specials";
            this.Btn_Food2.Text = "Specials";
            this.Btn_Food2.UseVisualStyleBackColor = true;
            this.Btn_Food2.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_Food1
            // 
            this.Btn_Food1.Location = new System.Drawing.Point(162, 293);
            this.Btn_Food1.Name = "Btn_Food1";
            this.Btn_Food1.Size = new System.Drawing.Size(100, 60);
            this.Btn_Food1.TabIndex = 2;
            this.Btn_Food1.Tag = "Main";
            this.Btn_Food1.Text = "Main";
            this.Btn_Food1.UseVisualStyleBackColor = true;
            this.Btn_Food1.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Rdb_Dinner
            // 
            this.Rdb_Dinner.AutoSize = true;
            this.Rdb_Dinner.Location = new System.Drawing.Point(81, 315);
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
            this.Rdb_Lunch.Checked = true;
            this.Rdb_Lunch.Location = new System.Drawing.Point(20, 315);
            this.Rdb_Lunch.Name = "Rdb_Lunch";
            this.Rdb_Lunch.Size = new System.Drawing.Size(55, 17);
            this.Rdb_Lunch.TabIndex = 0;
            this.Rdb_Lunch.TabStop = true;
            this.Rdb_Lunch.Text = "Lunch";
            this.Rdb_Lunch.UseVisualStyleBackColor = true;
            this.Rdb_Lunch.CheckedChanged += new System.EventHandler(this.Rdb_CheckedUpdate);
            // 
            // Btn_DinksWines
            // 
            this.Btn_DinksWines.Location = new System.Drawing.Point(432, 41);
            this.Btn_DinksWines.Name = "Btn_DinksWines";
            this.Btn_DinksWines.Size = new System.Drawing.Size(84, 84);
            this.Btn_DinksWines.TabIndex = 8;
            this.Btn_DinksWines.Tag = "Wines";
            this.Btn_DinksWines.Text = "Wines";
            this.Btn_DinksWines.UseVisualStyleBackColor = true;
            this.Btn_DinksWines.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_DrinksBeers
            // 
            this.Btn_DrinksBeers.Location = new System.Drawing.Point(297, 41);
            this.Btn_DrinksBeers.Name = "Btn_DrinksBeers";
            this.Btn_DrinksBeers.Size = new System.Drawing.Size(84, 84);
            this.Btn_DrinksBeers.TabIndex = 7;
            this.Btn_DrinksBeers.Tag = "Beers";
            this.Btn_DrinksBeers.Text = "Beers";
            this.Btn_DrinksBeers.UseVisualStyleBackColor = true;
            this.Btn_DrinksBeers.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_DrinksHot
            // 
            this.Btn_DrinksHot.Location = new System.Drawing.Point(166, 41);
            this.Btn_DrinksHot.Name = "Btn_DrinksHot";
            this.Btn_DrinksHot.Size = new System.Drawing.Size(84, 84);
            this.Btn_DrinksHot.TabIndex = 6;
            this.Btn_DrinksHot.Tag = "Hot Drinks";
            this.Btn_DrinksHot.Text = "Hot";
            this.Btn_DrinksHot.UseVisualStyleBackColor = true;
            this.Btn_DrinksHot.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
            // 
            // Btn_DrinksMain
            // 
            this.Btn_DrinksMain.Location = new System.Drawing.Point(41, 41);
            this.Btn_DrinksMain.Name = "Btn_DrinksMain";
            this.Btn_DrinksMain.Size = new System.Drawing.Size(84, 84);
            this.Btn_DrinksMain.TabIndex = 5;
            this.Btn_DrinksMain.Tag = "Soft Drinks";
            this.Btn_DrinksMain.Text = "Soft";
            this.Btn_DrinksMain.UseVisualStyleBackColor = true;
            this.Btn_DrinksMain.Click += new System.EventHandler(this.Btn_FoodCategory_Click);
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
            this.Btn_SendClose.Text = "Mark order as Closed for payment";
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
            // Lbl_CurrentCategory
            // 
            this.Lbl_CurrentCategory.AutoSize = true;
            this.Lbl_CurrentCategory.Location = new System.Drawing.Point(441, 12);
            this.Lbl_CurrentCategory.Name = "Lbl_CurrentCategory";
            this.Lbl_CurrentCategory.Size = new System.Drawing.Size(0, 13);
            this.Lbl_CurrentCategory.TabIndex = 9;
            // 
            // OrderList
            // 
            this.OrderList.AutoScroll = true;
            this.OrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderList.Location = new System.Drawing.Point(598, 12);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(398, 308);
            this.OrderList.TabIndex = 10;
            // 
            // Gpb_Drinks
            // 
            this.Gpb_Drinks.Controls.Add(this.Btn_DrinksBeers);
            this.Gpb_Drinks.Controls.Add(this.Btn_DinksWines);
            this.Gpb_Drinks.Controls.Add(this.Btn_DrinksMain);
            this.Gpb_Drinks.Controls.Add(this.Btn_DrinksHot);
            this.Gpb_Drinks.Location = new System.Drawing.Point(12, 364);
            this.Gpb_Drinks.Name = "Gpb_Drinks";
            this.Gpb_Drinks.Size = new System.Drawing.Size(570, 161);
            this.Gpb_Drinks.TabIndex = 11;
            this.Gpb_Drinks.TabStop = false;
            this.Gpb_Drinks.Text = "Drinks";
            // 
            // Ordering
            // 
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.Gpb_Drinks);
            this.Controls.Add(this.Btn_Food3);
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.Btn_Food2);
            this.Controls.Add(this.Lbl_CurrentCategory);
            this.Controls.Add(this.Btn_Food1);
            this.Controls.Add(this.Btn_Quit);
            this.Controls.Add(this.Rdb_Dinner);
            this.Controls.Add(this.Btn_SendClose);
            this.Controls.Add(this.Rdb_Lunch);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Cmb_TableSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordering";
            this.Load += new System.EventHandler(this.Ordering_Load);
            this.Gpb_Drinks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Food3;
        private System.Windows.Forms.Button Btn_Food2;
        private System.Windows.Forms.Button Btn_Food1;
        private System.Windows.Forms.RadioButton Rdb_Dinner;
        private System.Windows.Forms.RadioButton Rdb_Lunch;
        private System.Windows.Forms.Button Btn_DinksWines;
        private System.Windows.Forms.Button Btn_DrinksBeers;
        private System.Windows.Forms.Button Btn_DrinksHot;
        private System.Windows.Forms.Button Btn_DrinksMain;
        private System.Windows.Forms.ComboBox Cmb_TableSelection;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_SendClose;
        private System.Windows.Forms.Button Btn_Quit;
        private System.Windows.Forms.Label Lbl_CurrentCategory;
        private OrderList OrderList;
        private System.Windows.Forms.GroupBox Gpb_Drinks;
    }
}