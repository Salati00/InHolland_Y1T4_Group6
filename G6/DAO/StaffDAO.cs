using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAO
{
    public class StaffDAO : Base
    {
        public List<Staff> Db_Get_All_Staff()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Staff> ReadTables(DataTable dataTable)
        {
            List<Staff> staff = new List<Staff>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Staff member = new Staff()
                {
                    Staff_ID = (int)dr["Staff_ID"],
                    Name = (string)dr["Name"],
                    Phone_Number = (int)dr["Phone_Number"]
                };
                staff.Add(member);
            }
            return staff;
        }
    }
}
