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
     public class kichenBarDAO : Base
    {

        public List<OrderItem> Db_Get_Orders()
        {
            string query = "select m.Menu_Item_ID ,o.[Time], oi.[DateTime], Quantity, Notes, m.[Name] as m, Item_Type_ID,s.[Name]as s " +
                "from Orders as o " +
                "join Order_Items as oi on oi.Order_ID = o.Order_ID " +
                "join Order_States as s on s.State_ID = oi.State_ID " +
                "join Menu_Items as m on m.Menu_Item_ID = oi.Menu_Item_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orders = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem order = new OrderItem()
                {
                    //     Order_Item_Id = (int)dr["Menu_Item_ID"],
                    dateTime = (DateTime)dr["DateTime"],
                    Quantity = (int)dr["Quantity"],
                    Comment = (string)dr["Notes"],
                    Item = (Menu_Item)dr["m"],
                    Item_Types = (Item_Types)dr["Item_Type_ID"],
                    Status = (Order_Status)dr["s"]

                };
                orders.Add(order);
            }
            return orders;
        }



        void Db_Remove_Orders(object order)
        {


        }
    }
}
