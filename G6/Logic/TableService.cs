using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Logic
{
    public class TableService
    {
        TableDAO DB = new TableDAO();

        public Table GetTableFromInt(int number)
        {
            Table table;
            try
            {
                table = DB.Db_Get_TableFromInt(number);
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
            return table;
        }

        public List<Table> GetAllTables()
        {
            List<Table> tables;
            try
            {
                tables = DB.Db_Get_AllTables();
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
            return tables;
        }

        /*
            Retired in favor of GetTablesWithState()

        public List<Table> GetTablesWithReadyOrders()
        {
            List<Table> tables;
            try
            {
                tables = DB.GetTablesWithState();
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
            return tables;
        }

        public List<Table> GetTablesPending()
        {
            List<Table> tables;
            try
            {
                tables = DB.GetTablesPending();
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
            return tables;
        }
        */

        public List<Table> GetTablesWithState(Order_Status state)
        {
            List<Table> tables;
            try
            {
                tables = DB.GetTablesWithState(state);
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
            return tables;
        }

        public void ChangeTableStatus(Table table, Table_Status status)
        {
            try
            {
                DB.ChangeTableStatus(table, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
