using System;
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

        public override int GetHashCode() => Name?.GetHashCode() ?? 0;

        public override bool Equals(object obj)
        {
            //self check
            if (this == obj)
            {
                return true;
            }

            //null check
            if (obj == null)
            {
                return false;
            }

            //typeCheck and Cast
            if (GetType() != obj.GetType())
            {
                return false;
            }

            FoodItem foodItem = (FoodItem)obj;
            return Object.Equals(Name, foodItem.Name) && Object.Equals(Type, foodItem.Type);
        }
    }
}
