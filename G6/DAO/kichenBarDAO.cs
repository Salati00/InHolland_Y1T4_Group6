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

        
        Staff_Type staffType;
        public kichenBarDAO(Staff_Type type)
        {
            staffType = type;
        }


        public List<Order> Db_Get_Orders()              //done
        {
            string extraCondition = " m.Item_Type_ID > 6 ";
            if (staffType != Staff_Type.Bartender)
                extraCondition = " m.Item_Type_ID <= 6  ";

            string query = $"select o.Order_ID ,max(Table_ID) as tableID, max([Time]) as [time] " +
                $"               from Orders as o" +
                $"                join Order_Items as oi on oi.Order_ID = o.Order_ID " +
                $"                group by o.Order_ID having  1 in (select State_ID " +
                $"                                                 from Order_Items as oii " +
                $"                                                  join Menu_Items as m on oii.Menu_Item_ID = m.Menu_Item_ID " +
                $"                                                  where o.Order_ID = oii.Order_ID and {extraCondition} ) " +
                $"			    order by max(oi.DateTime) ";

           
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
                order.Time = (DateTime)dr["time"];
                order.Table_ID = (int)dr["tableID"];
                order.OrderItems = Db_Get_OrderItems(order.Order_ID);
                
                orders.Add(order);
            }
            return orders;
        }
        public List<OrderItem> Db_Get_OrderItems(int orderID)    //done
        {
            string query = $"select o.Order_ID, State_ID, Quantity, Notes, o.[Time], mi.[Name], c.Cart_ID, oi.Order_Item_ID, mi.Item_Type_ID " +
                $"                 from Orders as o " +
                $"                 join Order_Items as oi on oi.Order_ID = o.Order_ID " +
                $"                 join Menu_Items as mi on oi.Menu_Item_ID = mi.Menu_Item_ID " +
                $"                 join Item_Types as it on it.Item_Type_ID = mi.Item_Type_ID " +
                $"                 join Carts as c on c.Cart_ID = it.Cart_ID " +
                $"                 where o.Order_ID = @orderNum " +
                $"                 and oi.State_ID = 1  ";
            string extraCondition = " and c.[Name] = 'Drinks' ;";
            if (staffType != Staff_Type.Bartender)
                extraCondition =  " and not c.[Name] = 'Drinks' ;";
            query += extraCondition;

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
                item.MenuItem = new Menu_Item();

                item.ItemID = (int)dr["Order_Item_ID"];
                item.Quantity = (int)dr["Quantity"];
                item.MenuItem.Name = (string)dr["Name"];                    
                item.MenuItem.Type = (Item_Type)dr["Item_Type_ID"];
                item.Status = (Order_Status)dr["State_ID"] - 1;
                try { item.Comment = (string)dr["Notes"]; } catch { }

                items.Add(item);
            }
            return items;
        }


        public void Db_State_Order_Items(int itemid, Order_Status state)
        {

            string query = "SET IDENTITY_INSERT Order_Items on; " +
                "UPDATE Order_Items " +
                "SET State_ID = @state " +
                "WHERE Order_Item_ID = @itemid ; " +
                "SET IDENTITY_INSERT Order_Items off; ";

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@state", (int)state);
            sqlParameters[1] = new SqlParameter("@itemid", itemid);
            ExecuteEditQuery(query, sqlParameters);
        }


        public int Db_Count_Orders()              //done
        {
            string query = "select count(Order_Item_ID) as num " +
                "           from Order_Items as oi " +
                "           join Menu_Items as mi on mi.Menu_Item_ID = oi.Menu_Item_ID " +
                "           where oi.State_ID = 1  ";

            string extraCondition = " and mi.Item_Type_ID >= 7; ";
            if (staffType != Staff_Type.Bartender)
                extraCondition = " and not mi.Item_Type_ID >= 7; ";
            query += extraCondition;



            SqlParameter[] sqlParameters = new SqlParameter[0];


            foreach (DataRow dr in ExecuteSelectQuery(query, sqlParameters).Rows)
            {
                return (int)dr["num"];
            }
            return 0;
            
        }
       



    }
}
