using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        //public Staff staff;
        //public Table table;
        //public OrderItem item;
        public int Order_ID { get; set; }
        public int Staff_ID { get; set; } 
        public int Table_ID { get; set; }
        public DateTime Time { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
