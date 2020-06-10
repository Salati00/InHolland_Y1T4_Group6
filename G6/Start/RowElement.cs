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

namespace Start
{
    public partial class RowElement : UserControl
    {
        private Order orders;
        private Menu_Item item;

        public RowElement(Menu_Item _item, ref Order order)
        {
            InitializeComponent();
            orders = order;
            SetMenuItem(_item);
        }

        private void Initialize(Menu_Item _item)
        {
            item = _item;
            Lbl_ItemName.Text = item.Name;
        }

        public void SetMenuItem(Menu_Item _item)
        {
            Initialize(_item);
        }

        public Menu_Item GetMenuItem()
        {
            return item;
        }

        public Order Orders
        {
            get
            {
                return orders;
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in orders.OrderItems)
            {
                if(item.MenuItem.Menu_Item_ID == this.item.Menu_Item_ID)
                {
                    item.Quantity++;
                    count++;
                }
            }
            if(count == 0)
            {
                orders.OrderItems.Add(new OrderItem()
                {
                    Quantity = 1,
                    DateTime = DateTime.UtcNow,
                    MenuItem = this.item,
                    Status = 0
                }
                ); 

            }
        }
    }
}
