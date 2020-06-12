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

        public List<Menu_Item> GetMenuItems(string TypeName)
        {
            List<Menu_Item> Menu = new List<Menu_Item>();
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

        public List<Menu_Item> GetMenuItems()
        {
            List<Menu_Item> Menu = new List<Menu_Item>();
            try
            {
                Menu = DB.Db_Get_MenuItems();
                return Menu;
            }
            catch (Exception ex)
            {
                // lost connection to database
                throw new Exception(ex.Message);
            }
        }

        public Tuple<bool,string> SendOrder(Order Order, bool Close)
        {
            try
            {
                DB.Db_Send_Order(Order, Close);
                return new Tuple<bool, string>(true, "");
            }
            catch(Exception ex)
            {                
                return new Tuple<bool,string>(false,ex.Message);
            }
        }

        public Order GetOrderFromTable(Table tab)
        {
            Order r;
            try
            {
                r = DB.Db_Get_OrderForTable(tab);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return r;
        }

        public void MarkItemsServed(Table tab)
        {
            try
            {
                DB.MarkItemsServed(tab);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
