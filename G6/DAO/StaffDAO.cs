using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class StaffDAO
    {
        private SqlConnection dbConnection;
        public StaffDAO()
        {
            string connString = ConfigurationManager
                                    .ConnectionStrings["DBConnectionString"]
                                    .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }
        public List<Staff> GetAll()
        {
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", dbConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Staff> staff = new List<Staff>();
            while (reader.Read())
            {
                Staff members = ReadStaff(reader);
                staff.Add(members);
            }
            return staff;
        }
        private Staff ReadStaff(SqlDataReader reader)
        {
            // retrieve data from all fields
            int staffID = (int)reader["Satff_ID"];
            string name = (string)reader["Name"];
            int phoneNumber = (int)reader["phone_Number"];

            // return to Staff object
            return new Staff(staffID, name, phoneNumber);
        }
    }
}
