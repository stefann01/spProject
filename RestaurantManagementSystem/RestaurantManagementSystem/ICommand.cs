using RestaurantManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem
{
    interface ICommand
    {
        FoodItem FoodItem { get; set; }
        DrinkItem DrinkItem { get; set; }

        void Execute(int amount);
    }
}
