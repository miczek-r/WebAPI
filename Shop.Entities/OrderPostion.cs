﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entities
{
    public class OrderPostion
    {
        public int Id { get;private set; }
        public int ProductId { get;private set; }
        public int OrderId { get;private set; }
        public int Quantity { get;private set; }

    }
}
