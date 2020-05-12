using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Logic
{
    public class OrderingService
    {
        OrderingDAO DB = new OrderingDAO();

        public List<string> GetMenuItems()
        {
            List<string> Names = new List<string>();
            try
            {
                DB.Db_Get_Item_Names();
                return Names;
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
        }
        public List<string> GetMenuItems(string TypeName)
        {
            List<string> Names = new List<string>();
            try
            {
                DB.Db_Get_Item_Names(TypeName);
                return Names;
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
        }
    }
}
