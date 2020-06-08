using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        
        public Item_Types Item_Types { get; set; }
        public Menu_Item Item { get; set; }
        public Order order { get; set; }
        public Order_Status Status { get; set; }
        public DateTime dateTime { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }

    }
}
