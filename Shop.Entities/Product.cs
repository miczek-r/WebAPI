using System;

namespace Shop.Entities
{
    public class Product
    {
        public int Id { get;private set; }
        public string Manufacturer { get;private set; }
        public string Model { get;private set; }
        public float Price { get;private set; }
        public int StashQuantity { get;private set; }

        public Product() { }
        public Product(string Manufacturer,string Model,float Price, int StashQuantity)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Price = Price;
            this.StashQuantity = StashQuantity;
        }
        public Product(string Manufacturer, string Model, float Price, int StashQuantity,int Id)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.Price = Price;
            this.StashQuantity = StashQuantity;
            this.Id = Id;
        }
        public void setStashQuantity(int Quantity)
        {
            this.StashQuantity = Quantity;
        }
        public void increaseStashQuantity(int Quantity)
        {
            this.StashQuantity += Quantity;
        }
        public void reduceStashQuantity(int Quantity)
        {
            this.StashQuantity -= Quantity;
        }
      
    }


    
}
