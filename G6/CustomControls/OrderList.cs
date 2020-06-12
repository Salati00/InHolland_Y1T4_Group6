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
using CustomControls;

namespace Start
{
    public partial class OrderList : UserControl
    {
        private Order orders;
        private int posX = 25;
        private int posY = 25;

        public Order GetOrder()
        {
            return orders;
        }
        
        public OrderList()
        {
            InitializeComponent();
            orders = new Order();
            orders.OrderItems = new List<OrderItem>();
        }

        public void AddItem(Menu_Item i)
        {
            VerticalScroll.Value = 0;
            int count = 0;
            foreach (var item in orders.OrderItems)
            {
                if (item.MenuItem.Menu_Item_ID == i.Menu_Item_ID)
                {
                    item.Quantity++;
                    count++;
                    Controls.OfType<OrderListRow>().ToList().ForEach(x => { if (x.Item.MenuItem.Menu_Item_ID == i.Menu_Item_ID) { x.Amount++; } });
                }
            }
            if (count == 0)
            {
                OrderItem it = new OrderItem()
                {
                    Quantity = 1,
                    DateTime = DateTime.UtcNow,
                    MenuItem = i,
                    Status = 0
                };
                orders.OrderItems.Add(it);

                OrderListRow listRow = new OrderListRow(it);
                listRow.Top = posY;
                listRow.Left = posX;
                this.Controls.Add(listRow);
                listRow.Show();
                posY += 50;
            }
        }
    }
}
