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

        public Ordering()
        {
            InitializeComponent();
            ord = new OrderingService();
        }

        private void Btn_FoodCategory_Click(object sender, EventArgs e)
        {
            string Category = ((Button)sender).Text;
            List<Menu_Items> Menu = new List<Menu_Items>();

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

        private void Ordering_Load(object sender, EventArgs e)
        {

        }


        private void Btn_Send_Click(object sender, EventArgs e)
        {
            ord.SendOrder(new Orders(), new List<Menu_Items>(), (((Button)sender).Name == "Btn_Send") ? false : true);
            throw new NotImplementedException();
        }
    }
}
