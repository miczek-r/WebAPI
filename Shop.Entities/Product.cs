using System;

namespace Shop.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public int StashQuantity { get; set; }

        
    }


    
}
