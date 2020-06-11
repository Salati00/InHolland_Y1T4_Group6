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
    }
}
