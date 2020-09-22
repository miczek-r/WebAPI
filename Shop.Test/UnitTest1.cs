/*using Shop.Models;
using System;
using Xunit;
using Shop.Entities;
using System.Linq;

namespace Shop.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var db = new ShopContext())
            {
                // Create

                Console.WriteLine("Inserting anew customer");
                db.Add(new Customer(
                    "Jan",
                    "Kowalski",
                    "kowalski.j@gmail.com"));
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a blog");
                var customer = db.Customers
                    .OrderBy(b => b.Id)
                    .First();

                // Update
                Console.WriteLine("Updating customer and adding an order");
                customer.ChangeFirstName("Adrian");
                customer.Orders.Add(
                    new Order(
                        "12-12-2012",
                        customer.Id
                        )
                    ); ; ;
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete customer");
                db.Remove(customer);
                db.SaveChanges();
            }
        }
    }
}
*/