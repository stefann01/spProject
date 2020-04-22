using RestaurantManagementSystem.enums.foods;
using RestaurantManagementSystem.helpers;
using RestaurantManagementSystem.interfaces.foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantManagementSystem.decorator.foods
{
    class PizzaChickenDecorator : PizzaDecorator
    {
        public PizzaChickenDecorator(IPizza decoratedPizza) : base(decoratedPizza)
        {
            DecoratedPizza.Type = EPizzaType.CHICKEN;
            SetDish();
        }

        public override void SetDish()
        {
            DecoratedPizza.Price += Constants.PizzaChickenPrice;
            DecoratedPizza.Quantity += Constants.PizzaChickenQuantity;

            foreach (var ingredient in Constants.PizzaChickenIngredients)
            {
                if (!ContainsIngredient(ingredient))
                    DecoratedPizza.Ingredients.Add(ingredient);
            }
        }
    }
}
