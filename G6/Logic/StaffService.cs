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
        private StaffDAO staffDAO = new StaffDAO();
        public List<Staff> GetAll()
        {
            return staffDAO.GetAll();
        }
    }
}
