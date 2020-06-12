using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class KitchenBarService
    {

      
        kichenBarDAO kitchenBar_db;

        public KitchenBarService()
        {
            kitchenBar_db = new kichenBarDAO();
      
        }
        public List<Order> GetOrders()
        {
            try
            {
                List<Order> orders = kitchenBar_db.Db_Get_Orders();
                return orders;

            }
            catch
            {
                throw new Exception("No Database conection");
            }

        }

        public void StateOrderItem(int itemId,int state)
        {
            try
            {
                kitchenBar_db.Db_State_Order_Items(itemId, state);
            }
            catch
            {
                throw new Exception("No Database conection");
            }
        }
        
        public int CountOrderItems()
        {
            try
            {
                return kitchenBar_db.Db_Count_Orders();
            }
            catch
            {
                throw new Exception("No Database conection");
            }
        }


    }
}
