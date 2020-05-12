using DAO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class KitchenBarService
    {


        kichenBarDAO kitchenBar_db = new kichenBarDAO();

        public List<Order> GetOrders()
        {
            try
            {
                List<Order> orders = kitchenBar_db.Db_Get_Orders();
                return orders;

            }
            catch
            {
                return null;
            }

        }
    }
}
