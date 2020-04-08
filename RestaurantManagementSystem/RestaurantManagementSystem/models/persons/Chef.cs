using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models.persons
{
    class Chef : Employee
    {
        public Chef(int id, string firstName, string lastName, double salary) :
            base(id, firstName, lastName, salary)
        { }

        public override string ToString()
        {
            return $"Chef   |   FirstName: {FirstName}   |   LastName: {LastName}   |   Salary: {Salary}";
        }
    }
}
