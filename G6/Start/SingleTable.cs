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
        Order order;
        OrderingService service;

        public SingleTable(Table _CurrentTable)
        {
            CurrentTable = _CurrentTable;
            InitializeComponent();
            service = new OrderingService();
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
            SingleTable_Status();
            Lbl_TableNum.Text = CurrentTable.Table_Number.ToString();
            lbl_status.Text = CurrentTable.Status.ToString();
            /*List<Order> order_list = service.GetOrders();
            if (order_list == null)
            {
                MessageBox.Show("There are no orders.");
            }
            FillOrders(order_list);
            FillOrderItems(order);
            */

            //order = service.GetOrderFromTable(CurrentTable);

            Lst_TableOrders.Clear();
            Lst_TableOrders.Columns.Add("Order Item ID", 80);
            Lst_TableOrders.Columns.Add("Menu Item", 120);
            Lst_TableOrders.Columns.Add("Order ID", 60);
            Lst_TableOrders.Columns.Add("Status", 80);
            Lst_TableOrders.Columns.Add("DateTime", 120);
            Lst_TableOrders.Columns.Add("Quantity", 60);
            Lst_TableOrders.Columns.Add("Notes", 150);

            //foreach (OrderItem a in order.OrderItems)
            //{
            //    if (a.OrderID == order.Order_ID && CurrentTable.Table_ID == order.Table_ID)
            //    {
            //        ListViewItem lvi = new ListViewItem(a.ItemID.ToString());
            //        lvi.SubItems.Add(a.MenuItem.Name.ToString());
            //        lvi.SubItems.Add(a.OrderID.ToString());
            //        lvi.SubItems.Add(a.DateTime.ToString());
            //        lvi.SubItems.Add(a.Quantity.ToString());
            //        lvi.SubItems.Add(a.Comment.ToString());
            //        Lst_TableOrders.Items.Add(lvi);
            //    }
            //}
        }

        /*
        private void FillOrders(List<Order> orders)
        {
            Lst_TableOrders.Items.Clear();
            foreach (Order o in orders)
            {
                ListViewItem lvi = new ListViewItem(o.Order_ID.ToString());
                lvi.SubItems.Add(o.Staff_ID.ToString()); 
                lvi.SubItems.Add(o.Table_ID.ToString()); 
                lvi.SubItems.Add(o.Time.ToString());
                lvi.Tag = 0;
                Lst_TableOrders.Items.Add(lvi);
            }
        }

        private void FillOrderItems(Order order)
        {
            lst_details.Items.Clear();
            foreach (OrderItem oi in order.OrderItems)
            {
                ListViewItem lvi = new ListViewItem(oi.MenuItem.Name);
                lvi.SubItems.Add(oi.Quantity.ToString());
                lvi.SubItems.Add(oi.Status.ToString());
                lvi.SubItems.Add(oi.Comment.ToString());
                lvi.Tag = oi;
                lst_details.Items.Add(lvi);
            }
        }
        */

        private void btn_ready_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The order is ready to be served.");
            this.DialogResult = DialogResult.OK;
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            lbl_status.Text = Table_Status.Reserved.ToString();
            btn_reserve.Enabled = false;
            btn_reserve.BackColor = Color.Silver;
            btn_cancel.Enabled = true;
            btn_cancel.BackColor = Color.Salmon;
            btn_AddOrder.Enabled = true;
            btn_AddOrder.BackColor = Color.Salmon;
            btn_occupied.Enabled = false;
            btn_occupied.BackColor = Color.Silver;
            btn_ready.Enabled = true;
            btn_ready.BackColor = Color.Salmon;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_status.Text = Table_Status.Available.ToString();
            btn_AddOrder.Enabled = false;
            btn_AddOrder.BackColor = Color.Silver;
            btn_ready.Enabled = false;
            btn_ready.BackColor = Color.Silver;
            btn_cancel.Enabled = false;
            btn_cancel.BackColor = Color.Silver;
            btn_occupied.Enabled = true;
            btn_occupied.BackColor = Color.Salmon;
            btn_reserve.Enabled = true;
            btn_reserve.BackColor = Color.Salmon;
        }

        private void btn_occupied_Click(object sender, EventArgs e)
        {
            lbl_status.Text = Table_Status.Occupied.ToString();
            btn_AddOrder.Enabled = true;
            btn_AddOrder.BackColor = Color.Salmon;
            btn_cancel.Enabled = false;
            btn_cancel.BackColor = Color.Silver;
            btn_occupied.Enabled = false;
            btn_occupied.BackColor = Color.Silver;
            btn_ready.Enabled = true;
            btn_ready.BackColor = Color.Salmon;
            btn_reserve.Enabled = false;
            btn_reserve.BackColor = Color.Silver;
        }

        private void SingleTable_Status()
        {
            if (CurrentTable.Status == Table_Status.Available)
            {
                btn_cancel.Enabled = false;
                btn_cancel.BackColor = Color.Silver;
                btn_AddOrder.Enabled = false;
                btn_AddOrder.BackColor = Color.Silver;
                btn_ready.Enabled = false;
                btn_ready.BackColor = Color.Silver;
            }
            else if (CurrentTable.Status == Table_Status.Occupied)
            {
                btn_occupied.Enabled = false;
                btn_occupied.BackColor = Color.Silver;
                btn_reserve.Enabled = false;
                btn_reserve.BackColor = Color.Silver;
                btn_cancel.Enabled = false;
                btn_cancel.BackColor = Color.Silver;
            }
            else
            {
                btn_occupied.Enabled = false;
                btn_occupied.BackColor = Color.Silver;
                btn_reserve.Enabled = false;
                btn_reserve.BackColor = Color.Silver;
            }
        }
    }
}
