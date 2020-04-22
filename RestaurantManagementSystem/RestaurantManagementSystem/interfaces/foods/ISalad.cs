using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.interfaces.foods
{
    public interface ISalad : IMenuItem
    {
        public ESaladType Type { get; set; }
    }
}
