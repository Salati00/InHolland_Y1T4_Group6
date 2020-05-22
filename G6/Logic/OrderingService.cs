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

        public List<Menu_Items> GetMenuItems(string TypeName)
        {
            List<Menu_Items> Menu = new List<Menu_Items>();
            try
            {
                Menu = DB.Db_Get_MenuItems(TypeName);
                return Menu;
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

        public Tuple<bool,string> SendOrder(Orders Order, List<Menu_Items> Items, bool Close = false)
        {
            try
            {
                DB.Db_Send_Order(Order, Items, Close);
                return new Tuple<bool, string>(true, "");
            }
            catch(Exception ex)
            {                
                return new Tuple<bool,string>(false,ex.Message);
            }
        }
    }
}
