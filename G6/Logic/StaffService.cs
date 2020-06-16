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
                throw new Exception("Error occurs when attempting to connect to database.");
            }
        }
        //public void EditStaff(Staff staff)
        //{
        //    try { staff_db.EditStaff(staff); }
        //    catch
        //    {
        //        throw new Exception("database connection failed");
        //    }
        //}
        //public void AddStaffInfo(Staff staff)
        //{
        //    try { staff_db.AddStaffInfo(staff); }
        //    catch { throw new Exception("database connection failed"); }
        //}
        //public void RemoveStaffInfo(Staff staff)
        //{
        //    try { staff_db.RemoveStaffInfo(staff); }
        //    catch { throw new Exception("database connection failed"); }
        //}
        public Staff DoLogin(int id, string password)
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
