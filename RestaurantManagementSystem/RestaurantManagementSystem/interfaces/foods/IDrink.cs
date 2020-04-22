using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.interfaces.foods
{
    public interface IDrink : IMenuItem
    {
        public EDrinkType Type { get; set; }
    }
}
