using RestaurantManagementSystem.interfaces;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    class Observer : IObserver
    {
        public Customer Customer { get; set; }

        public Observer(Customer customer)
        {
            Customer = customer;
        }

        public void Update()
        {
            Console.WriteLine($"Hello {Customer.FirstName}, your order status is completed!");
        }
    }
}
