using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public abstract class PizzaDecorator : IPizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        public EPizzaType Type { get; set; }

        public IPizza DecoratedPizza { get; set; }

        public PizzaDecorator(IPizza decoratedPizza)
        {
            DecoratedPizza = decoratedPizza;
        }

        protected bool ContainsIngredient(string ingredient)
        {
            if (DecoratedPizza.Ingredients.Contains(ingredient))
            {
                return true;
            }
            return false;
        }

        public abstract void SetDish();

        public override string ToString()
        {
            return DecoratedPizza.ToString();
        }
    }
}
