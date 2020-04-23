using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    class OrderInvoker
    {
        private IOrderCommand command;

        public OrderInvoker(Customer customer)
        {
            this.command = new OrderCommand(customer);
        }

        public void DoOrder(IMenuItem menuItem, int amount = 1)
        {
            this.command.menuItem = menuItem;
            command.Execute(amount);
        }


        public Dictionary<IMenuItem, int> GetOrder()
        {
            return command.GetOrder();
        }
    }
}
