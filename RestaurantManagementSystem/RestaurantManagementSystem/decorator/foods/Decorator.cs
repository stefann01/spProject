using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public abstract class Decorator<EType> : IDish<EType>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        EType IDish<EType>.Type { get; set; }

        public IDish<EType> DecoratedObj { get; set; }

        public Decorator(IDish<EType> decoratedObj)
        {
            DecoratedObj = decoratedObj;
        }

        protected bool ContainsIngredient(string ingredient)
        {
            if (DecoratedObj.Ingredients.Contains(ingredient))
            {
                return true;
            }
            return false;
        }

        public abstract void SetDish(double price, double quantity, List<string> ingredients);

        public override string ToString()
        {
            return DecoratedObj.ToString();
        }
    }
}
