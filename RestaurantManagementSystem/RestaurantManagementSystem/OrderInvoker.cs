using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    class OrderInvoker 
    {
        private ICommand command;

        public OrderInvoker(Customer customer)
        {
            this.command = new OrderCommand(customer);
        }

        public void DoOrder(DrinkItem drink, int amount = 1)
        {
            this.command.DrinkItem = drink;
            command.Execute(amount);

        }

        public void DoOrder(FoodItem food, int amount = 1)
        {
            this.command.FoodItem = food;
            command.Execute(amount);

        }
    }
}
