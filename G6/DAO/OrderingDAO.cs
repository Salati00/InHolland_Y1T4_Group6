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
                    Descriptions = dr["Description"].ToString()
                };
                Items.Add(elem);
            }
            return Items;
        }

        public void Db_Send_Order(Order Order, List<Menu_Item> Items, bool Close = false)
        {
            if (Close)
            {

            }
            else
            {

            }
            throw new NotImplementedException("if close then close order, otherwise send the order to order items");
        }

        public List<OrderItem> Db_Get_All_Order_Items()
        {
            string query = "SELECT * FROM [Order_Items], [Orders] WHERE Order_Items.Order_ID = Orders.Order_ID AND Order_ID = @order_id";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderItemTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadOrderItemTable(DataTable dataTable)
        {
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem item = new OrderItem()
                {
                    ItemID = Convert.ToInt32(dr["Order_Item_ID"]),
                    MenuItem = (Menu_Item)dr["Menu_Item_ID"],
                    OrderID = (Order)dr["Order_ID"],
                    Status = (Order_Status)dr["State_ID"],
                    DateTime = (DateTime)dr["DateTime"],
                    Quantity = Convert.ToInt32(dr["Quantity"]),
                    Comment = dr["Notes"].ToString()
                };
                items.Add(item);
            }
            return items;
        }
    }
}
