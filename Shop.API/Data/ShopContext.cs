using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Entities;

    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
    
    public DbSet<Shop.Entities.Customer> Customer { get; set; }
    
    public DbSet<Shop.Entities.Order> Order { get; set; }
    
    public DbSet<Shop.Entities.Product> Product { get; set; }
    public DbSet<Shop.Entities.OrderPosition> OrderPosition { get; set; }
}
