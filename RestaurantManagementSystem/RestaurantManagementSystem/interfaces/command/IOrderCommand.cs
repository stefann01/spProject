using RestaurantManagementSystem.interfaces.foods;
using RestaurantManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    interface IOrderCommand
    {
        IMenuItem menuItem { get; set; }

        void Execute(int amount);
        Order GetOrder();
        void DeleteOrder();
    }
}
