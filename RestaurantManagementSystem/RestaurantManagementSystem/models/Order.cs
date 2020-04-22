using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
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
        static int globalId = 0;
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Dictionary<IMenuItem, int> MenuItems { get; set; }
        public double TotalSum { get; set; }
        public string Status { get; set; }

        public Order(Customer customer)
        {
            Order.globalId++;
            this.Id = globalId;
            Customer = customer;
            MenuItems = new Dictionary<IMenuItem, int>();
            TotalSum = Constants.DefaultTotalSumValue;
            Status = Constants.DefaultStatus;
        }

        public void DoOrder(DrinkItem drinkItem, FoodItem foodItem, int amount)
        {
            if (drinkItem != null)
            {
                var value = -1;
                var found = DrinkItems.TryGetValue(drinkItem, out value);
                if (found)
                {
                    DrinkItems[drinkItem] += amount;
                }
                else
                {
                    DrinkItems.Add(drinkItem, amount);
                }
                if (DrinkItems.ContainsKey(drinkItem))
                {
                    Console.WriteLine();
                }
            }

            if(foodItem != null)
            {
                var value = -1;
                var found = FoodItems.TryGetValue(foodItem, out value);
                if (found)
                {
                    FoodItems[foodItem] += amount;
                }
                else
                {
                    FoodItems.Add(foodItem, amount);
                }
            }
        }

        public override string ToString()
        {
            return $"Customer: {Customer.ToString()}    |   Total: {TotalSum}";
        }
    }
}
