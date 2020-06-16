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
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone_Number { get; set; }
        public Staff_Type Role { get; set; }
    }
}
