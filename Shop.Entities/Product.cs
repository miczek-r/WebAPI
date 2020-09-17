using System;

namespace Shop.Entities
{
    public class Product
    {
        public int id { get; set; }
        public string manufacturer { get; set; }
        public string model { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
    }
}
