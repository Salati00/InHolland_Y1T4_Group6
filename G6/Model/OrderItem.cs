using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public Menu_Item MenuItem { get; set; }
        public Order_Status Status { get; set; }
        public DateTime DateTime { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }

    }
}
