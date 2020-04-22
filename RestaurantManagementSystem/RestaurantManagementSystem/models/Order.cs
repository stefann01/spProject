using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models
{
    class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Dictionary<FoodItem, int> FoodItems { get; set; }
        public Dictionary<DrinkItem, int> DrinkItems { get; set; }
        public double TotalSum { get; set; }
        public string Status { get; set; }

        public Order(int id, Customer customer)
        {
            Id = id;
            Customer = customer;
            FoodItems = new Dictionary<FoodItem, int>();
            DrinkItems = new Dictionary<DrinkItem, int>();
            TotalSum = Constants.DefaultTotalSumValue;
            Status = Constants.DefaultStatus;
        }

        public override string ToString()
        {
            return $"Customer: {Customer.ToString()}    |   Total: {TotalSum}";
        }
    }
}
