using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Staff
    {
        private int id;
        //public int Staff_Type_ID { get; set; }
        //public int Login_Details_ID { get; set; }
        public string Name { get; set; }
        public int Phone_Number { get; set; }
        public int Staff_ID
        {
            get { return id; }
            set { id = value; }
        }
        public Staff(int staffID, string name, int phoneNumber)
        {
            staffID = id;
            Name = name;
            Phone_Number = phoneNumber;
        }
    }
}
