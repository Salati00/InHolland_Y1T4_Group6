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
                List<Staff> staff = staff_db.Db_Get_All_Staff();
                return staff;
            }
            catch (Exception)
            {
                /*
                // lost connection to database
                List<Staff> staff = new List<Staff>();
                Staff mem1 = new Staff();
                mem1.Staff_ID = 111;
                mem1.Password = 111;
                mem1.Name = "MoMo";
                mem1.Phone_Number = "0645677812";
                mem1.Role = Staff_Type.Bartender;
                staff.Add(mem1);

                Staff mem2 = new Staff();
                mem2.Staff_ID = 110;
                mem2.Password = 110;
                mem2.Name = "OmOm";
                mem2.Phone_Number = "0625488756";
                mem2.Role = Staff_Type.Waiter;
                staff.Add(mem2);

                return staff;
                */
                throw new Exception("Error occurs when attempting to connect to database.");
            }
        }
        public void EditStaff(Staff staff)
        {
            try { staff_db.EditStaff(staff); }
            catch
            {
                throw new Exception("database connection failed");
            }
        }
        public void AddStaffInfo(Staff staff)
        {
            try { staff_db.AddStaffInfo(staff); }
            catch { throw new Exception("database connection failed"); }
        }
        public void RemoveStaffInfo(Staff staff)
        {
            try { staff_db.RemoveStaffInfo(staff); }
            catch { throw new Exception("database connection failed"); }
        }
        public Staff DoLogin(int id, int password)
        {
            Staff staff;
            try
            {
                return staff = staff_db.DoLogin(id, password);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
