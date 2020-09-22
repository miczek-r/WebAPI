using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Entities
{
    public class Customer
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public List<Order> Orders { get; } = new List<Order>();
        public void SetFirstName(string _FirstName)
        {
            this.FirstName = _FirstName;
        }
        public void SetLastName(string _LastName)
        {
            this.LastName = _LastName;
        }
        public void SetEmail(string _Email)
        {
            this.Email = _Email;
        }
        public Customer(string FirstName, string LastName, string Email) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }
        public Customer(string FirstName, string LastName, string Email, int Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Id = Id;
        }


    }
}
