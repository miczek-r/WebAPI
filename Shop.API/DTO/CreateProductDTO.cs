using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.DTO
{
    public class CreateProductDTO
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public float Price { get; set; }
        public int StashQuantity { get; set; }

    }
}
