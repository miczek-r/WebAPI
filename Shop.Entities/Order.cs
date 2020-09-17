using System;
using System.Collections.Generic;
using System.Text;


namespace Shop.Entities
{
    public class Order
    {
        public int Id { get; private set; }
        public string Date { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer;
        public List<OrderPosition> OrderPositions { get; } = new List<OrderPosition>();
        public void SetCustomerId(int _Id)
        {
            this.CustomerId = _Id;
        }
        public Order(string Date, int CustomerId)
        {
            this.Date = Date;
            this.CustomerId = CustomerId;
        }
    }
}
