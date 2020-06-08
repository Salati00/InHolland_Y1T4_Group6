using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Logic
{
    public class StaffService
    {
        StaffDAO staff_db = new StaffDAO();

        public List<Staff> GetStaffMembers()
        {
            try
            {
                List<Staff> staff = staff_db.Db_Get_Staff_ID();
                return staff;
            }
            catch (Exception)
            {
                // lost connection to database
                List<Staff> staff = new List<Staff>();
                Staff mem1 = new Staff();
                mem1.Staff_ID = 111;
                mem1.Name = "MoMo";
                mem1.Phone_Number = 0645677812;
                mem1.Roles = Staff_Types.Bartender;
                staff.Add(mem1);

                Staff mem2 = new Staff();
                mem2.Staff_ID = 110;
                mem2.Name = "OmOm";
                mem2.Phone_Number = 0625488756;
                mem2.Roles = Staff_Types.Waiter;
                staff.Add(mem2);

                return staff;
                throw new Exception("Error occurs when attempting to connect to database.");
            }
        }
    }
}
