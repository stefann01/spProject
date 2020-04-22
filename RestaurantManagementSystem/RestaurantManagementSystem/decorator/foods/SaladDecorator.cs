using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    public abstract class SaladDecorator : ISalad
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public List<string> Ingredients { get; set; }
        public ESaladType Type { get; set; }

        public ISalad DecoratedSalad { get; set; }

        public SaladDecorator(ISalad decoratedSalad)
        {
            DecoratedSalad = decoratedSalad;
        }

        protected bool ContainsIngredient(string ingredient)
        {
            if (DecoratedSalad.Ingredients.Contains(ingredient))
            {
                return true;
            }
            return false;
        }

        public abstract void SetDish();

        public override string ToString()
        {
            return DecoratedSalad.ToString();
        }
    }
}
