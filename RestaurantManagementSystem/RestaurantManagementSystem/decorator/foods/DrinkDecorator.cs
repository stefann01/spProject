using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public abstract class DrinkDecorator : IDrink
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        public EDrinkType Type { get; set; }

        public IDrink DecoratedDrink { get; set; }

        public DrinkDecorator(IDrink decoratedDrink)
        {
            DecoratedDrink = decoratedDrink;
        }

        protected bool ContainsIngredient(string ingredient)
        {
            if (DecoratedDrink.Ingredients.Contains(ingredient))
            {
                return true;
            }
            return false;
        }

        public abstract void SetDish();

        public override string ToString()
        {
            return DecoratedDrink.ToString();
        }
    }
}
