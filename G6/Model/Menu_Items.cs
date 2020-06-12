using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menu_Item
    {
        public int Menu_Item_ID { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public Item_Type Type { get; set; }
        public int Stock { get; set; }

    }
}
