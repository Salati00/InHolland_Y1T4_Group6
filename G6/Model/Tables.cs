﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Tables
    {
        public int Table_ID { get; set; }
        public int Table_Number { get; set; }
        public int Capacity { get; set; }
        public Tables_Status Status { get; set; }
    }
}
