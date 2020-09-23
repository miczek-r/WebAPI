using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.API.DTO
{
    public class CreateOrderDTO
    {
        public string Date { get; set; }
        public int CustomerId { get; set; }

    }
}
