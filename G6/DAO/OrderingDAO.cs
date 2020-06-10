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

        private List<Menu_Item> ReadItems(DataTable dataTable)
        {
            List<Menu_Item> Items = new List<Menu_Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Menu_Item elem = new Menu_Item()
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

        public Table Db_Get_TableFromInt(int number)
        {
            string query = "select * from tables "+
                           "where Number = @Number";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Number", number);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Table> Db_Get_AllTables()
        {
            string query = "select * from tables";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> Items = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table elem = new Table()
                {
                    Table_ID = Convert.ToInt32(dr["Table_ID"]),
                    Table_Number = Convert.ToInt32(dr["Number"]),
                    Capacity = Convert.ToInt32(dr["Capacity"]),
                    Status = (Table_Status)Convert.ToInt32(dr["Status"])
                };
                Items.Add(elem);
            }
            return Items;
        }
    }
}
