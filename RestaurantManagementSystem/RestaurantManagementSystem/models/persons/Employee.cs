using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models.persons
{
    class Employee : Person
    {
        public double Salary { get; set; }
        public Employee(int id, string firstName, string lastName, double salary) :
            base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Employee   |   FirstName: {FirstName}   |   LastName: {LastName}   |   Salary: {Salary}";
        }
    }
}
