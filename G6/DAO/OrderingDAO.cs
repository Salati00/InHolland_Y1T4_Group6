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

        public List<Order> Db_Get_All_Orders()
        {
            string query = "SELECT * FROM [Orders]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrderTable(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadOrderTable(DataTable dt)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dt.Rows)
            {
                Order order = new Order()
                {
                    Order_ID = (int)dr["Order_ID"],
                    Staff_ID = (int)dr["Staff_ID"],
                    Table_ID = (int)dr["Table_ID"],
                    Time = (DateTime)dr["Time"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
