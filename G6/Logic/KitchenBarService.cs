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
            //try
            //{
                List<Order> orders = kitchenBar_db.Db_Get_Orders();
                return orders;

            //}
            //catch
            //{
            //    return null;
            //}

        }

        public void StateOrderItem(int itemId,int state)
        {

            kitchenBar_db.Db_State_Order_Items(itemId,state);

        }
        
        public int CountOrderItems()
        {

            return kitchenBar_db.Db_Count_Orders();

        }


    }
}
