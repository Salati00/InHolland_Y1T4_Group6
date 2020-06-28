using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace Start
{
    public partial class Ordering : Form
    {
        OrderingService ord;
        TableService tab;
        Staff member;
        Order order;
        Table table;

        public Ordering(Table _table, Staff _member)
        {
            Initialize();
            InitializeCombobox(_table.Table_Number);
            member = _member;
            table = _table;
            
        }

        public Ordering(Staff _member)
        {
            Initialize();
            InitializeCombobox();
            member = _member;
            table = tab.GetTableFromInt(1);
        }

        private void Initialize()
        {
            ord = new OrderingService();
            tab = new TableService();
            member = new Staff();
            order = new Order();
            InitializeComponent();
        }
        private void Ordering_Load(object sender, EventArgs e)
        {
        }

        //Methods

        private void InitializeCombobox(int TableNumber = 0)
        {
            List<Table> tables = tab.GetAllTables();
            Dictionary<int, string> Wrapper = new Dictionary<int, string>();
            foreach (var item in tables)
            {
                 Wrapper.Add(item.Table_ID, $"Table number: {item.Table_Number}");
            }
            Cmb_TableSelection.ValueMember = "Key";
            Cmb_TableSelection.DisplayMember = "Value";
            Cmb_TableSelection.DataSource = new BindingSource(Wrapper, null);

            Cmb_TableSelection.SelectedIndex = TableNumber == 0?TableNumber:TableNumber-1;
        }

        private void Btn_FoodCategory_Click(object sender, EventArgs e)
        {
            Controls.OfType<RowElement>().ToList().ForEach(x => this.Controls.Remove(x));
            string Category = ((Button)sender).Tag.ToString();
            List<Menu_Item> Menu;

            Menu = ord.GetMenuItems(Category);

            GenerateTable(Menu);
            Lbl_CurrentCategory.Text = Category;
        }

        private void GenerateTable(List<Menu_Item> Menu)
        {
            Controls.OfType<RowElement>().ToList().ForEach(x => this.Controls.Remove(x));

            int posX = 12;
            int posY = 12;
            foreach (var item in Menu)
            {
                RowElement r = new RowElement(item, this.OrderList);
                r.Top = posY;
                r.Left = posX;
                this.Controls.Add(r);
                r.Show();
                posY += 40;
            }
        }

        private void Rdb_CheckedUpdate(object sender, EventArgs e)
        {
            if (Rdb_Lunch.Checked)
            {
                Btn_Food1.Tag = "Main";
                Btn_Food2.Tag = "Specials";
                Btn_Food3.Tag = "Bites";

                Btn_Food1.Text = "Main";
                Btn_Food2.Text = "Specials";
                Btn_Food3.Text = "Bites";
            }
            else
            {
                Btn_Food1.Tag = "Night Starters";
                Btn_Food2.Tag = "Night Mains";
                Btn_Food3.Tag = "Night Dessert";

                Btn_Food1.Text = "Starters";
                Btn_Food2.Text = "Mains";
                Btn_Food3.Text = "Dessert";
            }
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            table.Table_ID = Convert.ToInt32(Cmb_TableSelection.SelectedValue);
            order = OrderList.GetOrder();
            order.Staff_ID = member.Staff_ID;
            order.Table_ID = table.Table_ID;
            ord.SendOrder(order, (((Button)sender).Name == "Btn_Send") ? false : true);
            OrderList.Clear();
            if (((Button)sender).Name != "Btn_Send")
                this.Close();
        }

    }
}
