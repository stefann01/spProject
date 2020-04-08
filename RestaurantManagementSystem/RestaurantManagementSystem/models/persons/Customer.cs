using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models.persons
{
    class Customer : Person
    {
        public double Budget { get; set; }

        public Customer(int id, string firstName, string lastName, double budget) :
            base(id, firstName, lastName)
        {
            Budget = budget;
        }

        public override string ToString()
        {
            return $"Customer   |   First name: {FirstName}   |   Last name: {LastName}   |   Budget: {Budget}";
        }
    }
}
