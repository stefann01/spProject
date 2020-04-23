using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.models;
using RestaurantManagementSystem.models.persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    class OrderCommand : IOrderCommand
    {
        private Order order;
        public OrderCommand(Customer customer)
        {
            order = new Order(customer);
        }

        public IMenuItem menuItem { get; set; }

        public void Execute(int amount)
        {
            order.DoOrder(this.menuItem, amount);
            this.menuItem = null;
        }

        public Order GetOrder()
        {
            return this.order;
        }

        public void DeleteOrder()
        {
            this.order.MenuItems.Clear();
        }
    }
}
