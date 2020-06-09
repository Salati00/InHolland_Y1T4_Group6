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
        Staff member;
        public Ordering(Table table)
        {
            InitializeComponent();
            InitializeCombobox(table.Table_Number);
        }

        public Ordering()
        {
            InitializeComponent();
            InitializeCombobox();
        }
        private void Ordering_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            ord = new OrderingService();
            member = new Staff();
        }

        //Methods

        private void InitializeCombobox(int TableNumber = 0)
        {

            Cmb_TableSelection.SelectedIndex = (1 - (TableNumber));
        }

        private void Btn_FoodCategory_Click(object sender, EventArgs e)
        {
            string Category = ((Button)sender).Text;
            List<Menu_Item> Menu = new List<Menu_Item>();

            switch (Category)
            {
                case "Main":
                    Menu = ord.GetMenuItems("Main");
                    break;
                default:break;
            }

            Dgv_OrdrMenu.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
            dgvc.HeaderText = "Name";
            dgvc.DataPropertyName = "Value";
            DataGridViewButtonColumn dgvbt = new DataGridViewButtonColumn();
            dgvbt.Text = "ADD";// works also when bound
            dgvbt.UseColumnTextForButtonValue = true;

            Dgv_OrdrMenu.CellClick += new DataGridViewCellEventHandler(grd_CellClick);

            Dgv_OrdrMenu.Columns.Add(dgvc);
            Dgv_OrdrMenu.Columns.Add(dgvbt);

            Dgv_OrdrMenu.DataSource = Menu;
        }

        void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1)
            {
                throw new NotImplementedException();
            }
        }

        private void Btn_DrinkCategory_Click(object sender, EventArgs e)
        {
            string Category = ((Button)sender).Text;
        }


        private void Btn_Send_Click(object sender, EventArgs e)
        {
            this.Hide();
            ord.SendOrder(new Order(), new List<Menu_Item>(), (((Button)sender).Name == "Btn_Send") ? false : true);
            //Overview ov = new Overview();
            //ov.ShowDialog();
            this.Close();
        }
    }
}
