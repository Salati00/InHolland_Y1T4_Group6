using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAO
{
    class kichenBarDAO : Base
    {

        public List<Order> Db_Get_Orders()
        {
            string query = "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    Order_Item_Id = (int)dr[""],
                    Time = (DateTime)dr[""],
                    Quantity = (int)dr[""],
                    Comment = (string)dr[""],
                    ItemName = (string)dr[""],
                    ItemType = (string)dr[""],
                    state = (string)dr[""]

                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
