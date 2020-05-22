using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

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
        public List<StringValueWrapper> GetMenuItemNames(string TypeName)
        {
            List<StringValueWrapper> Names = new List<StringValueWrapper>();
            List<Menu_Items> Menu = new List<Menu_Items>();
            try
            {
                Menu = DB.Db_Get_MenuItems(TypeName);
                foreach (var item in Menu)
                {
                    Names.Add(new StringValueWrapper(item.Name));
                }
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
