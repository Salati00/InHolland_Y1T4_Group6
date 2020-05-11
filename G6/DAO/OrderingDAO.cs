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

        public List<string> Db_Get_Item_Names()
        {
            string query = "SELECT Name from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadNames(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<string> Db_Get_Item_Names(string TypeName)
        {
            string query = "SELECT Name from [Menu_Items] WHERE Item_Type_ID in (Select Item_Type_ID FROM Item_Types where Name like @nome)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("nome", TypeName);
            return ReadNames(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<string> ReadNames(DataTable dataTable)
        {
            List<string> Orders = new List<string>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Orders.Add(dr["Name"].ToString());
            }
            return Orders;
        }


    }
}
