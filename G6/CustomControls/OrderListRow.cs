using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace CustomControls
{
    public partial class OrderListRow : UserControl
    {
        private OrderItem item;

        public int Amount
        {
            get
            {
                return Convert.ToInt32(Lbl_Amount.Text);
            }
            set
            {
                Lbl_Amount.Text = value.ToString();
                item.Quantity = Amount;
            }
        }

        public OrderItem GetItem()
        {
            return item;
        }

        public OrderListRow(OrderItem _item)
        {
            InitializeComponent();
            item = _item;
        }
        public OrderListRow()
        {
            InitializeComponent();
            item = new OrderItem();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Amount++;
        }

        private void Btn_Reduce_Click(object sender, EventArgs e)
        {
            Amount--;
        }
    }
}
