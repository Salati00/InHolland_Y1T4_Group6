using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        //order items
        public int Order_Item_Id { get; set; }
        public DateTime Time { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }

        //menu items
        public string ItemName { get; set; }
        public string ItemType { get; set; }

        //state
        public string state { get; set; }


    }
}
