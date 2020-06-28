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
        private int posX = 15;
        private int posY = 15;

        public Order GetOrder()
        {
            List<OrderItem> itemsToRemove = orders.OrderItems.Where(x => x.Quantity < 1).ToList();
            
            foreach (var itemToRemove in itemsToRemove)
                orders.OrderItems.Remove(itemToRemove);
            return orders;
        }
        
        public OrderList()
        {
            InitializeComponent();
            orders = new Order();
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
                posY += 75;
            }
        }

        public void Clear()
        {
            posX = 15;
            posY = 15;
            orders = new Order();
            Controls.OfType<OrderListRow>().ToList().ForEach(x => this.Controls.Remove(x));
        }

        public void RemoveSpace()
        {
            posY -= 75;
        }
    }
}
