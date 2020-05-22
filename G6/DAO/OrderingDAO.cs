using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class OrderingDAO : Base
    {
        public OrderingDAO() : base()
        {

        }

        public List<Menu_Items> Db_Get_Item_Names()
        {
            string query = "SELECT Name from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Menu_Items> Db_Get_MenuItems(string TypeName)
        {
            string query = "SELECT * from [Menu_Items] WHERE Item_Type_ID in (Select Item_Type_ID FROM Item_Types where Name like @nome)";
            //string query = "SELECT * from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@nome", TypeName);
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Items> ReadItems(DataTable dataTable)
        {
            List<Menu_Items> Items = new List<Menu_Items>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Items elem = new Menu_Items()
                {
                    Staff_ID = (int)dr["Staff_ID"],
                    Name = (string)dr["Name"],
                    Phone_Number = (int)dr["Phone_Number"]
                };
                Items.Add(elem);
            }
            return Orders;
        }


    }
}
