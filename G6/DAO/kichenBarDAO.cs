﻿using Model;
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
            string query = "select m.Menu_Item_ID ,o.[Time], oi.[DateTime], Quantity, Notes, m.[Name] as m, Item_Type_ID,s.[Name]as s" +
                "from Orders as o" +
                "join Order_Items as oi on oi.Order_ID = o.Order_ID" +
                "join Order_States as s on s.State_ID = oi.State_ID" +
                "join Menu_Items as m on m.Menu_Item_ID = oi.Menu_Item_ID";
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
                    //     Order_Item_Id = (int)dr["Menu_Item_ID"],
                    dateTime = (DateTime)dr["DateTime"],
                    Quantity = (int)dr["Quantity"],
                    Comment = (string)dr["Notes"],
                    ItemName = (string)dr["m"],
                    ItemType = (int)dr["Item_Type_ID"],
                    state = (string)dr["s"]

                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
