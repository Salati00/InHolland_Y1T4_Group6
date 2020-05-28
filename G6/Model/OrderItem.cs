﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        //order items
    //    public int Order_Item_Id { get; set; }
        public DateTime dateTime { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }

        //menu items
        public Menu_Item Item { get; set; }
        public Item_Types Item_Types { get; set; }

        //state
        public Order_Status Status { get; set; }


    }
}