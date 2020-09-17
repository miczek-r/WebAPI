using System;
using System.Collections.Generic;
using System.Text;


namespace Shop.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }

    }
}
