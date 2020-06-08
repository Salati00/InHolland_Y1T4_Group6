using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int Order_ID { get; set; }
        public Staff Staff_ID { get; set; }
        public Table Table_ID { get; set; }
        public DateTime Time { get; set; }

        public List<OrderItem> orders { get; set; }
    }
}
