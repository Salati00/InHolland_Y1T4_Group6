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
    public class TableDAO : Base
    {
        public Table Db_Get_TableFromInt(int number)
        {
            string query = "select * from tables " +
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

        /*
         * retired in favor of GetTablesWithState()
         * 
         * 
         * public List<Table> GetTablesWithReadyOrders()
        {
            string query = "select * from tables " +
                "where Table_ID in " +
                "(select Table_ID from Orders where Order_ID in " +
                "(select Order_ID from Order_Items where State_ID = 2))";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Table> GetTablesPending()
        {
            string query = "select * from tables " +
                "where Table_ID in " +
                "(select Table_ID from Orders where Order_ID in " +
                "(select Order_ID from Order_Items where State_ID = 1))";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        */
        public List<Table> GetTablesWithState(Order_Status state)
        {
            string query = "select * from tables " +
                "where Table_ID in " +
                "(select Table_ID from Orders where Order_ID in " +
                "(select Order_ID from Order_Items where State_ID = @state))";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@state", (int)state);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangeTableStatus(Table tab, Table_Status status) //"UPDATE tables SET [Status] = @status WHERE Table_ID = @id"
        {
            string query = "UPDATE tables SET [Status] = @status WHERE Table_ID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@status", (int)status);
            sqlParameters[1] = new SqlParameter("@id", tab.Table_ID);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
