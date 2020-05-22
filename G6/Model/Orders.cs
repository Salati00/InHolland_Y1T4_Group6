using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Orders
    {
        public Staff Staff_ID { get; set; }
        public Tables Table_ID { get; set; }
        public DateTime Time { get; set; }
    }
}
