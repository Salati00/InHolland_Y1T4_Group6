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
        Staff member;
        TableService tableService;
        OrderingService orderService;

        public SingleTable(Table _CurrentTable, Staff _member)
        {
            CurrentTable = _CurrentTable;
            InitializeComponent();
            member = _member;
            order = new Order();
            tableService = new TableService();
            orderService = new OrderingService();
        }

        private void Btn_AddOrder_Click(object sender, EventArgs e)
        {
            Ordering OrderForm = new Ordering(CurrentTable, member);
            this.Hide();
            OrderForm.ShowDialog();
            this.Show();
            this.LoadListView();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SingleTable_Status()
        {
            Lbl_TableNum.Text = CurrentTable.Table_Number.ToString();
            lbl_status.Text = CurrentTable.Status.ToString();
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

        private void SingleTable_Load(object sender, EventArgs e)
        {
            //Lbl_TableNum.Text = CurrentTable.Table_Number.ToString();
            //lbl_status.Text = CurrentTable.Status.ToString();
            SingleTable_Status();
            LoadListView();
        }

        private void LoadListView()
        {
            
            Order order = orderService.GetOrderFromTable(CurrentTable);

            //ListViewItem li = new ListViewItem();

            Lst_TableOrders.Clear();
            Lst_TableOrders.Columns.Add("Order Item ID", 80);
            Lst_TableOrders.Columns.Add("Menu Item", 120);
            Lst_TableOrders.Columns.Add("Order ID", 60);
            Lst_TableOrders.Columns.Add("Status", 80);
            Lst_TableOrders.Columns.Add("DateTime", 120);
            Lst_TableOrders.Columns.Add("Quantity", 60);
            Lst_TableOrders.Columns.Add("Notes", 150);

            foreach (OrderItem o in order.OrderItems)
            {
                if (o.Status != Order_Status.Served)
                {
                    ListViewItem lvi = new ListViewItem(o.ItemID.ToString());
                    lvi.SubItems.Add(o.MenuItem.Name);
                    lvi.SubItems.Add(o.OrderID.ToString());
                    lvi.SubItems.Add(o.Status.ToString());
                    lvi.SubItems.Add(o.DateTime.ToString());
                    lvi.SubItems.Add(o.Quantity.ToString());
                    lvi.SubItems.Add(o.Comment.ToString());
                    Lst_TableOrders.Items.Add(lvi);
                    Lst_TableOrders.Update();
                }
            }
        }

        private void btn_ready_Click(object sender, EventArgs e)
        {
            if (Lst_TableOrders.Items.Count == 0)
            {
                MessageBox.Show("There are no orders");
                //this.DialogResult = DialogResult.OK;
            }
            else
            {
                OrderingService service = new OrderingService();
                service.MarkItemsServed(CurrentTable);
                this.Close();
                /*MessageBox.Show("The order is ready to be served.");
                this.DialogResult = DialogResult.OK;*/
            }
        }

        // buttons RESERVE, CANCEL, OCCUPIED only makes changes in the single table form
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

            ChangeTableStatus(Table_Status.Reserved, "The table has been reserved");
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

            ChangeTableStatus(Table_Status.Available, "The reservation has been cancelled");
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

            ChangeTableStatus(Table_Status.Occupied, "The table has been occupied");
        }

        private void ChangeTableStatus(Table_Status status, string successMessage)
        {
            try
            {
                tableService.ChangeTableStatus(this.CurrentTable, status);
                MessageBox.Show(successMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed - " + ex.Message);
            }
        }
    }
}
