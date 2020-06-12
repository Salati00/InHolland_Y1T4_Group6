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

        public void Db_Send_Order(Order Order, bool Close = false)
        {
            if (Close)
            {
                string query = "SELECT * from [Menu_Items] WHERE Item_Type_ID in (Select Item_Type_ID FROM Item_Types where Name like @nome)";
                //string query = "SELECT * from [Menu_Items]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
            }
            else
            {

            }
            throw new NotImplementedException("if close then close order, otherwise send the order to order items");
        }

        public Order Db_Get_OrderForTable(Table tab)
        {
            string query = "SELECT * FROM [Order_Items], [Orders], [Menu_Items] " +
                "WHERE Order_Items.Order_ID = Orders.Order_ID " +
                "AND Menu_Items.Menu_Item_ID = Order_Items.Menu_Item_ID AND Table_ID = @tabId AND Closed <> 1";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@tabId", tab.Table_ID);
            return ReadOrderTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private Order ReadOrderTable(DataTable dataTable)
        {
            Order r = new Order
            {
                Order_ID = Convert.ToInt32(dataTable.Rows[0]["Order_ID"]),
                Staff_ID = Convert.ToInt32(dataTable.Rows[0]["Staff_ID"]),
                Table_ID = Convert.ToInt32(dataTable.Rows[0]["Table_ID"]),
                Time = Convert.ToDateTime(dataTable.Rows[0]["Time"]),
                OrderItems = new List<OrderItem>()
            };

            foreach (DataRow dr in dataTable.Rows)
            {
                /*r.OrderItems.Add(new OrderItem()
                {
                    ItemID = Convert.ToInt32(dr["Order_Item_ID"]),
                    MenuItem = new Menu_Item() {
                        Menu_Item_ID = Convert.ToInt32(dr["Menu_Item_ID"]),
                        Descriptions = dr["Description"].ToString(),
                        Name = dr["Name"].ToString(),
                        Type = (Item_Type)Convert.ToInt32(dr["Item_Type_ID"])
                    },
                    OrderID = Convert.ToInt32(dr["Order_ID"]),
                    Status = (Order_Status)dr["State_ID"],
                    DateTime = (DateTime)dr["DateTime"],
                    Quantity = Convert.ToInt32(dr["Quantity"]),
                    Comment = dr["Notes"].ToString()
                });*/
            }
            return r;
        }
    }
}
