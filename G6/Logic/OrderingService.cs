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
        public List<StringValueWrapper> GetMenuItemNames(string TypeName)
        {
            List<StringValueWrapper> Names = new List<StringValueWrapper>();
            List<Menu_Item> Menu = new List<Menu_Item>();
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

        public Tuple<bool,string> SendOrder(Order Order, List<Menu_Item> Items, bool Close = false)
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
