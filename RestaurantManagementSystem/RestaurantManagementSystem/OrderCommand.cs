using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    class OrderCommand : ICommand
    {
        private Order order;
        public OrderCommand(Customer customer)
        {
            order = new Order(customer);
        }

        public FoodItem FoodItem { get; set; }
        public DrinkItem DrinkItem { get; set; }

        public void Execute(int amount)
        {
            order.DoOrder(this.DrinkItem, this.FoodItem, amount);
            this.FoodItem = null;
            this.DrinkItem = null;
        }
    }
}
