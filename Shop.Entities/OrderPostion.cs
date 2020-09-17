using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entities
{
    public class OrderPostion
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

    }
}
