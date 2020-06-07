using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        public int Staff_ID { get; set; }
        public string Name { get; set; }
        public int Phone_Number { get; set; }
        public Staff_Types Roles { get; set; }
    }
}
