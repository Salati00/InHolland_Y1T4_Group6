using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;

namespace Start
{
    public partial class SingleTable : Form
    {
        Table CurrentTable;

        public SingleTable(Table _CurrentTable)
        {
            CurrentTable = _CurrentTable;
            InitializeComponent();
        }

        private void Btn_AddOrder_Click(object sender, EventArgs e)
        {
            Ordering OrderForm = new Ordering(CurrentTable);
            OrderForm.ShowDialog();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SingleTable_Load(object sender, EventArgs e)
        {
            Lbl_TableNum.Text = CurrentTable.Table_Number.ToString();

            OrderingService service = new OrderingService();
            List<Order> orderList = service.GetOrders();

            Lst_TableOrders.Clear();
            Lst_TableOrders.Columns.Add("Order ID", 110);
            Lst_TableOrders.Columns.Add("Staff ID", 120);
            Lst_TableOrders.Columns.Add("Table ID", 120);
            Lst_TableOrders.Columns.Add("Time", 120);
            Lst_TableOrders.Columns.Add("Closed", 120);

            foreach (Order o in orderList)
            {
                if (CurrentTable.Table_Number == o.Table_ID)
                {
                    ListViewItem lvi = new ListViewItem(o.Order_ID.ToString());
                    lvi.SubItems.Add(o.Staff_ID.ToString());
                    lvi.SubItems.Add(o.Table_ID.ToString());
                    lvi.SubItems.Add(o.Time.ToString());
                    Lst_TableOrders.Items.Add(lvi);
                }
            }
        }
    }
}
