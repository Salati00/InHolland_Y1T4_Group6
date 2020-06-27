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
using System.Windows.Forms.VisualStyles;
using Start;

namespace CustomControls
{
    public partial class OrderListRow : UserControl
    {
        private OrderItem item;

        public OrderItem Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
                Lbl_Name.Text = value.MenuItem.Name;
            }
        }

        public int Amount
        {
            get
            {
                return Convert.ToInt32(Lbl_Amount.Text);
            }
            set
            {
                if (value > 0)
                {
                    if (value <= item.MenuItem.Stock)
                    {
                        Lbl_Amount.Text = value.ToString();
                        item.Quantity = Amount;
                    }
                    else
                        MessageBox.Show("The selected item is out of stock");
                }
            }
        }

        public OrderItem GetItem()
        {
            return Item;
        }

        public OrderListRow(OrderItem _item)
        {
            InitializeComponent();
            Item = _item;
        }
        public OrderListRow()
        {
            InitializeComponent();
            Item = new OrderItem();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            Parent.Controls.OfType<OrderListRow>().ToList().ForEach(x => 
            {
                if (x.Top > this.Top)
                {
                    x.Top -= 75;
                }
            });
            ((OrderList)this.Parent).RemoveSpace();

            item.Quantity = 0;
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

        private void Txt_Notes_TextChanged(object sender, EventArgs e)
        {
            item.Comment = Txt_Notes.Text;
        }
    }
}
