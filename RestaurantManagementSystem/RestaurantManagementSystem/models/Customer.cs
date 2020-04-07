using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Budget { get; set; }

        public Customer(int id, string firstName, string lastName, double budget)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Budget = budget;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}    |   Last name: {LastName}   |   Budget: {Budget}";
        }
    }
}
