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
        public List<Menu_Items> Db_Get_Item_Names()
        {
            string query = "SELECT Name from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Menu_Items> Db_Get_MenuItems(string TypeName)
        {
            string query = "SELECT * from [Menu_Items] WHERE Item_Type_ID in (Select Item_Type_ID FROM Item_Types where Name like @nome)";
            //string query = "SELECT * from [Menu_Items]";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@nome", TypeName);
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu_Items> ReadItems(DataTable dataTable)
        {
            List<Menu_Items> Items = new List<Menu_Items>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Items elem = new Menu_Items()
                {
                    Menu_Item_ID = Convert.ToInt32(dr["Menu_Item_ID"]),
                    Name = dr["Name"].ToString(),
                    Types = (Item_Types)Convert.ToInt32(dr["Item_Type_ID"]),
                    Descriptions = dr["Description"].ToString()
                };
                Items.Add(elem);
            }
            return Items;
        }

        public void Db_Send_Order(Orders Order, List<Menu_Items> Items, bool Close = false)
        {
            throw new NotImplementedException("if close then close order, otherwise send the order to order items");
        }
    }
}
