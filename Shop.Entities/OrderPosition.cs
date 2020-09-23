using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entities
{
    public class OrderPosition
    {
        public int Id { get;private set; }
        public int OrderId { get;private set; }
        public int ProductId { get;private set; }
        public int Quantity { get;private set; }
        public Product Product { get;private set; }

        public OrderPosition(int OrderId,int ProductId,int Quantity)
        {
            this.OrderId = OrderId;
            this.ProductId = ProductId;
            this.Quantity = Quantity;
        }
    }
}
