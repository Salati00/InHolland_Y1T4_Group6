using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class OrderingDAO : Base
    {
        public List<Menu_Item> Db_Get_Item_Names()
        {
            string query = "SELECT Name from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menu_Item> Db_Get_MenuItems(string TypeName)
        {
            string query = "SELECT * from [Menu_Items] WHERE Item_Type_ID in (Select Item_Type_ID FROM Item_Types where Name like @nome)";
            //string query = "SELECT * from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@nome", TypeName);
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Menu_Item> Db_Get_MenuItems()
        {
            string query = "SELECT * from [Menu_Items]";
            //string query = "SELECT * from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Item> ReadItems(DataTable dataTable)
        {
            List<Menu_Item> Items = new List<Menu_Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Item elem = new Menu_Item()
                {
                    Menu_Item_ID = Convert.ToInt32(dr["Menu_Item_ID"]),
                    Name = dr["Name"].ToString(),
                    Type = (Item_Type)Convert.ToInt32(dr["Item_Type_ID"]),
                    Descriptions = dr["Description"].ToString(),
                    Stock = Convert.ToInt32(dr["Stock"])
                };
                Items.Add(elem);
            }
            return Items;
        }

        public void MarkItemsServed(Table tab)
        {
            string query = "update Order_Items set State_ID = 3 OUTPUT inserted.* where Order_ID in (select Order_ID from Orders where Table_ID = @tId) and State_ID = 2";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tId", tab.Table_ID);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Db_Send_Order(Order Order, bool Close = false)
        {
            string query;
            SqlParameter[] sqlParameters;
            if (Close)
            {
                query = "update Orders set Closed = 1 where Orders.Table_ID = @TableID";
                sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@TableID", Order.Table_ID);
                ExecuteEditQuery(query, sqlParameters);
            }
            else
            {
                query = "select * from orders where Table_ID = @tabId and Closed <> 1";
                sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@tabId", Order.Table_ID);
                DataTable OrderExists = ExecuteSelectQuery(query, sqlParameters);
                if (OrderExists.Rows.Count != 0)
                {
                    Order.Order_ID = Convert.ToInt32(OrderExists.Rows[0]["Order_ID"]);
                    query = "select Order_ID from orders where Table_ID = @tabId and Closed <> 1";
                    sqlParameters = new SqlParameter[1];
                    sqlParameters[0] = new SqlParameter("@tabId", Order.Table_ID);
                    Order.Order_ID = Convert.ToInt32(ExecuteScalarQuery(query, sqlParameters));

                    InsertOrdersFromOrderID(Order.Order_ID, Order.OrderItems);
                }
                else
                {
                    query = "insert into Orders(Staff_ID,Table_ID,Time,Closed) " +
                        "values(@sId,@tId,@tIm,0)";
                    sqlParameters = new SqlParameter[3];
                    sqlParameters[0] = new SqlParameter("@sId", Order.Staff_ID);
                    sqlParameters[1] = new SqlParameter("@tId", Order.Table_ID);
                    sqlParameters[2] = new SqlParameter("@tIm", DateTime.UtcNow);
                    ExecuteEditQuery(query, sqlParameters);

                    query = "select Order_ID from orders where Table_ID = @tabId and Closed <> 1";
                    sqlParameters = new SqlParameter[1];
                    sqlParameters[0] = new SqlParameter("@tabId", Order.Table_ID);
                    Order.Order_ID = Convert.ToInt32(ExecuteScalarQuery(query, sqlParameters));

                    InsertOrdersFromOrderID(Order.Order_ID, Order.OrderItems);
                }
            }

            query = "update Tables set status = @status WHERE Table_ID = @tId";
            sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tId", Order.Table_ID);
            sqlParameters[1] = new SqlParameter("@status", Close?0:2);
            ExecuteEditQuery(query, sqlParameters);
        }

        private void InsertOrdersFromOrderID(int OrderID, List<OrderItem> Items)
        {
            foreach (var item in Items)
            {
                string query = "insert into Order_Items(Menu_Item_ID,Order_ID,State_ID,DateTime,Quantity,Notes) " +
                "values(@mId,@oId,@sId,@tIm,@qNt,@nTs)";
                SqlParameter[] sqlParameters = new SqlParameter[6];
                sqlParameters[0] = new SqlParameter("@mId", item.MenuItem.Menu_Item_ID);
                sqlParameters[1] = new SqlParameter("@oId", OrderID);
                sqlParameters[2] = new SqlParameter("@sId", Convert.ToInt32(Order_Status.Pending));
                sqlParameters[3] = new SqlParameter("@tIm", DateTime.UtcNow);
                sqlParameters[4] = new SqlParameter("@qNt", item.Quantity);
                sqlParameters[5] = new SqlParameter("@nTs", item.Comment == null? "": item.Comment.ToString());
                ExecuteEditQuery(query, sqlParameters);

                query = "Update Menu_Items set stock = stock - 1 " +
                "WHERE Menu_Item_ID = @mId";
                sqlParameters = new SqlParameter[1];
                sqlParameters[0] = new SqlParameter("@mId", item.MenuItem.Menu_Item_ID);
                ExecuteEditQuery(query, sqlParameters);
            }
        }

        public Order Db_Get_OrderForTable(Table tab)
        {
            string query = "SELECT * FROM [Order_Items], [Orders], [Menu_Items] " +
                "WHERE Order_Items.Order_ID = Orders.Order_ID " +
                "AND Menu_Items.Menu_Item_ID = Order_Items.Menu_Item_ID AND Table_ID = @tabId AND Closed <> 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tabId", tab.Table_Number);
            return ReadOrderTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private Order ReadOrderTable(DataTable dataTable)
        {
            Order r;
            if (dataTable.Rows.Count > 0)
            {
                r = new Order
                {
                    Order_ID = Convert.ToInt32(dataTable.Rows[0]["Order_ID"]),
                    Staff_ID = Convert.ToInt32(dataTable.Rows[0]["Staff_ID"]),
                    Table_ID = Convert.ToInt32(dataTable.Rows[0]["Table_ID"]),
                    Time = Convert.ToDateTime(dataTable.Rows[0]["Time"]),
                    OrderItems = new List<OrderItem>()
                };

                foreach (DataRow dr in dataTable.Rows)
                {
                    r.OrderItems.Add(new OrderItem()
                    {
                        ItemID = Convert.ToInt32(dr["Order_Item_ID"]),
                        MenuItem = new Menu_Item()
                        {
                            Menu_Item_ID = Convert.ToInt32(dr["Menu_Item_ID"]),
                            Descriptions = dr["Description"].ToString(),
                            Name = dr["Name"].ToString(),
                            Type = (Item_Type)Convert.ToInt32(dr["Item_Type_ID"])
                        },
                        OrderID = Convert.ToInt32(dr["Order_ID"]),
                        Status = (Order_Status)dr["State_ID"],
                        DateTime = (dr["DateTime"] is DBNull) ? DateTime.UtcNow : Convert.ToDateTime(dr["DateTime"]),
                        Quantity = Convert.ToInt32(dr["Quantity"]),
                        Comment = dr["Notes"].ToString()
                    });
                }
            }
            else
            {
                r = new Order();
            }
            return r;
        }
    }
}
