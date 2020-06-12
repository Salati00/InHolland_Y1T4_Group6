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
        //private Order orders;
        private OrderList ol;
        private Menu_Item item;

        public RowElement(Menu_Item _item, OrderList _ol)
        {
            InitializeComponent();
            ol = _ol;
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

        /*public Order Orders
        {
            get
            {
                return orders;
            }
        }*/

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (item.Stock >= 1)
                ol.AddItem(this.item);
            else
                MessageBox.Show("This Item is out of stock");
        }
    }
}
