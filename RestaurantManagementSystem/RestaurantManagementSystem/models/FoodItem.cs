﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.models
{
    class FoodItem: MenuItem
    {
        public FoodItem(string name, string type): base(name, type){}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
