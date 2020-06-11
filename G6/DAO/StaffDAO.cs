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
            string query = "SELECT * FROM [Staff]";
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
                    Phone_Number = (int)dr["Phone_Number"],
                    Role = (Staff_Types)dr["Staff_Type_ID"],
                    Password = (string)dr["Password"]
                };
                staff.Add(member);
            }
            return staff;
        }
        public Staff GetLoginDetails(int id, string password) // get login account
        {
            SqlCommand cmd = new SqlCommand("SELECT Staff_ID, Staff_Type_ID, Password FROM Staff WHERE Staff_ID = @staff_id AND [Password] = @password", conn);
            cmd.Parameters.AddWithValue("@staff_id", id);
            cmd.Parameters.AddWithValue("@password", password);
            conn.Open();
            //DataTable db = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //sda.Fill(db);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Staff staff = new Staff
            {
                Staff_ID = (int)reader["Staff_ID"],
                Role = (Staff_Types)reader["Staff_Type_ID"],
                Name = (string)reader["Name"],
                Phone_Number = (int)reader["Phone_Number"],
                Password = (string)reader["Password"]
            };
            reader.Close();
            conn.Close();

            return staff;
        }
        // edit the staff information
        public void EditStaff(Staff staff)
        {
            string query = "UPDATE Staff SET Name = @name, Phone_Number = @phone, " +
                "Staff_Type_ID = @role, [Password] = @password WHERE Staff_ID = @staff_id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@name", staff.Name);
            sqlParameters[1] = new SqlParameter("@phone", staff.Phone_Number);
            sqlParameters[2] = new SqlParameter("@role", staff.Role);
            sqlParameters[3] = new SqlParameter("@password", staff.Password);
            sqlParameters[4] = new SqlParameter("@staff_id", staff.Staff_ID);

            ExecuteEditQuery(query, sqlParameters);

        }

        public void AddStaffInfo(Staff staff) // add staff information
        {
            string query = "INSERT INTO Staff(Staff_ID, Staff_Type_ID, Name, Phone_Number, [Password])" +
                $"VALUES (@staff_id, @role, @name, @phone, @password)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@staff_id", staff.Staff_ID);
            sqlParameters[1] = new SqlParameter("@role", staff.Role);
            sqlParameters[2] = new SqlParameter("@name", staff.Name);
            sqlParameters[3] = new SqlParameter("@phone", staff.Phone_Number);
            sqlParameters[4] = new SqlParameter("@password", staff.Password);

            ExecuteEditQuery(query, sqlParameters);
        }
        public void RemoveStaffInfo(Staff staff) // remove staff information
        {
            string query = "DELET FROM Staff WHERE Staff_ID = @staff_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@staff_id", staff.Staff_ID);
            ExecuteEditQuery(query, sqlParameters);
        }
        
    }
}
