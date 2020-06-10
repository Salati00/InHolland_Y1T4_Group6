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

        public List<Order> Db_Get_Orders()              //done
        {
            string query = "select Order_ID, [Time]" +
                "from Orders";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadOrderTables(DataTable dataTable)            //done
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();

                order.Order_ID = (int)dr["Order_ID"];
                order.Time = (TimeSpan)dr["Time"];
                order.ordersItems = Db_Get_OrderItems(order.Order_ID);
                
                orders.Add(order);
            }
            return orders;
        }
        public List<OrderItem> Db_Get_OrderItems(int orderID)    ///done
        {
            string query = "select o.Order_ID , State_ID , Quantity ,Notes, o.[Time] , mi.[Name], Cart_ID ,oi.Order_Item_ID ,mi.Item_Type_ID " +
                "from Orders as o" +
                "join Order_Items  as oi on oi.Order_ID = o.Order_ID" +
                "join Menu_Items as mi on oi.Menu_Item_ID = mi.Menu_Item_ID" +
                "join Item_Types as it on it.Item_Type_ID = mi.Item_Type_ID" +
                "where o.Order_ID = @orderNum" ;

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@orderNum", orderID);
            return ReadOrderItemsTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItemsTables(DataTable dataTable)              //done
        {
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem();

                item.Quantity = (int)dr["Quantity"];
                item.menuItem.Name = (string)dr["Name"];
                item.Item_Types = (Item_Types)dr["Item_Type_ID"] - 1;
                item.order.Order_ID = (int)dr["Order_ID"];
                item.Status = (Order_Status)dr["State_ID"] - 1;
                item.Comment = (string)dr["Notes"];

                items.Add(item);
            }
            return items;
        }






        void Db_Ready_Orders(object order)
        {


        }
    }
}
