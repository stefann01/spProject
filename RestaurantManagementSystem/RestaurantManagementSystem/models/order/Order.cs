﻿using RestaurantManagementSystem.helpers;
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

        public void DoOrder(IMenuItem menuItem, int amount)
        {
            if (this.MenuItems.ContainsKey(menuItem))
            {
                MenuItems[menuItem] += amount;
            }
            else
            {
                MenuItems.Add(menuItem, amount);
            }
            AddToSum(menuItem, amount);
        }

        private void AddToSum(IMenuItem menuItem, int amount)
        {
            TotalSum += menuItem.Price * amount;
        }

        public override string ToString()
        {
            string items = "";
            foreach (var item in MenuItems)
            {
                items += $" {item.Key} {item.Value.ToString()},  \n";
            }
            return $"Customer: {Customer.ToString()}    |   Total: {TotalSum} \n {items}";
        }
    }
}
